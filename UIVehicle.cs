using Library;

namespace CRUD_Oficina_V2
{
    public partial class UIVehicle : Form
    {
        private List<Vehicle> vehicles;
        private List<Client> clients;
        private string vehiclesFile = "vehicles.txt";
        public UIVehicle()
        {
            InitializeComponent();
            vehicles = new List<Vehicle>();
            LoadData();
            LoadClients();
        }

        public static List<Vehicle> GetVehicle() // Passar lista de veiculos
        {
            UIVehicle visualVehicle = new UIVehicle();
            return visualVehicle.vehicles;
        }

        #region Validações

        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var vehicle in vehicles)
            {
                data.Add(new string[] {
                    vehicle.Brand,
                    vehicle.Model,
                    vehicle.Year,
                    vehicle.LicensePlate,
                    vehicle.ClientName
                });
            }

            FileHandler.SaveData(data, vehiclesFile);
        } // Guarda os dados
        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(vehiclesFile);

            foreach (var rowData in data)
            {
                if (rowData.Length >= 4)
                {
                    string brand = rowData[0];
                    string model = rowData[1];
                    string year = rowData[2];
                    string licensePlate = rowData[3];

                    // Quinto campo no rowData que representa o nome do cliente
                    string clientName = rowData.Length > 4 ? rowData[4] : "";

                    vehicles.Add(new Vehicle(brand, model, year, licensePlate, clientName));
                }
                else
                {
                    // Handle case where rowData doesn't have enough elements
                    Console.WriteLine($"Invalid data format: {string.Join(", ", rowData)}");
                }
            }

            RefreshVehicleList();
        } // Carrega os dados

        private void RefreshVehicleList()
        {
            vehicleList.DataSource = null;
            vehicleList.DataSource = vehicles;
            vehicleList.DisplayMember = "Brand Model | Year"; // Mostra dados na lista
        } //Refresca a lista de clientes c/respetivo template
        private void LoadClients()
        {
            clients = UIClient.GetClients();
            clientCombo.DataSource = clients;
            clientCombo.DisplayMember = "Name";
        } // Carrega lista de clientes

        private void ClearForm() // Limpa o form
        {
            brandInp.Text = "";
            modelInp.Text = "";
            yearInp.Text = "";
            licensePlateInp.Text = "";
            clientCombo.SelectedIndex = -1;
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos, vazios ou somente com espaços.
        /// </summary>
        /// <returns>Retorna true se os campos estiverem devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(brandInp.Text) ||
                string.IsNullOrWhiteSpace(modelInp.Text) ||
                string.IsNullOrWhiteSpace(yearInp.Text) ||
                string.IsNullOrWhiteSpace(licensePlateInp.Text) ||
                clientCombo.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion


        #region Botões CRUD e MainMenu
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Client selectedClient = (Client)clientCombo.SelectedItem;

                if (selectedClient != null)
                {
                    Vehicle vehicle = new Vehicle(
                        brandInp.Text,
                        modelInp.Text,
                        yearInp.Text,
                        licensePlateInp.Text,
                        selectedClient.Name // Nome do cliente
                    );

                    vehicles.Add(vehicle);
                    SaveData();
                    RefreshVehicleList();
                    ClearForm();

                    MessageBox.Show("Vehicle added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleList.SelectedItem;

            if (selectedVehicle != null)
            {
                Client selectedClient = (Client)clientCombo.SelectedItem;

                if (selectedClient != null)
                {
                    selectedVehicle.Brand = brandInp.Text;
                    selectedVehicle.Model = modelInp.Text;
                    selectedVehicle.Year = yearInp.Text;
                    selectedVehicle.LicensePlate = licensePlateInp.Text;
                    selectedVehicle.ClientName = selectedClient.Name; // Atualizando o nome do cliente

                    SaveData();
                    RefreshVehicleList();
                    ClearForm();

                    MessageBox.Show("Vehicle updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleList.SelectedItem;

            if (selectedVehicle != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedVehicle.LicensePlate}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    vehicles.Remove(selectedVehicle);
                    SaveData();
                    RefreshVehicleList();
                    ClearForm();

                    MessageBox.Show("Vehicle deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vehicleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleList.SelectedItem;
            if (selectedVehicle != null)
            {
                brandInp.Text = selectedVehicle.Brand;
                modelInp.Text = selectedVehicle.Model;
                yearInp.Text = selectedVehicle.Year;
                licensePlateInp.Text = selectedVehicle.LicensePlate;

                if (clients != null && !string.IsNullOrEmpty(selectedVehicle.ClientName))
                {
                    // Usando StringComparison.OrdinalIgnoreCase para comparação sem considerar o caso
                    Client client = clients.FirstOrDefault(c => string.Equals(c.Name, selectedVehicle.ClientName, StringComparison.OrdinalIgnoreCase));

                    if (client != null)
                    {
                        clientCombo.SelectedItem = client;
                    }
                    else
                    {
                        clientCombo.SelectedIndex = -1;
                    }
                }
                else
                {
                    clientCombo.SelectedIndex = -1;
                }
            }
        }
        
    }
    #endregion
}
