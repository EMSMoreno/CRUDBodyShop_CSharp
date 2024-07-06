namespace CRUD_Oficina_V2
{
    partial class UIMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMenu));
            sidePanel = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            sponsoredLabel = new Label();
            aboutUsBtn = new Button();
            sideTextLabel = new Label();
            getStartedBtn = new Button();
            sideHeadingLabel = new Label();
            clientBtn = new Button();
            repairBtn = new Button();
            mechanicBtn = new Button();
            billingBtn = new Button();
            headingBtn = new Label();
            textLabel = new Label();
            optionLabel = new Label();
            vehicleBtn = new Button();
            pictureBox4 = new PictureBox();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.SlateGray;
            sidePanel.Controls.Add(pictureBox3);
            sidePanel.Controls.Add(pictureBox1);
            sidePanel.Controls.Add(pictureBox2);
            sidePanel.Controls.Add(sponsoredLabel);
            sidePanel.Controls.Add(aboutUsBtn);
            sidePanel.Controls.Add(sideTextLabel);
            sidePanel.Controls.Add(getStartedBtn);
            sidePanel.Controls.Add(sideHeadingLabel);
            sidePanel.Dock = DockStyle.Right;
            sidePanel.Location = new Point(552, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(282, 417);
            sidePanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(194, 355);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 355);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 355);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // sponsoredLabel
            // 
            sponsoredLabel.Anchor = AnchorStyles.None;
            sponsoredLabel.BackColor = Color.SlateGray;
            sponsoredLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            sponsoredLabel.Location = new Point(12, 315);
            sponsoredLabel.Name = "sponsoredLabel";
            sponsoredLabel.Size = new Size(255, 31);
            sponsoredLabel.TabIndex = 3;
            sponsoredLabel.Text = "Trusted, used and sponsored by:";
            sponsoredLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // aboutUsBtn
            // 
            aboutUsBtn.BackColor = Color.LightGray;
            aboutUsBtn.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            aboutUsBtn.FlatAppearance.MouseOverBackColor = Color.White;
            aboutUsBtn.Location = new Point(9, 256);
            aboutUsBtn.Name = "aboutUsBtn";
            aboutUsBtn.Size = new Size(255, 39);
            aboutUsBtn.TabIndex = 2;
            aboutUsBtn.Text = "About Us";
            aboutUsBtn.UseVisualStyleBackColor = false;
            aboutUsBtn.Click += aboutUsBtn_Click;
            // 
            // sideTextLabel
            // 
            sideTextLabel.Anchor = AnchorStyles.None;
            sideTextLabel.BackColor = Color.SlateGray;
            sideTextLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sideTextLabel.Location = new Point(49, 127);
            sideTextLabel.Name = "sideTextLabel";
            sideTextLabel.Size = new Size(193, 66);
            sideTextLabel.TabIndex = 1;
            sideTextLabel.Text = "Easily manage your vehicles, mechanics, repairs and billings";
            sideTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // getStartedBtn
            // 
            getStartedBtn.BackColor = Color.White;
            getStartedBtn.FlatAppearance.BorderColor = Color.White;
            getStartedBtn.FlatAppearance.MouseDownBackColor = Color.White;
            getStartedBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            getStartedBtn.Location = new Point(9, 211);
            getStartedBtn.Name = "getStartedBtn";
            getStartedBtn.Size = new Size(255, 39);
            getStartedBtn.TabIndex = 1;
            getStartedBtn.Text = "Get Started";
            getStartedBtn.UseVisualStyleBackColor = false;
            getStartedBtn.Click += getStartedBtn_Click;
            // 
            // sideHeadingLabel
            // 
            sideHeadingLabel.Font = new Font("LCDMono2", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sideHeadingLabel.Location = new Point(46, 38);
            sideHeadingLabel.Name = "sideHeadingLabel";
            sideHeadingLabel.Size = new Size(196, 64);
            sideHeadingLabel.TabIndex = 0;
            sideHeadingLabel.Text = "Eduardo's Bodyshop";
            sideHeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // clientBtn
            // 
            clientBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            clientBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            clientBtn.FlatStyle = FlatStyle.Flat;
            clientBtn.ForeColor = Color.FromArgb(67, 80, 98);
            clientBtn.Location = new Point(227, 221);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(109, 63);
            clientBtn.TabIndex = 4;
            clientBtn.Text = "Client \r\n👥";
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // repairBtn
            // 
            repairBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            repairBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            repairBtn.FlatStyle = FlatStyle.Flat;
            repairBtn.ForeColor = Color.FromArgb(67, 80, 98);
            repairBtn.Location = new Point(284, 293);
            repairBtn.Name = "repairBtn";
            repairBtn.Size = new Size(109, 63);
            repairBtn.TabIndex = 5;
            repairBtn.Text = "Repair \U0001f9f0";
            repairBtn.UseVisualStyleBackColor = true;
            repairBtn.Click += repairBtn_Click;
            // 
            // mechanicBtn
            // 
            mechanicBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            mechanicBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            mechanicBtn.FlatStyle = FlatStyle.Flat;
            mechanicBtn.ForeColor = Color.FromArgb(67, 80, 98);
            mechanicBtn.Location = new Point(169, 293);
            mechanicBtn.Name = "mechanicBtn";
            mechanicBtn.Size = new Size(109, 63);
            mechanicBtn.TabIndex = 6;
            mechanicBtn.Text = "Mechanic \r\n🔧";
            mechanicBtn.UseVisualStyleBackColor = true;
            mechanicBtn.Click += mechanicBtn_Click;
            // 
            // billingBtn
            // 
            billingBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            billingBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            billingBtn.FlatStyle = FlatStyle.Flat;
            billingBtn.ForeColor = Color.FromArgb(67, 80, 98);
            billingBtn.Location = new Point(399, 293);
            billingBtn.Name = "billingBtn";
            billingBtn.Size = new Size(104, 63);
            billingBtn.TabIndex = 7;
            billingBtn.Text = "Billing 💶";
            billingBtn.UseVisualStyleBackColor = true;
            billingBtn.Click += billingBtn_Click;
            // 
            // headingBtn
            // 
            headingBtn.Anchor = AnchorStyles.None;
            headingBtn.BackColor = Color.White;
            headingBtn.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headingBtn.Location = new Point(12, 25);
            headingBtn.Name = "headingBtn";
            headingBtn.Size = new Size(502, 42);
            headingBtn.TabIndex = 8;
            headingBtn.Text = "Getting Started with Eduardo's Bodyshop";
            headingBtn.TextAlign = ContentAlignment.TopCenter;
            // 
            // textLabel
            // 
            textLabel.Anchor = AnchorStyles.None;
            textLabel.BackColor = Color.White;
            textLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textLabel.ForeColor = Color.FromArgb(67, 80, 98);
            textLabel.Location = new Point(20, 58);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(369, 62);
            textLabel.TabIndex = 9;
            textLabel.Text = "Our bodyshop enables you to operate using a bodyshop a-like functions.";
            textLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // optionLabel
            // 
            optionLabel.Anchor = AnchorStyles.None;
            optionLabel.BackColor = Color.White;
            optionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optionLabel.ForeColor = Color.Gray;
            optionLabel.Location = new Point(20, 230);
            optionLabel.Name = "optionLabel";
            optionLabel.Size = new Size(159, 32);
            optionLabel.TabIndex = 10;
            optionLabel.Text = "Select an option:";
            optionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // vehicleBtn
            // 
            vehicleBtn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            vehicleBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 249, 255);
            vehicleBtn.FlatStyle = FlatStyle.Flat;
            vehicleBtn.ForeColor = Color.FromArgb(67, 80, 98);
            vehicleBtn.Location = new Point(342, 221);
            vehicleBtn.Name = "vehicleBtn";
            vehicleBtn.Size = new Size(109, 63);
            vehicleBtn.TabIndex = 11;
            vehicleBtn.Text = "Vehicle \r\n🚗";
            vehicleBtn.UseVisualStyleBackColor = true;
            vehicleBtn.Click += vehicleBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(399, 80);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(147, 108);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // VisualMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 417);
            Controls.Add(pictureBox4);
            Controls.Add(vehicleBtn);
            Controls.Add(optionLabel);
            Controls.Add(textLabel);
            Controls.Add(headingBtn);
            Controls.Add(billingBtn);
            Controls.Add(mechanicBtn);
            Controls.Add(repairBtn);
            Controls.Add(clientBtn);
            Controls.Add(sidePanel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VisualMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eduardo's Workshop - MainMenu";
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Label sideHeadingLabel;
        private Button getStartedBtn;
        private Label sideTextLabel;
        private Button aboutUsBtn;
        private Button clientBtn;
        private Button repairBtn;
        private Button mechanicBtn;
        private Button billingBtn;
        private Label sponsoredLabel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label headingBtn;
        private Label textLabel;
        private Label optionLabel;
        private Button vehicleBtn;
        private PictureBox pictureBox4;
    }
}
