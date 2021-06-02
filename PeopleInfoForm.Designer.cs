namespace APS_Desktop
{
    partial class PeopleInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleInfoForm));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_sphone = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tB_middleName = new System.Windows.Forms.TextBox();
            this.tB_lastName = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_gcode = new System.Windows.Forms.Label();
            this.edit_i_emp = new System.Windows.Forms.Button();
            this.delete_emp = new System.Windows.Forms.Button();
            this.apply_changes = new System.Windows.Forms.Button();
            this.cancel_changes = new System.Windows.Forms.Button();
            this.panel_standart = new System.Windows.Forms.Panel();
            this.panel_changing = new System.Windows.Forms.Panel();
            this.label_uid_emp = new System.Windows.Forms.Label();
            this.lb_uid_emp = new System.Windows.Forms.Label();
            this.cB_department = new System.Windows.Forms.ComboBox();
            this.cB_position = new System.Windows.Forms.ComboBox();
            this.cB_cabinet = new System.Windows.Forms.ComboBox();
            this.panel_comboBoxes = new System.Windows.Forms.Panel();
            this.changePhoto = new System.Windows.Forms.Button();
            this.tB_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_standart.SuspendLayout();
            this.panel_changing.SuspendLayout();
            this.panel_comboBoxes.SuspendLayout();
            this.tB_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(271, 451);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Нет кабинета";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Кабинет";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Должность";
            // 
            // tB_sphone
            // 
            this.tB_sphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_sphone.Location = new System.Drawing.Point(0, 136);
            this.tB_sphone.Name = "tB_sphone";
            this.tB_sphone.Size = new System.Drawing.Size(209, 20);
            this.tB_sphone.TabIndex = 47;
            this.tB_sphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_phone_KeyPress);
            // 
            // tB_phone
            // 
            this.tB_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_phone.Location = new System.Drawing.Point(0, 110);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(209, 20);
            this.tB_phone.TabIndex = 46;
            this.tB_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_phone_KeyPress);
            // 
            // tB_middleName
            // 
            this.tB_middleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_middleName.Location = new System.Drawing.Point(0, 55);
            this.tB_middleName.Name = "tB_middleName";
            this.tB_middleName.Size = new System.Drawing.Size(209, 20);
            this.tB_middleName.TabIndex = 42;
            // 
            // tB_lastName
            // 
            this.tB_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_lastName.Location = new System.Drawing.Point(0, 29);
            this.tB_lastName.Name = "tB_lastName";
            this.tB_lastName.Size = new System.Drawing.Size(209, 20);
            this.tB_lastName.TabIndex = 41;
            // 
            // tB_name
            // 
            this.tB_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_name.Location = new System.Drawing.Point(0, 3);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(209, 20);
            this.tB_name.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Отдел";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Доп. телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Имя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 138);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Фотография сотрудника";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Код безопасности:";
            // 
            // lb_gcode
            // 
            this.lb_gcode.AutoSize = true;
            this.lb_gcode.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_gcode.Location = new System.Drawing.Point(128, 479);
            this.lb_gcode.Name = "lb_gcode";
            this.lb_gcode.Size = new System.Drawing.Size(49, 13);
            this.lb_gcode.TabIndex = 57;
            this.lb_gcode.Text = "1234567";
            // 
            // edit_i_emp
            // 
            this.edit_i_emp.Image = global::APS_Desktop.Properties.Resources.update_emp;
            this.edit_i_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_i_emp.Location = new System.Drawing.Point(114, 2);
            this.edit_i_emp.Name = "edit_i_emp";
            this.edit_i_emp.Size = new System.Drawing.Size(110, 27);
            this.edit_i_emp.TabIndex = 58;
            this.edit_i_emp.Text = "Редактировать";
            this.edit_i_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit_i_emp.UseVisualStyleBackColor = true;
            this.edit_i_emp.Click += new System.EventHandler(this.edit_i_emp_Click);
            // 
            // delete_emp
            // 
            this.delete_emp.Image = global::APS_Desktop.Properties.Resources.trash;
            this.delete_emp.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.delete_emp.Location = new System.Drawing.Point(230, 2);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(136, 27);
            this.delete_emp.TabIndex = 59;
            this.delete_emp.Text = "Удалить сотрудника";
            this.delete_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delete_emp.UseVisualStyleBackColor = true;
            this.delete_emp.Click += new System.EventHandler(this.delete_emp_Click);
            // 
            // apply_changes
            // 
            this.apply_changes.Dock = System.Windows.Forms.DockStyle.Left;
            this.apply_changes.Image = global::APS_Desktop.Properties.Resources.apply;
            this.apply_changes.Location = new System.Drawing.Point(0, 0);
            this.apply_changes.Name = "apply_changes";
            this.apply_changes.Size = new System.Drawing.Size(92, 27);
            this.apply_changes.TabIndex = 60;
            this.apply_changes.Text = "Применить";
            this.apply_changes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.apply_changes.UseVisualStyleBackColor = true;
            this.apply_changes.Click += new System.EventHandler(this.apply_changes_Click);
            // 
            // cancel_changes
            // 
            this.cancel_changes.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_changes.Image = global::APS_Desktop.Properties.Resources.cancel;
            this.cancel_changes.Location = new System.Drawing.Point(95, 0);
            this.cancel_changes.Name = "cancel_changes";
            this.cancel_changes.Size = new System.Drawing.Size(85, 27);
            this.cancel_changes.TabIndex = 61;
            this.cancel_changes.Text = "Отмена";
            this.cancel_changes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_changes.UseVisualStyleBackColor = true;
            this.cancel_changes.Click += new System.EventHandler(this.cancel_changes_Click);
            // 
            // panel_standart
            // 
            this.panel_standart.BackColor = System.Drawing.SystemColors.Control;
            this.panel_standart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_standart.Controls.Add(this.edit_i_emp);
            this.panel_standart.Controls.Add(this.delete_emp);
            this.panel_standart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_standart.Location = new System.Drawing.Point(0, 516);
            this.panel_standart.Name = "panel_standart";
            this.panel_standart.Size = new System.Drawing.Size(396, 32);
            this.panel_standart.TabIndex = 62;
            // 
            // panel_changing
            // 
            this.panel_changing.Controls.Add(this.apply_changes);
            this.panel_changing.Controls.Add(this.cancel_changes);
            this.panel_changing.Location = new System.Drawing.Point(183, 471);
            this.panel_changing.Name = "panel_changing";
            this.panel_changing.Size = new System.Drawing.Size(180, 27);
            this.panel_changing.TabIndex = 63;
            this.panel_changing.Visible = false;
            // 
            // label_uid_emp
            // 
            this.label_uid_emp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_uid_emp.Location = new System.Drawing.Point(12, 9);
            this.label_uid_emp.Margin = new System.Windows.Forms.Padding(0);
            this.label_uid_emp.Name = "label_uid_emp";
            this.label_uid_emp.Size = new System.Drawing.Size(19, 16);
            this.label_uid_emp.TabIndex = 64;
            this.label_uid_emp.Text = "ID: ";
            // 
            // lb_uid_emp
            // 
            this.lb_uid_emp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_uid_emp.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_uid_emp.Location = new System.Drawing.Point(40, 9);
            this.lb_uid_emp.Name = "lb_uid_emp";
            this.lb_uid_emp.Size = new System.Drawing.Size(60, 16);
            this.lb_uid_emp.TabIndex = 65;
            this.lb_uid_emp.Text = "101";
            // 
            // cB_department
            // 
            this.cB_department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_department.FormattingEnabled = true;
            this.cB_department.Location = new System.Drawing.Point(0, 3);
            this.cB_department.Name = "cB_department";
            this.cB_department.Size = new System.Drawing.Size(209, 21);
            this.cB_department.TabIndex = 66;
            this.cB_department.SelectionChangeCommitted += new System.EventHandler(this.cB_department_SelectionChangeCommitted);
            // 
            // cB_position
            // 
            this.cB_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_position.FormattingEnabled = true;
            this.cB_position.Location = new System.Drawing.Point(0, 29);
            this.cB_position.Name = "cB_position";
            this.cB_position.Size = new System.Drawing.Size(209, 21);
            this.cB_position.TabIndex = 67;
            // 
            // cB_cabinet
            // 
            this.cB_cabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_cabinet.FormattingEnabled = true;
            this.cB_cabinet.Location = new System.Drawing.Point(0, 55);
            this.cB_cabinet.Name = "cB_cabinet";
            this.cB_cabinet.Size = new System.Drawing.Size(209, 21);
            this.cB_cabinet.TabIndex = 68;
            // 
            // panel_comboBoxes
            // 
            this.panel_comboBoxes.Controls.Add(this.cB_department);
            this.panel_comboBoxes.Controls.Add(this.cB_cabinet);
            this.panel_comboBoxes.Controls.Add(this.cB_position);
            this.panel_comboBoxes.Enabled = false;
            this.panel_comboBoxes.Location = new System.Drawing.Point(158, 368);
            this.panel_comboBoxes.Name = "panel_comboBoxes";
            this.panel_comboBoxes.Size = new System.Drawing.Size(209, 79);
            this.panel_comboBoxes.TabIndex = 69;
            // 
            // changePhoto
            // 
            this.changePhoto.Location = new System.Drawing.Point(22, 66);
            this.changePhoto.Name = "changePhoto";
            this.changePhoto.Size = new System.Drawing.Size(130, 34);
            this.changePhoto.TabIndex = 70;
            this.changePhoto.Text = "Изменить фотографию";
            this.changePhoto.UseVisualStyleBackColor = true;
            this.changePhoto.Visible = false;
            // 
            // tB_panel
            // 
            this.tB_panel.Controls.Add(this.tB_sphone);
            this.tB_panel.Controls.Add(this.tB_name);
            this.tB_panel.Controls.Add(this.tB_phone);
            this.tB_panel.Controls.Add(this.tB_lastName);
            this.tB_panel.Controls.Add(this.tB_middleName);
            this.tB_panel.Enabled = false;
            this.tB_panel.Location = new System.Drawing.Point(158, 185);
            this.tB_panel.Name = "tB_panel";
            this.tB_panel.Size = new System.Drawing.Size(209, 165);
            this.tB_panel.TabIndex = 71;
            // 
            // PeopleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(396, 548);
            this.Controls.Add(this.tB_panel);
            this.Controls.Add(this.changePhoto);
            this.Controls.Add(this.panel_comboBoxes);
            this.Controls.Add(this.lb_uid_emp);
            this.Controls.Add(this.label_uid_emp);
            this.Controls.Add(this.panel_changing);
            this.Controls.Add(this.panel_standart);
            this.Controls.Add(this.lb_gcode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeopleInfoForm";
            this.Text = "Информация о сотруднике";
            this.Load += new System.EventHandler(this.PeopleInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_standart.ResumeLayout(false);
            this.panel_changing.ResumeLayout(false);
            this.panel_comboBoxes.ResumeLayout(false);
            this.tB_panel.ResumeLayout(false);
            this.tB_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tB_sphone;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tB_middleName;
        private System.Windows.Forms.TextBox tB_lastName;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_gcode;
        private System.Windows.Forms.Button edit_i_emp;
        private System.Windows.Forms.Button delete_emp;
        private System.Windows.Forms.Button apply_changes;
        private System.Windows.Forms.Button cancel_changes;
        private System.Windows.Forms.Panel panel_standart;
        private System.Windows.Forms.Panel panel_changing;
        private System.Windows.Forms.Label label_uid_emp;
        private System.Windows.Forms.Label lb_uid_emp;
        private System.Windows.Forms.ComboBox cB_department;
        private System.Windows.Forms.ComboBox cB_position;
        private System.Windows.Forms.ComboBox cB_cabinet;
        private System.Windows.Forms.Panel panel_comboBoxes;
        private System.Windows.Forms.Button changePhoto;
        private System.Windows.Forms.Panel tB_panel;
    }
}