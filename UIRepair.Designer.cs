namespace CRUD_Oficina_V2
{
    partial class UIRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIRepair));
            menuBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneLbl = new Label();
            addressLbl = new Label();
            nameLbl = new Label();
            paragraphLbl = new Label();
            headingLbl = new Label();
            repairList = new ListBox();
            vehicleCb = new ComboBox();
            mechanicCombo = new ComboBox();
            repairDateInp = new DateTimePicker();
            label1 = new Label();
            issueInp = new TextBox();
            label2 = new Label();
            costInp = new TextBox();
            label3 = new Label();
            completedCheckBox = new CheckBox();
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
            menuBtn.TabIndex = 69;
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
            deleteBtn.Location = new Point(610, 397);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(89, 23);
            deleteBtn.TabIndex = 68;
            deleteBtn.Text = "Delete Repair";
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
            editBtn.Location = new Point(503, 397);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(101, 23);
            editBtn.TabIndex = 67;
            editBtn.Text = "Update Repair";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(335, 401);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(81, 15);
            pageContentLbl.TabIndex = 66;
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
            addBtn.Location = new Point(422, 397);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 65;
            addBtn.Text = "Add Repair";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(349, 280);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(75, 15);
            phoneLbl.TabIndex = 64;
            phoneLbl.Text = "Repair Date *";
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(348, 210);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(102, 15);
            addressLbl.TabIndex = 62;
            addressLbl.Text = "Mechanic Name *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(348, 136);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(86, 15);
            nameLbl.TabIndex = 61;
            nameLbl.Text = "Client Vehicle *";
            // 
            // paragraphLbl
            // 
            paragraphLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(349, 66);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(321, 27);
            paragraphLbl.TabIndex = 59;
            paragraphLbl.Text = "Manage all your customers repairs\r\n\r\n\r\n";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(349, 22);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(200, 29);
            headingLbl.TabIndex = 58;
            headingLbl.Text = "Repair Manager";
            // 
            // repairList
            // 
            repairList.BackColor = Color.FromArgb(248, 250, 252);
            repairList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repairList.FormattingEnabled = true;
            repairList.ItemHeight = 15;
            repairList.Location = new Point(0, 0);
            repairList.Name = "repairList";
            repairList.Size = new Size(332, 454);
            repairList.TabIndex = 57;
            repairList.SelectedIndexChanged += repairList_SelectedIndexChanged;
            // 
            // vehicleCb
            // 
            vehicleCb.FormattingEnabled = true;
            vehicleCb.Location = new Point(349, 154);
            vehicleCb.Name = "vehicleCb";
            vehicleCb.Size = new Size(238, 23);
            vehicleCb.TabIndex = 71;
            // 
            // mechanicCombo
            // 
            mechanicCombo.FormattingEnabled = true;
            mechanicCombo.Location = new Point(348, 228);
            mechanicCombo.Name = "mechanicCombo";
            mechanicCombo.Size = new Size(122, 23);
            mechanicCombo.TabIndex = 72;
            // 
            // repairDateInp
            // 
            repairDateInp.CalendarForeColor = Color.FromArgb(118, 132, 153);
            repairDateInp.CalendarTitleBackColor = Color.FromArgb(14, 165, 232);
            repairDateInp.CalendarTitleForeColor = Color.FromArgb(118, 132, 153);
            repairDateInp.CalendarTrailingForeColor = Color.FromArgb(118, 132, 153);
            repairDateInp.Location = new Point(348, 298);
            repairDateInp.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            repairDateInp.Name = "repairDateInp";
            repairDateInp.Size = new Size(175, 23);
            repairDateInp.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 210);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 75;
            label1.Text = "Client's Issue *";
            // 
            // issueInp
            // 
            issueInp.Location = new Point(476, 228);
            issueInp.MaxLength = 50;
            issueInp.Name = "issueInp";
            issueInp.PlaceholderText = "Align Direction, etc";
            issueInp.Size = new Size(194, 23);
            issueInp.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(595, 136);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 77;
            label2.Text = "Repair Cost *";
            // 
            // costInp
            // 
            costInp.Location = new Point(595, 154);
            costInp.MaxLength = 50;
            costInp.Name = "costInp";
            costInp.PlaceholderText = "700 euros";
            costInp.Size = new Size(75, 23);
            costInp.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 280);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 79;
            label3.Text = "Is Completed?";
            // 
            // completedCheckBox
            // 
            completedCheckBox.AutoSize = true;
            completedCheckBox.Location = new Point(543, 303);
            completedCheckBox.Name = "completedCheckBox";
            completedCheckBox.Size = new Size(46, 19);
            completedCheckBox.TabIndex = 80;
            completedCheckBox.Text = "Yes!";
            completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // VisualRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(completedCheckBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(costInp);
            Controls.Add(label1);
            Controls.Add(issueInp);
            Controls.Add(repairDateInp);
            Controls.Add(mechanicCombo);
            Controls.Add(vehicleCb);
            Controls.Add(menuBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneLbl);
            Controls.Add(addressLbl);
            Controls.Add(nameLbl);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(repairList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualRepair";
            Text = "Eduardo's Bodyshop - Repairs";
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
        private Label addressLbl;
        private Label nameLbl;
        private Label paragraphLbl;
        private Label headingLbl;
        private ListBox repairList;
        private ComboBox vehicleCb;
        private ComboBox mechanicCombo;
        private DateTimePicker repairDateInp;
        private Label label1;
        private TextBox issueInp;
        private Label label2;
        private TextBox costInp;
        private Label label3;
        private CheckBox completedCheckBox;
    }
}