namespace APS_Desktop
{
    partial class AddEmployeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.lb_middleName = new System.Windows.Forms.Label();
            this.lb_phoneNumber = new System.Windows.Forms.Label();
            this.lb_subPhoneNumber = new System.Windows.Forms.Label();
            this.tB_firstName = new System.Windows.Forms.TextBox();
            this.tB_lastName = new System.Windows.Forms.TextBox();
            this.tB_middleName = new System.Windows.Forms.TextBox();
            this.tB_phoneNumber = new System.Windows.Forms.TextBox();
            this.tB_subPhoneNumber = new System.Windows.Forms.TextBox();
            this.lb_position = new System.Windows.Forms.Label();
            this.lb_cabinet = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancellation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_loadActualVersion = new System.Windows.Forms.Button();
            this.lb_department = new System.Windows.Forms.Label();
            this.cB_department = new System.Windows.Forms.ComboBox();
            this.cB_cabinet = new System.Windows.Forms.ComboBox();
            this.cB_position = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Location = new System.Drawing.Point(17, 160);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(36, 13);
            this.lb_firstName.TabIndex = 2;
            this.lb_firstName.Text = "Имя *";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Location = new System.Drawing.Point(17, 186);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(63, 13);
            this.lb_lastName.TabIndex = 3;
            this.lb_lastName.Text = "Фамилия *";
            // 
            // lb_middleName
            // 
            this.lb_middleName.AutoSize = true;
            this.lb_middleName.Location = new System.Drawing.Point(17, 212);
            this.lb_middleName.Name = "lb_middleName";
            this.lb_middleName.Size = new System.Drawing.Size(57, 13);
            this.lb_middleName.TabIndex = 4;
            this.lb_middleName.Text = "Отчество ";
            // 
            // lb_phoneNumber
            // 
            this.lb_phoneNumber.AutoSize = true;
            this.lb_phoneNumber.Location = new System.Drawing.Point(17, 256);
            this.lb_phoneNumber.Name = "lb_phoneNumber";
            this.lb_phoneNumber.Size = new System.Drawing.Size(59, 13);
            this.lb_phoneNumber.TabIndex = 8;
            this.lb_phoneNumber.Text = "Телефон *";
            // 
            // lb_subPhoneNumber
            // 
            this.lb_subPhoneNumber.AutoSize = true;
            this.lb_subPhoneNumber.Location = new System.Drawing.Point(17, 282);
            this.lb_subPhoneNumber.Name = "lb_subPhoneNumber";
            this.lb_subPhoneNumber.Size = new System.Drawing.Size(77, 13);
            this.lb_subPhoneNumber.TabIndex = 9;
            this.lb_subPhoneNumber.Text = "Доп. телефон";
            // 
            // tB_firstName
            // 
            this.tB_firstName.Location = new System.Drawing.Point(113, 157);
            this.tB_firstName.Name = "tB_firstName";
            this.tB_firstName.Size = new System.Drawing.Size(208, 20);
            this.tB_firstName.TabIndex = 12;
            // 
            // tB_lastName
            // 
            this.tB_lastName.Location = new System.Drawing.Point(113, 183);
            this.tB_lastName.Name = "tB_lastName";
            this.tB_lastName.Size = new System.Drawing.Size(208, 20);
            this.tB_lastName.TabIndex = 13;
            // 
            // tB_middleName
            // 
            this.tB_middleName.Location = new System.Drawing.Point(113, 209);
            this.tB_middleName.Name = "tB_middleName";
            this.tB_middleName.Size = new System.Drawing.Size(208, 20);
            this.tB_middleName.TabIndex = 14;
            // 
            // tB_phoneNumber
            // 
            this.tB_phoneNumber.Location = new System.Drawing.Point(113, 253);
            this.tB_phoneNumber.MaxLength = 11;
            this.tB_phoneNumber.Name = "tB_phoneNumber";
            this.tB_phoneNumber.Size = new System.Drawing.Size(208, 20);
            this.tB_phoneNumber.TabIndex = 18;
            this.tB_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_phoneNumber_KeyPress);
            // 
            // tB_subPhoneNumber
            // 
            this.tB_subPhoneNumber.Location = new System.Drawing.Point(113, 279);
            this.tB_subPhoneNumber.MaxLength = 11;
            this.tB_subPhoneNumber.Name = "tB_subPhoneNumber";
            this.tB_subPhoneNumber.Size = new System.Drawing.Size(208, 20);
            this.tB_subPhoneNumber.TabIndex = 19;
            this.tB_subPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_subPhoneNumber_KeyPress);
            // 
            // lb_position
            // 
            this.lb_position.AutoSize = true;
            this.lb_position.Location = new System.Drawing.Point(17, 350);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(72, 13);
            this.lb_position.TabIndex = 24;
            this.lb_position.Text = "Должность *";
            // 
            // lb_cabinet
            // 
            this.lb_cabinet.AutoSize = true;
            this.lb_cabinet.Location = new System.Drawing.Point(17, 376);
            this.lb_cabinet.Name = "lb_cabinet";
            this.lb_cabinet.Size = new System.Drawing.Size(49, 13);
            this.lb_cabinet.TabIndex = 25;
            this.lb_cabinet.Text = "Кабинет";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(187, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 26;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancellation
            // 
            this.Cancellation.Location = new System.Drawing.Point(268, 3);
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.Size = new System.Drawing.Size(75, 23);
            this.Cancellation.TabIndex = 28;
            this.Cancellation.Text = "Отмена";
            this.Cancellation.UseVisualStyleBackColor = true;
            this.Cancellation.Click += new System.EventHandler(this.Cancellation_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Выбрать фотографию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_loadActualVersion);
            this.panel1.Controls.Add(this.Cancellation);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 32);
            this.panel1.TabIndex = 30;
            // 
            // Btn_loadActualVersion
            // 
            this.Btn_loadActualVersion.Image = global::APS_Desktop.Properties.Resources.refresh;
            this.Btn_loadActualVersion.Location = new System.Drawing.Point(11, 1);
            this.Btn_loadActualVersion.Name = "Btn_loadActualVersion";
            this.Btn_loadActualVersion.Size = new System.Drawing.Size(27, 27);
            this.Btn_loadActualVersion.TabIndex = 56;
            this.Btn_loadActualVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loadActualVersion.UseVisualStyleBackColor = true;
            this.Btn_loadActualVersion.Click += new System.EventHandler(this.Btn_loadActualVersion_Click);
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.Location = new System.Drawing.Point(17, 324);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(45, 13);
            this.lb_department.TabIndex = 32;
            this.lb_department.Text = "Отдел *";
            // 
            // cB_department
            // 
            this.cB_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_department.FormattingEnabled = true;
            this.cB_department.Location = new System.Drawing.Point(113, 321);
            this.cB_department.MaxDropDownItems = 4;
            this.cB_department.Name = "cB_department";
            this.cB_department.Size = new System.Drawing.Size(208, 21);
            this.cB_department.TabIndex = 33;
            this.cB_department.SelectionChangeCommitted += new System.EventHandler(this.cB_department_SelectionChangeCommitted);
            // 
            // cB_cabinet
            // 
            this.cB_cabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_cabinet.Enabled = false;
            this.cB_cabinet.FormattingEnabled = true;
            this.cB_cabinet.Location = new System.Drawing.Point(113, 372);
            this.cB_cabinet.MaxDropDownItems = 4;
            this.cB_cabinet.Name = "cB_cabinet";
            this.cB_cabinet.Size = new System.Drawing.Size(208, 21);
            this.cB_cabinet.TabIndex = 34;
            // 
            // cB_position
            // 
            this.cB_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_position.Enabled = false;
            this.cB_position.FormattingEnabled = true;
            this.cB_position.Location = new System.Drawing.Point(113, 347);
            this.cB_position.MaxDropDownItems = 4;
            this.cB_position.Name = "cB_position";
            this.cB_position.Size = new System.Drawing.Size(208, 21);
            this.cB_position.TabIndex = 35;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(226, 402);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(95, 17);
            this.checkBox.TabIndex = 55;
            this.checkBox.Text = "Нет кабинета";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // AddEmployeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(355, 455);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.cB_position);
            this.Controls.Add(this.cB_cabinet);
            this.Controls.Add(this.cB_department);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_cabinet);
            this.Controls.Add(this.lb_position);
            this.Controls.Add(this.tB_subPhoneNumber);
            this.Controls.Add(this.tB_phoneNumber);
            this.Controls.Add(this.tB_middleName);
            this.Controls.Add(this.tB_lastName);
            this.Controls.Add(this.tB_firstName);
            this.Controls.Add(this.lb_subPhoneNumber);
            this.Controls.Add(this.lb_phoneNumber);
            this.Controls.Add(this.lb_middleName);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEmployeForm";
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.AddEmployeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_firstName;
        private System.Windows.Forms.Label lb_lastName;
        private System.Windows.Forms.Label lb_middleName;
        private System.Windows.Forms.Label lb_phoneNumber;
        private System.Windows.Forms.Label lb_subPhoneNumber;
        private System.Windows.Forms.TextBox tB_firstName;
        private System.Windows.Forms.TextBox tB_lastName;
        private System.Windows.Forms.TextBox tB_middleName;
        private System.Windows.Forms.TextBox tB_phoneNumber;
        private System.Windows.Forms.TextBox tB_subPhoneNumber;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Label lb_cabinet;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancellation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.ComboBox cB_department;
        private System.Windows.Forms.ComboBox cB_cabinet;
        private System.Windows.Forms.ComboBox cB_position;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button Btn_loadActualVersion;
    }
}