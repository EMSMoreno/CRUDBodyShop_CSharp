using Library;

namespace CRUD_Oficina_V2
{
    public partial class UIRepair : Form
    {
        private List<Repair> repairs;
        private List<Vehicle> vehicles;
        private List<Mechanic> mechanics;
        private string repairFile = "repairs.txt";

        public UIRepair()
        {
            InitializeComponent();
            repairs = new List<Repair>();
            LoadData();
            LoadVehicles();
            LoadMechanics();
        }

        #region Validações
        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var repair in repairs)
            {
                data.Add(new string[] {
                    repair.Vehicle,
                    repair.Issue,
                    repair.MechanicName,
                    repair.RepairDate.ToString("yyyy-MM-dd"),
                    repair.Cost.ToString(),
                    repair.IsCompleted.ToString()
                });
            }

            FileHandler.SaveData(data, repairFile);
        } //Guarda dados
        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(repairFile);

            foreach (var rowData in data)
            {
                Repair repair = new Repair(
                    rowData[0],                      // Vehicle
                    rowData[1],                      // Issue
                    rowData[2],                      // MechanicName
                    DateTime.Parse(rowData[3]),      // RepairDate
                    Convert.ToDecimal(rowData[4])    // Cost
                )
                {
                    IsCompleted = Convert.ToBoolean(rowData[5])  // Set IsCompleted property
                };

                repairs.Add(repair);
            }

            RefreshRepairList(); // Chama o método para o UI
        } //Carrega dados da classe

        private void LoadVehicles() //Carrega lista de veiculos, c/ respetivo template
        {
            vehicles = UIVehicle.GetVehicle();
            vehicleCb.DataSource = vehicles;
            vehicleCb.DisplayMember = "Name";
        }
        private void LoadMechanics()
        {
            mechanics = UIMechanic.GetMechanic();
            mechanicCombo.DataSource = mechanics;
            mechanicCombo.DisplayMember = "Name";
        } // Carrega lista de mecanicos, c/respetivo template

        private void RefreshRepairList() //Refresca a lista de reparações, c/respetivo template
        {
            repairList.DataSource = null;
            repairList.DataSource = repairs;
            repairList.DisplayMember = "Vehicle";
        }
        private decimal GetSelectedRepairCost() //Vai buscar valor de reparação
        {
            if (repairs != null && repairs.Count > 0 && repairList.SelectedIndex >= 0)
            {
                return repairs[repairList.SelectedIndex].Cost;
            }
            return 0;
        }
        private bool GetSelectedRepairCompletionStatus() //Passa o estado da reparação selecionada
        {
            if (repairs != null && repairs.Count > 0 && repairList.SelectedIndex >= 0)
            {
                return repairs[repairList.SelectedIndex].IsCompleted;
            }
            return false;
        }

        private void ClearForm()
        {
            vehicleCb.Text = "";
            issueInp.Text = "";
            mechanicCombo.Text = "";
            repairDateInp.Value = DateTime.Today;
            costInp.Text = "";
            completedCheckBox.Checked = false;
        } //Limpa o form

        /// <summary>
        /// Verifica se os campos encontram-se nulos, vazios ou somente com espaços.
        /// </summary>
        /// <returns>Retorna true se os campos estiverem devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(vehicleCb.Text) || string.IsNullOrWhiteSpace(issueInp.Text)
                || string.IsNullOrWhiteSpace(mechanicCombo.Text) || string.IsNullOrWhiteSpace(costInp.Text))
            {
                MessageBox.Show("You're missing fields. Check your form before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(costInp.Text, out _))
            {
                MessageBox.Show("Cost must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        } 

        #endregion

        #region Botões
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Repair repair = new Repair(
                    vehicleCb.Text,
                    issueInp.Text,
                    mechanicCombo.Text,
                    repairDateInp.Value,
                    Convert.ToDecimal(costInp.Text)
                )
                {
                    IsCompleted = completedCheckBox.Checked  // Passa propriedade IsCompleted
                };

                repairs.Add(repair);
                SaveData();
                RefreshRepairList();
                ClearForm();

                MessageBox.Show("The requested addition has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Repair selectedRepair = (Repair)repairList.SelectedItem;

                if (selectedRepair != null)
                {
                    selectedRepair.Vehicle = vehicleCb.Text;
                    selectedRepair.Issue = issueInp.Text;
                    selectedRepair.MechanicName = mechanicCombo.Text;
                    selectedRepair.RepairDate = repairDateInp.Value;
                    selectedRepair.Cost = Convert.ToDecimal(costInp.Text);
                    selectedRepair.IsCompleted = completedCheckBox.Checked;

                    SaveData();
                    RefreshRepairList();
                    ClearForm();

                    MessageBox.Show("The requested change has been implemented successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Repair selectedRepair = (Repair)repairList.SelectedItem;

            if (selectedRepair != null)
            {
                var result = MessageBox.Show($"Are you absolutely sure you want to remove repair for {selectedRepair.Vehicle}?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    repairs.Remove(selectedRepair);
                    SaveData();
                    RefreshRepairList();
                    ClearForm();

                    MessageBox.Show($"The removal of repair for {selectedRepair.Vehicle} was successfully performed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void repairList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Repair selectedRepair = (Repair)repairList.SelectedItem;
            if (selectedRepair != null)
            {
                vehicleCb.Text = selectedRepair.Vehicle;
                issueInp.Text = selectedRepair.Issue;
                mechanicCombo.Text = selectedRepair.MechanicName;
                repairDateInp.Value = selectedRepair.RepairDate;
                costInp.Text = selectedRepair.Cost.ToString();
                completedCheckBox.Checked = selectedRepair.IsCompleted;
            }
        }
    }

    #endregion
}
