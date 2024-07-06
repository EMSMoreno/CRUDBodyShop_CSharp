namespace CRUD_Oficina_V2
{
    partial class UIVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIVehicle));
            menuBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            licensePlateInp = new TextBox();
            phoneLbl = new Label();
            yearInp = new TextBox();
            addressLbl = new Label();
            nameLbl = new Label();
            modelInp = new TextBox();
            paragraphLbl = new Label();
            headingLbl = new Label();
            vehicleList = new ListBox();
            brandInp = new TextBox();
            label1 = new Label();
            clientCombo = new ComboBox();
            brandLbl = new Label();
            SuspendLayout();
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.Gainsboro;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.ForeColor = Color.FromArgb(15, 23, 42);
            menuBtn.Location = new Point(705, 378);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(83, 60);
            menuBtn.TabIndex = 55;
            menuBtn.Text = "Return to Main Screen";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatAppearance.CheckedBackColor = Color.White;
            deleteBtn.FlatAppearance.MouseDownBackColor = Color.White;
            deleteBtn.FlatAppearance.MouseOverBackColor = Color.White;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.FromArgb(188, 67, 46);
            deleteBtn.Location = new Point(595, 397);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(104, 23);
            deleteBtn.TabIndex = 54;
            deleteBtn.Text = "Delete Vehicle";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Cursor = Cursors.Hand;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatAppearance.CheckedBackColor = Color.White;
            editBtn.FlatAppearance.MouseDownBackColor = Color.White;
            editBtn.FlatAppearance.MouseOverBackColor = Color.White;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.FromArgb(14, 165, 232);
            editBtn.Location = new Point(485, 397);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(104, 23);
            editBtn.TabIndex = 53;
            editBtn.Text = "Update Vehicle";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(308, 401);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(81, 15);
            pageContentLbl.TabIndex = 52;
            pageContentLbl.Text = "Manage Here:";
            pageContentLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatAppearance.MouseDownBackColor = Color.White;
            addBtn.FlatAppearance.MouseOverBackColor = Color.White;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.DarkCyan;
            addBtn.Location = new Point(395, 397);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(84, 23);
            addBtn.TabIndex = 51;
            addBtn.Text = "Add Vehicle";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // licensePlateInp
            // 
            licensePlateInp.Location = new Point(552, 198);
            licensePlateInp.MaxLength = 20;
            licensePlateInp.Name = "licensePlateInp";
            licensePlateInp.PlaceholderText = "01 - ST - 99";
            licensePlateInp.Size = new Size(124, 23);
            licensePlateInp.TabIndex = 50;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(552, 180);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(124, 15);
            phoneLbl.TabIndex = 49;
            phoneLbl.Text = "Vehicle Licence Plate *";
            // 
            // yearInp
            // 
            yearInp.Location = new Point(552, 133);
            yearInp.MaxLength = 100;
            yearInp.Name = "yearInp";
            yearInp.PlaceholderText = "1990 - Current";
            yearInp.Size = new Size(89, 23);
            yearInp.TabIndex = 48;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(552, 115);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(77, 15);
            addressLbl.TabIndex = 47;
            addressLbl.Text = "Vehicle Year *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(329, 180);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(89, 15);
            nameLbl.TabIndex = 46;
            nameLbl.Text = "Vehicle Model *";
            // 
            // modelInp
            // 
            modelInp.Location = new Point(329, 198);
            modelInp.MaxLength = 50;
            modelInp.Name = "modelInp";
            modelInp.PlaceholderText = "Clio, Auris, Civic, X4, 106, etc";
            modelInp.Size = new Size(193, 23);
            modelInp.TabIndex = 45;
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(329, 65);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(193, 18);
            paragraphLbl.TabIndex = 44;
            paragraphLbl.Text = "Manage all your vehicles";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(329, 22);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(209, 29);
            headingLbl.TabIndex = 43;
            headingLbl.Text = "Vehicle Manager";
            // 
            // vehicleList
            // 
            vehicleList.BackColor = Color.FromArgb(248, 250, 252);
            vehicleList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vehicleList.FormattingEnabled = true;
            vehicleList.ItemHeight = 15;
            vehicleList.Location = new Point(0, 0);
            vehicleList.Name = "vehicleList";
            vehicleList.Size = new Size(302, 454);
            vehicleList.TabIndex = 42;
            vehicleList.SelectedIndexChanged += vehicleList_SelectedIndexChanged;
            // 
            // brandInp
            // 
            brandInp.Location = new Point(329, 133);
            brandInp.MaxLength = 50;
            brandInp.Name = "brandInp";
            brandInp.PlaceholderText = "Renault, Toyota, Honda, etc";
            brandInp.Size = new Size(193, 23);
            brandInp.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 248);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 58;
            label1.Text = "Client's Vehicle*";
            // 
            // clientCombo
            // 
            clientCombo.FormattingEnabled = true;
            clientCombo.Location = new Point(329, 266);
            clientCombo.Name = "clientCombo";
            clientCombo.Size = new Size(347, 23);
            clientCombo.TabIndex = 73;
            // 
            // brandLbl
            // 
            brandLbl.AutoSize = true;
            brandLbl.Location = new Point(329, 115);
            brandLbl.Name = "brandLbl";
            brandLbl.Size = new Size(86, 15);
            brandLbl.TabIndex = 74;
            brandLbl.Text = "Vehicle Brand *";
            // 
            // VisualVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(brandLbl);
            Controls.Add(clientCombo);
            Controls.Add(label1);
            Controls.Add(brandInp);
            Controls.Add(menuBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(licensePlateInp);
            Controls.Add(phoneLbl);
            Controls.Add(yearInp);
            Controls.Add(addressLbl);
            Controls.Add(nameLbl);
            Controls.Add(modelInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(vehicleList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualVehicle";
            Text = "Eduardo's Bodyshop - Vehicles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox licensePlateInp;
        private Label phoneLbl;
        private TextBox yearInp;
        private Label addressLbl;
        private Label nameLbl;
        private TextBox modelInp;
        private Label paragraphLbl;
        private Label headingLbl;
        private ListBox vehicleList;
        private TextBox brandInp;
        private Label label1;
        private ComboBox clientCombo;
        private Label brandLbl;
    }
}