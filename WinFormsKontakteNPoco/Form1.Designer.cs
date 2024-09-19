namespace WinFormsKontakteNPoco
{
    partial class Form1
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
            panel1 = new Panel();
            buttonCloseApp = new Button();
            buttonDelContact = new Button();
            buttonEditContact = new Button();
            buttonAddContact = new Button();
            labelEmail = new Label();
            labelPhone = new Label();
            labelName = new Label();
            labelForename = new Label();
            labelId = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            textBoxForename = new TextBox();
            textBoxId = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonCloseApp);
            panel1.Controls.Add(buttonDelContact);
            panel1.Controls.Add(buttonEditContact);
            panel1.Controls.Add(buttonAddContact);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelForename);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxForename);
            panel1.Controls.Add(textBoxId);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 201);
            panel1.TabIndex = 0;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.Location = new Point(635, 148);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(96, 23);
            buttonCloseApp.TabIndex = 13;
            buttonCloseApp.Text = "Close App";
            buttonCloseApp.UseVisualStyleBackColor = true;
            buttonCloseApp.Click += buttonCloseApp_Click;
            // 
            // buttonDelContact
            // 
            buttonDelContact.Location = new Point(635, 108);
            buttonDelContact.Name = "buttonDelContact";
            buttonDelContact.Size = new Size(96, 23);
            buttonDelContact.TabIndex = 12;
            buttonDelContact.Text = "Delete Contact";
            buttonDelContact.UseVisualStyleBackColor = true;
            buttonDelContact.Click += buttonDelContact_Click;
            // 
            // buttonEditContact
            // 
            buttonEditContact.Location = new Point(635, 79);
            buttonEditContact.Name = "buttonEditContact";
            buttonEditContact.Size = new Size(96, 23);
            buttonEditContact.TabIndex = 11;
            buttonEditContact.Text = "Edit Contact";
            buttonEditContact.UseVisualStyleBackColor = true;
            buttonEditContact.Click += buttonEditContact_Click;
            // 
            // buttonAddContact
            // 
            buttonAddContact.Location = new Point(635, 50);
            buttonAddContact.Name = "buttonAddContact";
            buttonAddContact.Size = new Size(96, 23);
            buttonAddContact.TabIndex = 10;
            buttonAddContact.Text = "Add Contact";
            buttonAddContact.UseVisualStyleBackColor = true;
            buttonAddContact.Click += buttonAddContact_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(398, 50);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(292, 50);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(41, 15);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Phone";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(186, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Name";
            // 
            // labelForename
            // 
            labelForename.AutoSize = true;
            labelForename.Location = new Point(80, 50);
            labelForename.Name = "labelForename";
            labelForename.Size = new Size(60, 15);
            labelForename.TabIndex = 6;
            labelForename.Text = "Forename";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(33, 50);
            labelId.Name = "labelId";
            labelId.Size = new Size(18, 15);
            labelId.TabIndex = 5;
            labelId.Text = "ID";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(398, 68);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(292, 68);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(186, 68);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxForename
            // 
            textBoxForename.Location = new Point(80, 68);
            textBoxForename.Name = "textBoxForename";
            textBoxForename.Size = new Size(100, 23);
            textBoxForename.TabIndex = 1;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Location = new Point(33, 68);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(41, 23);
            textBoxId.TabIndex = 0;
            textBoxId.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 300);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "WinFormsKontakteNPoco";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxForename;
        private TextBox textBoxId;
        private DataGridView dataGridView1;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private Button buttonAddContact;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelName;
        private Label labelForename;
        private Label labelId;
        private TextBox textBoxEmail;
        private Button buttonEditContact;
        private Button buttonCloseApp;
        private Button buttonDelContact;
    }
}
