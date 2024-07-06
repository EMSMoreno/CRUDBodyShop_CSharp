namespace CRUD_Oficina_V2
{
    partial class UIBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIBilling));
            menuBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneLbl = new Label();
            addressLbl = new Label();
            paragraphLbl = new Label();
            headingLbl = new Label();
            billingList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            billingNumberInp = new TextBox();
            billDateTimePicker = new DateTimePicker();
            amountInp = new TextBox();
            label3 = new Label();
            paidLbl = new Label();
            paidCheckBox = new CheckBox();
            mechanicCb = new ComboBox();
            clientCb = new ComboBox();
            completedCheckbox = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.Gainsboro;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.ForeColor = Color.FromArgb(15, 23, 42);
            menuBtn.Location = new Point(712, 378);
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
            deleteBtn.Location = new Point(602, 394);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(104, 23);
            deleteBtn.TabIndex = 54;
            deleteBtn.Text = "Delete Billing";
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
            editBtn.Location = new Point(508, 394);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(96, 23);
            editBtn.TabIndex = 53;
            editBtn.Text = "Update Billing";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(330, 398);
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
            addBtn.Location = new Point(417, 394);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(85, 23);
            addBtn.TabIndex = 51;
            addBtn.Text = "Add Billing";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(341, 186);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(94, 15);
            phoneLbl.TabIndex = 49;
            phoneLbl.Text = "Mechanic Name";
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(540, 251);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(58, 15);
            addressLbl.TabIndex = 47;
            addressLbl.Text = "Bill Date *";
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(340, 53);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(353, 18);
            paragraphLbl.TabIndex = 44;
            paragraphLbl.Text = "Manage all your clientes and vehicles owners.";
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(341, 10);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(196, 29);
            headingLbl.TabIndex = 43;
            headingLbl.Text = "Billing Manager";
            // 
            // billingList
            // 
            billingList.BackColor = Color.FromArgb(248, 250, 252);
            billingList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingList.FormattingEnabled = true;
            billingList.ItemHeight = 15;
            billingList.Location = new Point(0, 0);
            billingList.Name = "billingList";
            billingList.Size = new Size(324, 454);
            billingList.TabIndex = 42;
            billingList.SelectedValueChanged += billingList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 251);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 57;
            label1.Text = "Client Name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 126);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 59;
            label2.Text = "Billing Number *";
            // 
            // billingNumberInp
            // 
            billingNumberInp.Location = new Point(341, 144);
            billingNumberInp.MaxLength = 50;
            billingNumberInp.Name = "billingNumberInp";
            billingNumberInp.PlaceholderText = "#001";
            billingNumberInp.Size = new Size(189, 23);
            billingNumberInp.TabIndex = 58;
            // 
            // billDateTimePicker
            // 
            billDateTimePicker.Location = new Point(536, 269);
            billDateTimePicker.Name = "billDateTimePicker";
            billDateTimePicker.Size = new Size(170, 23);
            billDateTimePicker.TabIndex = 60;
            // 
            // amountInp
            // 
            amountInp.Location = new Point(552, 144);
            amountInp.MaxLength = 20;
            amountInp.Name = "amountInp";
            amountInp.PlaceholderText = "In Euros";
            amountInp.Size = new Size(62, 23);
            amountInp.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 126);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 61;
            label3.Text = "Ammount";
            // 
            // paidLbl
            // 
            paidLbl.AutoSize = true;
            paidLbl.Location = new Point(552, 190);
            paidLbl.Name = "paidLbl";
            paidLbl.Size = new Size(46, 15);
            paidLbl.TabIndex = 63;
            paidLbl.Text = "Is Paid?";
            // 
            // paidCheckBox
            // 
            paidCheckBox.AutoSize = true;
            paidCheckBox.Location = new Point(552, 208);
            paidCheckBox.Name = "paidCheckBox";
            paidCheckBox.Size = new Size(46, 19);
            paidCheckBox.TabIndex = 65;
            paidCheckBox.Text = "Yes!";
            paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // mechanicCb
            // 
            mechanicCb.FormattingEnabled = true;
            mechanicCb.Location = new Point(341, 208);
            mechanicCb.Name = "mechanicCb";
            mechanicCb.Size = new Size(189, 23);
            mechanicCb.TabIndex = 66;
            // 
            // clientCb
            // 
            clientCb.FormattingEnabled = true;
            clientCb.Location = new Point(340, 269);
            clientCb.Name = "clientCb";
            clientCb.Size = new Size(190, 23);
            clientCb.TabIndex = 67;
            // 
            // completedCheckbox
            // 
            completedCheckbox.AutoSize = true;
            completedCheckbox.Location = new Point(611, 208);
            completedCheckbox.Name = "completedCheckbox";
            completedCheckbox.Size = new Size(46, 19);
            completedCheckbox.TabIndex = 70;
            completedCheckbox.Text = "Yes!";
            completedCheckbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(611, 190);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 69;
            label5.Text = "Is Completed?";
            // 
            // UIBilling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(completedCheckbox);
            Controls.Add(label5);
            Controls.Add(clientCb);
            Controls.Add(mechanicCb);
            Controls.Add(paidCheckBox);
            Controls.Add(paidLbl);
            Controls.Add(amountInp);
            Controls.Add(label3);
            Controls.Add(billDateTimePicker);
            Controls.Add(label2);
            Controls.Add(billingNumberInp);
            Controls.Add(label1);
            Controls.Add(menuBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneLbl);
            Controls.Add(addressLbl);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(billingList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UIBilling";
            Text = "Eduardo's Bodyshop - Billings";
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
        private Label paragraphLbl;
        private Label headingLbl;
        private ListBox billingList;
        private Label label1;
        private Label label2;
        private TextBox billingNumberInp;
        private DateTimePicker billDateTimePicker;
        private TextBox amountInp;
        private Label label3;
        private Label paidLbl;
        private CheckBox paidCheckBox;
        private ComboBox mechanicCb;
        private ComboBox clientCb;
        private CheckBox completedCheckbox;
        private Label label5;
    }
}