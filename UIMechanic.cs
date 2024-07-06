using Library;

namespace CRUD_Oficina_V2
{
    public partial class UIMechanic : Form
    {
        private List<Mechanic> mechanics;
        private List<Vehicle> vehicles;
        private string mechanicFile = "mechanics.txt";

        public UIMechanic()
        {
            InitializeComponent();
            mechanics = new List<Mechanic>();
            vehicles = new List<Vehicle>();
            LoadData();
            LoadVehicles();
            RefreshMechanicList();
        }

        public static List<Mechanic> GetMechanic()
        {
            UIMechanic visualMechanic = new UIMechanic();
            return visualMechanic.mechanics;
        }

        #region Validações
        private void SaveData()
        {
            List<string[]> data = new List<string[]>();
            foreach (var mechanic in mechanics)
            {
                string vehicleDetails = string.Join(",", mechanic.Vehicle.Select(v => $"{v.LicensePlate}|{v.Brand}|{v.Model}|{v.Year}|{v.ClientName}"));
                data.Add(new string[]
                {
                    mechanic.Name,
                    mechanic.Specialty,
                    mechanic.YearsOfExperience.ToString(),
                    vehicleDetails // Salvar os detalhes dos veículos associados
                });
            }

            FileHandler.SaveData(data, mechanicFile);
        }

        private void LoadData()
        {
            List<string[]> data = FileHandler.ReadData(mechanicFile);
            mechanics.Clear();

            foreach (var rowData in data)
            {
                if (rowData.Length >= 4)
                {
                    string name = rowData[0];
                    string specialty = rowData[1];
                    int yearsOfExperience = int.Parse(rowData[2]);
                    string[] vehicleData = rowData[3].Split(',');

                    List<Vehicle> mechanicVehicles = new List<Vehicle>();
                    foreach (var vehicleString in vehicleData)
                    {
                        var vehicleDetails = vehicleString.Split('|');
                        if (vehicleDetails.Length == 5)
                        {
                            string licensePlate = vehicleDetails[0];
                            string brand = vehicleDetails[1];
                            string model = vehicleDetails[2];
                            string year = vehicleDetails[3];
                            string clientName = vehicleDetails[4];

                            Vehicle vehicle = vehicles.FirstOrDefault(v => v.LicensePlate == licensePlate);
                            if (vehicle == null)
                            {
                                vehicle = new Vehicle(brand, model, year, licensePlate, clientName);
                                vehicles.Add(vehicle);
                            }
                            mechanicVehicles.Add(vehicle);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid vehicle data format: {vehicleString}");
                        }
                    }

                    Mechanic mechanic = new Mechanic(name, specialty, yearsOfExperience)
                    {
                        Vehicle = mechanicVehicles
                    };

                    mechanics.Add(mechanic);
                }
                else
                {
                    Console.WriteLine($"Invalid data format: {string.Join(", ", rowData)}");
                }
            }

            RefreshMechanicList();
        }

        private void LoadVehicles()
        {
            vehicles = UIVehicle.GetVehicle();
            vehicleCb.DataSource = vehicles;
            vehicleCb.DisplayMember = "Brand Model LicensePlate"; // Exibir a placa do veículo na combobox
        }

        private void RefreshMechanicList()
        {
            mechanicList.DataSource = null;
            mechanicList.DataSource = mechanics;
            mechanicList.DisplayMember = "Name Specialty"; // Exibir o nome do mecânico na lista
        }

        private void ClearForm()
        {
            nameInp.Text = "";
            specialityInp.Text = "";
            experienceInp.Text = "";
            vehicleCb.SelectedIndex = -1;
        }

        /// <summary>
        /// Verifica se os campos encontram-se nulos, vazios ou somente com espaços.
        /// </summary>
        /// <returns>Retorna true se os campos estiverem devidamente preenchidos.</returns>
        private bool CheckForm()
        {
            if (string.IsNullOrWhiteSpace(nameInp.Text) ||
                string.IsNullOrWhiteSpace(specialityInp.Text) ||
                string.IsNullOrWhiteSpace(experienceInp.Text) ||
                vehicleCb.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Vehicle selectedVehicle = (Vehicle)vehicleCb.SelectedItem;

                if (selectedVehicle != null)
                {
                    Mechanic mechanic = new Mechanic(
                        nameInp.Text,
                        specialityInp.Text,
                        int.Parse(experienceInp.Text)
                    );

                    mechanic.Vehicle.Add(selectedVehicle);
                    mechanics.Add(mechanic);
                    SaveData();
                    RefreshMechanicList();
                    ClearForm();

                    MessageBox.Show("Mechanic added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = (Mechanic)mechanicList.SelectedItem;

            if (selectedMechanic != null)
            {
                Vehicle selectedVehicle = (Vehicle)vehicleCb.SelectedItem;

                if (selectedVehicle != null)
                {
                    selectedMechanic.Name = nameInp.Text;
                    selectedMechanic.Specialty = specialityInp.Text;
                    selectedMechanic.YearsOfExperience = int.Parse(experienceInp.Text);
                    selectedMechanic.Vehicle.Clear();
                    selectedMechanic.Vehicle.Add(selectedVehicle);

                    SaveData();
                    RefreshMechanicList();
                    ClearForm();

                    MessageBox.Show("Mechanic updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = (Mechanic)mechanicList.SelectedItem;

            if (selectedMechanic != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedMechanic.Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    mechanics.Remove(selectedMechanic);
                    SaveData();
                    RefreshMechanicList();
                    ClearForm();

                    MessageBox.Show("Mechanic deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mechanicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = (Mechanic)mechanicList.SelectedItem;
            if (selectedMechanic != null)
            {
                nameInp.Text = selectedMechanic.Name;
                specialityInp.Text = selectedMechanic.Specialty;
                experienceInp.Text = selectedMechanic.YearsOfExperience.ToString();

                if (vehicles != null && selectedMechanic.Vehicle.Any())
                {
                    Vehicle vehicle = selectedMechanic.Vehicle.FirstOrDefault();

                    if (vehicle != null)
                    {
                        vehicleCb.SelectedItem = vehicles.FirstOrDefault(v => v.LicensePlate == vehicle.LicensePlate);
                    }
                    else
                    {
                        vehicleCb.SelectedIndex = -1;
                    }
                }
                else
                {
                    vehicleCb.SelectedIndex = -1;
                }
            }
            else
            {
                ClearForm();
            }
        }
        #endregion
    }
}
