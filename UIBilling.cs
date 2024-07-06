using Library;

namespace CRUD_Oficina_V2
{
    public partial class UIBilling : Form
    {
        private List<Billing> billings;
        private List<Mechanic> mechanics;
        private List<Client> clients;
        private string billingFile = "billings.txt";
        private decimal repairCost;

        public UIBilling()
        {
            InitializeComponent();
            billings = new List<Billing>();
            mechanics = new List<Mechanic>();
            clients = new List<Client>();
            LoadData();
            LoadMechanics();
            LoadClients();

            billingList.SelectedIndexChanged += new EventHandler(billingList_SelectedIndexChanged);
        }

        private void SetRepairCost()
        {
            amountInp.Text = repairCost.ToString();
        }

        #region Validações
        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var billing in billings)
            {
                data.Add(new string[]
                {
                    billing.BillNumber,
                    billing.ClientName,
                    billing.MechanicName,
                    billing.BillDate.ToString("yyyy-MM-dd"),
                    billing.Amount.ToString(),
                    billing.IsPaid.ToString()
                });
            }

            FileHandler.SaveData(data, billingFile);
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(billingFile);

            foreach (var rowData in data)
            {
                try
                {
                    // Verifique se a linha tem o número correto de colunas
                    if (rowData.Length < 6)
                    {
                        Console.WriteLine($"Invalid data format: {string.Join(", ", rowData)}");
                        continue;
                    }

                    // Tente converter os dados para os tipos corretos
                    string billNumber = rowData[0];
                    string clientName = rowData[1];
                    string mechanicName = rowData[2];
                    DateTime billDate = DateTime.Parse(rowData[3]); // Pode lançar uma exceção
                    decimal amount = Convert.ToDecimal(rowData[4]); // Pode lançar uma exceção
                    bool isPaid = Convert.ToBoolean(rowData[5]); // Pode lançar uma exceção

                    // Crie um objeto Billing com os dados convertidos
                    Billing billing = new Billing(
                        billNumber,
                        clientName,
                        mechanicName,
                        billDate,
                        amount,
                        isPaid
                    );

                    billings.Add(billing);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Data format error: {ex.Message}. Data: {string.Join(", ", rowData)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}. Data: {string.Join(", ", rowData)}");
                }
            }

            RefreshBillingList();
        }

        private void LoadMechanics()
        {
            mechanics = UIMechanic.GetMechanic();
            mechanicCb.DataSource = mechanics;
            mechanicCb.DisplayMember = "Name";
        }

        private void LoadClients()
        {
            clients = UIClient.GetClients();
            clientCb.DataSource = clients;
            clientCb.DisplayMember = "Name";
        }

        private void RefreshBillingList()
        {
            billingList.DataSource = null;
            billingList.DataSource = billings;
            billingList.DisplayMember = "BillNumber";
        }

        private string GenerateBillNumber(bool isPaid)
        {
            string status = isPaid ? "PAID" : "UNPAID";
            return $"BILL- {DateTime.Now.Ticks} - {status}";
        }

        private void ClearForm()
        {
            billingNumberInp.Text = "";
            clientCb.SelectedIndex = -1;
            mechanicCb.SelectedIndex = -1;
            amountInp.Text = "";
            paidCheckBox.Checked = false;
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos, vazios ou somente com espaços.
        /// </summary>
        /// <returns>Retorna true se os campos estiverem devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (clientCb.SelectedIndex == -1 || mechanicCb.SelectedIndex == -1 || string.IsNullOrWhiteSpace(amountInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(amountInp.Text, out _))
            {
                MessageBox.Show("Amount must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region Botões - CRUD e MainMenu
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                string billNumber = GenerateBillNumber(paidCheckBox.Checked);

                Billing billing = new Billing(
                    billNumber,
                    clientCb.Text,
                    mechanicCb.Text,
                    billDateTimePicker.Value,
                    Convert.ToDecimal(amountInp.Text),
                    paidCheckBox.Checked
                );

                billings.Add(billing);
                SaveData();
                RefreshBillingList();
                ClearForm();

                MessageBox.Show("The addition request has been successfully implemented!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Billing selectedBilling = (Billing)billingList.SelectedItem;

                if (selectedBilling != null)
                {
                    selectedBilling.ClientName = clientCb.Text;
                    selectedBilling.MechanicName = mechanicCb.Text;
                    selectedBilling.BillDate = billDateTimePicker.Value;
                    selectedBilling.Amount = Convert.ToDecimal(amountInp.Text);
                    selectedBilling.IsPaid = paidCheckBox.Checked;

                    SaveData();
                    RefreshBillingList();
                    ClearForm();

                    MessageBox.Show("Billing record updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Billing selectedBilling = (Billing)billingList.SelectedItem;

            if (selectedBilling != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete billing record {selectedBilling.BillNumber}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    billings.Remove(selectedBilling);
                    SaveData();
                    RefreshBillingList();
                    ClearForm();

                    MessageBox.Show("Billing record deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void billingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Billing selectedBilling = (Billing)billingList.SelectedItem;

            if (selectedBilling != null)
            {
                Client client = clients.FirstOrDefault(c => c.Name == selectedBilling.ClientName);
                if (client != null)
                {
                    clientCb.SelectedItem = client;
                }
                else
                {
                    clientCb.SelectedIndex = -1;
                }

                Mechanic mechanic = mechanics.FirstOrDefault(m => m.Name == selectedBilling.MechanicName);
                if (mechanic != null)
                {
                    mechanicCb.SelectedItem = mechanic;
                }
                else
                {
                    mechanicCb.SelectedIndex = -1;
                }

                billingNumberInp.Text = selectedBilling.BillNumber;
                amountInp.Text = selectedBilling.Amount.ToString();
                paidCheckBox.Checked = selectedBilling.IsPaid;
            }
        }
        #endregion
    }
}
