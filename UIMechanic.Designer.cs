namespace CRUD_Oficina_V2
{
    partial class UIMechanic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMechanic));
            menuBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneLbl = new Label();
            specialityInp = new TextBox();
            addressLbl = new Label();
            nameLbl = new Label();
            nameInp = new TextBox();
            paragraphLbl = new Label();
            headingLbl = new Label();
            mechanicList = new ListBox();
            vehicleCb = new ComboBox();
            label2 = new Label();
            experienceInp = new TextBox();
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
            deleteBtn.Location = new Point(589, 396);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(104, 23);
            deleteBtn.TabIndex = 54;
            deleteBtn.Text = "Delete Mechanic";
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
            editBtn.Location = new Point(473, 397);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(110, 23);
            editBtn.TabIndex = 53;
            editBtn.Text = "Update Mechanic";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(287, 400);
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
            addBtn.Location = new Point(374, 396);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(95, 23);
            addBtn.TabIndex = 51;
            addBtn.Text = "Add Mechanic";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(288, 286);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(146, 15);
            phoneLbl.TabIndex = 49;
            phoneLbl.Text = "Client Vehicle Associated *";
            // 
            // specialityInp
            // 
            specialityInp.Location = new Point(287, 231);
            specialityInp.MaxLength = 100;
            specialityInp.Name = "specialityInp";
            specialityInp.PlaceholderText = "Change Oil, Replace Brakes, etc";
            specialityInp.Size = new Size(189, 23);
            specialityInp.TabIndex = 48;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(287, 212);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(65, 15);
            addressLbl.TabIndex = 47;
            addressLbl.Text = "Speciality *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(288, 138);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(102, 15);
            nameLbl.TabIndex = 46;
            nameLbl.Text = "Mechanic Name *";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(288, 156);
            nameInp.MaxLength = 50;
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "First and Last Name";
            nameInp.Size = new Size(297, 23);
            nameInp.TabIndex = 45;
            // 
            // paragraphLbl
            // 
            paragraphLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(288, 63);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(321, 46);
            paragraphLbl.TabIndex = 44;
            paragraphLbl.Text = "Manage all your mechanic associated to your client and vehicle\r\n\r\n";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(288, 20);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(233, 29);
            headingLbl.TabIndex = 43;
            headingLbl.Text = "Mechanic Manager";
            // 
            // mechanicList
            // 
            mechanicList.BackColor = Color.FromArgb(248, 250, 252);
            mechanicList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mechanicList.FormattingEnabled = true;
            mechanicList.ItemHeight = 15;
            mechanicList.Location = new Point(0, 0);
            mechanicList.Name = "mechanicList";
            mechanicList.Size = new Size(282, 454);
            mechanicList.TabIndex = 42;
            mechanicList.SelectedIndexChanged += mechanicList_SelectedIndexChanged;
            // 
            // vehicleCb
            // 
            vehicleCb.FormattingEnabled = true;
            vehicleCb.Location = new Point(288, 304);
            vehicleCb.Name = "vehicleCb";
            vehicleCb.Size = new Size(297, 23);
            vehicleCb.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 212);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 60;
            label2.Text = "Exp. Years*";
            // 
            // experienceInp
            // 
            experienceInp.Location = new Point(492, 230);
            experienceInp.MaxLength = 50;
            experienceInp.Name = "experienceInp";
            experienceInp.PlaceholderText = "4 years";
            experienceInp.Size = new Size(93, 23);
            experienceInp.TabIndex = 59;
            // 
            // UIMechanic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(experienceInp);
            Controls.Add(vehicleCb);
            Controls.Add(menuBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneLbl);
            Controls.Add(specialityInp);
            Controls.Add(addressLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(mechanicList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UIMechanic";
            Text = "Eduardo's Bodyshop - Mechanics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private Label phoneLbl;
        private TextBox specialityInp;
        private Label addressLbl;
        private Label nameLbl;
        private TextBox nameInp;
        private Label paragraphLbl;
        private Label headingLbl;
        private ListBox mechanicList;
        private ComboBox vehicleCb;
        private Label label2;
        private TextBox experienceInp;
    }
}