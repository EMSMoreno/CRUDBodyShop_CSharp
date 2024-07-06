using Library;

namespace CRUD_Oficina_V2
{
    public partial class UIClient : Form
    {
        public List<Client> clients;
        private string clientFile = "clients.txt";

        public UIClient()
        {
            InitializeComponent();
            clients = new List<Client>();
            LoadData();
        }

        #region Validações

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var client in clients)
            {
                data.Add(new string[] {
                    client.Id.ToString(),
                    client.Name,
                    client.Address,
                    client.Phone
                });
            }

            FileHandler.SaveData(data, clientFile);
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(clientFile);
            clients.Clear(); // Limpar a lista antes de carregar novos dados

            foreach (var rowData in data)
            {
                int id = Convert.ToInt32(rowData[0]);
                string name = rowData[1];
                string address = rowData[2];
                string phone = rowData[3];

                Client client = new Client
                {
                    Id = id,
                    Name = name,
                    Address = address,
                    Phone = phone
                };

                clients.Add(client);
            }

            RefreshClientList();
        }

        private void RefreshClientList()
        {
            clientList.DataSource = null;
            clientList.DataSource = clients;
            clientList.DisplayMember = "Name";
        }

        /// <summary>
        /// Obtém o próximo ID do cliente
        /// </summary>
        /// <returns>Retorna sempre o próximo ID</returns>
        private int GetNextClientId()
        {
            return clients.Count > 0 ? clients[^1].Id + 1 : 1;
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            addressInp.Text = "";
            phoneInp.Text = "";
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos, vazios ou somente com espaços.
        /// </summary>
        /// <returns>Retorna true se os campos estiverem devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) ||
                string.IsNullOrWhiteSpace(addressInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static List<Client> GetClients()
        {
            UIClient vc = new UIClient();
            return vc.clients;
        }

        private void phoneInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("That doesn't appear to be a number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botões CRUD e MainMenu

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Client client = new Client
                {
                    Id = GetNextClientId(),
                    Name = nameInp.Text,
                    Address = addressInp.Text,
                    Phone = phoneInp.Text
                };

                clients.Add(client);
                SaveData();
                RefreshClientList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Client selectedClient = (Client)clientList.SelectedItem;

                if (selectedClient != null)
                {
                    selectedClient.Name = nameInp.Text;
                    selectedClient.Address = addressInp.Text;
                    selectedClient.Phone = phoneInp.Text;

                    SaveData();
                    RefreshClientList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientList.SelectedItem;

            if (selectedClient != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to remove {selectedClient.Name}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    clients.Remove(selectedClient);
                    SaveData();
                    RefreshClientList();
                    ClearForm();

                    MessageBox.Show($"The removal of {selectedClient.Name} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    DialogResult confirmAllResult = MessageBox.Show("Do you intend to remove all clients instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmAllResult == DialogResult.Yes)
                    {
                        clients.Clear();
                        SaveData();
                        RefreshClientList();
                        ClearForm();

                        MessageBox.Show("All removals have been successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client selectedClient = (Client)clientList.SelectedItem;
            if (selectedClient != null)
            {
                nameInp.Text = selectedClient.Name;
                addressInp.Text = selectedClient.Address;
                phoneInp.Text = selectedClient.Phone;
            }
            else
            {
                ClearForm();
            }
        }

        // Não usado
        private void paragraphLbl_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
