namespace CRUD_Oficina_V2
{
    partial class UIClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIClient));
            clientList = new ListBox();
            menuBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            pageContentLbl = new Label();
            addBtn = new Button();
            phoneInp = new TextBox();
            phoneLbl = new Label();
            addressInp = new TextBox();
            addressLbl = new Label();
            nameLbl = new Label();
            nameInp = new TextBox();
            paragraphLbl = new Label();
            headingLbl = new Label();
            SuspendLayout();
            // 
            // clientList
            // 
            clientList.BackColor = Color.FromArgb(248, 250, 252);
            clientList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientList.FormattingEnabled = true;
            clientList.ItemHeight = 15;
            clientList.Location = new Point(0, 0);
            clientList.Name = "clientList";
            clientList.Size = new Size(282, 454);
            clientList.TabIndex = 0;
            clientList.SelectedIndexChanged += clientList_SelectedIndexChanged;
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.Gainsboro;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.ForeColor = Color.FromArgb(15, 23, 42);
            menuBtn.Location = new Point(657, 378);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(83, 60);
            menuBtn.TabIndex = 41;
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
            deleteBtn.Location = new Point(558, 397);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(84, 23);
            deleteBtn.TabIndex = 40;
            deleteBtn.Text = "Delete Client";
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
            editBtn.Location = new Point(462, 397);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(90, 23);
            editBtn.TabIndex = 39;
            editBtn.Text = "Update Client";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // pageContentLbl
            // 
            pageContentLbl.AutoSize = true;
            pageContentLbl.Location = new Point(294, 401);
            pageContentLbl.Name = "pageContentLbl";
            pageContentLbl.Size = new Size(81, 15);
            pageContentLbl.TabIndex = 38;
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
            addBtn.Location = new Point(381, 397);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 37;
            addBtn.Text = "Add Client";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // phoneInp
            // 
            phoneInp.Location = new Point(297, 299);
            phoneInp.MaxLength = 20;
            phoneInp.Name = "phoneInp";
            phoneInp.PlaceholderText = "21 991 990";
            phoneInp.Size = new Size(189, 23);
            phoneInp.TabIndex = 36;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(297, 280);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(122, 15);
            phoneLbl.TabIndex = 35;
            phoneLbl.Text = "Client Phone Number";
            // 
            // addressInp
            // 
            addressInp.Location = new Point(297, 225);
            addressInp.MaxLength = 100;
            addressInp.Name = "addressInp";
            addressInp.PlaceholderText = "Street Name, Av. Name. etc";
            addressInp.Size = new Size(189, 23);
            addressInp.TabIndex = 34;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Location = new Point(297, 206);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(91, 15);
            addressLbl.TabIndex = 33;
            addressLbl.Text = "Client Address *";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(297, 132);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(81, 15);
            nameLbl.TabIndex = 32;
            nameLbl.Text = "Client Name *";
            // 
            // nameInp
            // 
            nameInp.Location = new Point(298, 150);
            nameInp.MaxLength = 50;
            nameInp.Name = "nameInp";
            nameInp.PlaceholderText = "First and Last Name";
            nameInp.Size = new Size(189, 23);
            nameInp.TabIndex = 31;
            // 
            // paragraphLbl
            // 
            paragraphLbl.AutoSize = true;
            paragraphLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            paragraphLbl.ForeColor = Color.FromArgb(118, 132, 153);
            paragraphLbl.Location = new Point(297, 66);
            paragraphLbl.Name = "paragraphLbl";
            paragraphLbl.Size = new Size(255, 18);
            paragraphLbl.TabIndex = 30;
            paragraphLbl.Text = "Manage all your clientes owners.";
            paragraphLbl.Click += paragraphLbl_Click;
            // 
            // headingLbl
            // 
            headingLbl.AutoSize = true;
            headingLbl.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold);
            headingLbl.ForeColor = Color.FromArgb(15, 23, 42);
            headingLbl.Location = new Point(297, 23);
            headingLbl.Name = "headingLbl";
            headingLbl.Size = new Size(190, 29);
            headingLbl.TabIndex = 29;
            headingLbl.Text = "Client Manager";
            // 
            // VisualClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 450);
            Controls.Add(menuBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(pageContentLbl);
            Controls.Add(addBtn);
            Controls.Add(phoneInp);
            Controls.Add(phoneLbl);
            Controls.Add(addressInp);
            Controls.Add(addressLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameInp);
            Controls.Add(paragraphLbl);
            Controls.Add(headingLbl);
            Controls.Add(clientList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisualClient";
            Text = "Eduardo BodyShop - Clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox clientList;
        private Button menuBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Label pageContentLbl;
        private Button addBtn;
        private TextBox phoneInp;
        private Label phoneLbl;
        private TextBox addressInp;
        private Label addressLbl;
        private Label nameLbl;
        private TextBox nameInp;
        private Label paragraphLbl;
        private Label headingLbl;
    }
}