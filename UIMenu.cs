namespace CRUD_Oficina_V2
{
    public partial class UIMenu : Form
    {
        public UIMenu()
        {
            InitializeComponent();
        }

        #region Bot�es Side Panel

        private void getStartedBtn_Click(object sender, EventArgs e)
        {
            UIClient client = new UIClient();
            client.Show();
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            UIAboutUs visualAboutUs = new UIAboutUs();
            visualAboutUs.Show();
        }

        #endregion


        #region Bot�es Main Menu

        private void clientBtn_Click(object sender, EventArgs e)
        {
            UIClient visualClient = new UIClient();
            visualClient.Show();
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            UIVehicle visualVehicle = new UIVehicle();
            visualVehicle.Show();
        }

        private void mechanicBtn_Click(object sender, EventArgs e)
        {
            UIMechanic visualMechanic = new UIMechanic();
            visualMechanic.Show();
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            UIRepair visualRepair = new UIRepair();
            visualRepair.Show();
        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            UIBilling visualBilling = new UIBilling();
            visualBilling.Show();
        }

        #endregion

        //N�o usado
        private void sideHeadingLbl_Click(object sender, EventArgs e)
        {
            //
        }

    }
}
