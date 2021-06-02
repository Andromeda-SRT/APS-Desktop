namespace APS_Desktop
{
    partial class DepartmentEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_choise = new System.Windows.Forms.ComboBox();
            this.Btn_Edit_Position = new System.Windows.Forms.Button();
            this.Btn_Delete_Position = new System.Windows.Forms.Button();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.panel_position = new System.Windows.Forms.Panel();
            this.Btn_Add_Position = new System.Windows.Forms.Button();
            this.listView_Positions = new System.Windows.Forms.ListView();
            this.PositionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_cabinet = new System.Windows.Forms.Panel();
            this.Btn_Add_Cabinet = new System.Windows.Forms.Button();
            this.listView_Cabinets = new System.Windows.Forms.ListView();
            this.CabinetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Delete_Cabinet = new System.Windows.Forms.Button();
            this.Btn_Edit_Cabinet = new System.Windows.Forms.Button();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_position.SuspendLayout();
            this.panel_cabinet.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранный отдел:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_choise
            // 
            this.comboBox_choise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_choise.Enabled = false;
            this.comboBox_choise.FormattingEnabled = true;
            this.comboBox_choise.Location = new System.Drawing.Point(119, 11);
            this.comboBox_choise.Name = "comboBox_choise";
            this.comboBox_choise.Size = new System.Drawing.Size(299, 21);
            this.comboBox_choise.TabIndex = 1;
            // 
            // Btn_Edit_Position
            // 
            this.Btn_Edit_Position.Image = global::APS_Desktop.Properties.Resources.pencil_edit;
            this.Btn_Edit_Position.Location = new System.Drawing.Point(3, 3);
            this.Btn_Edit_Position.Name = "Btn_Edit_Position";
            this.Btn_Edit_Position.Size = new System.Drawing.Size(27, 27);
            this.Btn_Edit_Position.TabIndex = 2;
            this.Btn_Edit_Position.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Edit_Position.UseVisualStyleBackColor = true;
            this.Btn_Edit_Position.Click += new System.EventHandler(this.Btn_Edit_Position_Click);
            // 
            // Btn_Delete_Position
            // 
            this.Btn_Delete_Position.Image = global::APS_Desktop.Properties.Resources.trash;
            this.Btn_Delete_Position.Location = new System.Drawing.Point(36, 3);
            this.Btn_Delete_Position.Name = "Btn_Delete_Position";
            this.Btn_Delete_Position.Size = new System.Drawing.Size(27, 27);
            this.Btn_Delete_Position.TabIndex = 3;
            this.Btn_Delete_Position.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Delete_Position.UseVisualStyleBackColor = true;
            this.Btn_Delete_Position.Click += new System.EventHandler(this.Btn_Delete_Position_Click);
            // 
            // Btn_ok
            // 
            this.Btn_ok.Location = new System.Drawing.Point(342, 1);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_ok.TabIndex = 0;
            this.Btn_ok.Text = "Ок";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // panel_position
            // 
            this.panel_position.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_position.Controls.Add(this.Btn_Add_Position);
            this.panel_position.Controls.Add(this.listView_Positions);
            this.panel_position.Controls.Add(this.Btn_Delete_Position);
            this.panel_position.Controls.Add(this.Btn_Edit_Position);
            this.panel_position.Location = new System.Drawing.Point(12, 38);
            this.panel_position.Name = "panel_position";
            this.panel_position.Size = new System.Drawing.Size(200, 379);
            this.panel_position.TabIndex = 4;
            // 
            // Btn_Add_Position
            // 
            this.Btn_Add_Position.Image = global::APS_Desktop.Properties.Resources.plus;
            this.Btn_Add_Position.Location = new System.Drawing.Point(69, 3);
            this.Btn_Add_Position.Name = "Btn_Add_Position";
            this.Btn_Add_Position.Size = new System.Drawing.Size(27, 27);
            this.Btn_Add_Position.TabIndex = 5;
            this.Btn_Add_Position.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add_Position.UseVisualStyleBackColor = true;
            this.Btn_Add_Position.Click += new System.EventHandler(this.Btn_Add_Position_Click);
            // 
            // listView_Positions
            // 
            this.listView_Positions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PositionName});
            this.listView_Positions.FullRowSelect = true;
            this.listView_Positions.GridLines = true;
            this.listView_Positions.HideSelection = false;
            this.listView_Positions.Location = new System.Drawing.Point(4, 37);
            this.listView_Positions.Name = "listView_Positions";
            this.listView_Positions.Size = new System.Drawing.Size(191, 337);
            this.listView_Positions.TabIndex = 4;
            this.listView_Positions.UseCompatibleStateImageBehavior = false;
            this.listView_Positions.View = System.Windows.Forms.View.Details;
            this.listView_Positions.DoubleClick += new System.EventHandler(this.listView_Positions_DoubleClick);
            // 
            // PositionName
            // 
            this.PositionName.Text = "Должность(и)";
            this.PositionName.Width = 170;
            // 
            // panel_cabinet
            // 
            this.panel_cabinet.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_cabinet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cabinet.Controls.Add(this.Btn_Add_Cabinet);
            this.panel_cabinet.Controls.Add(this.listView_Cabinets);
            this.panel_cabinet.Controls.Add(this.Btn_Delete_Cabinet);
            this.panel_cabinet.Controls.Add(this.Btn_Edit_Cabinet);
            this.panel_cabinet.Location = new System.Drawing.Point(218, 38);
            this.panel_cabinet.Name = "panel_cabinet";
            this.panel_cabinet.Size = new System.Drawing.Size(200, 379);
            this.panel_cabinet.TabIndex = 5;
            // 
            // Btn_Add_Cabinet
            // 
            this.Btn_Add_Cabinet.Image = global::APS_Desktop.Properties.Resources.plus;
            this.Btn_Add_Cabinet.Location = new System.Drawing.Point(69, 3);
            this.Btn_Add_Cabinet.Name = "Btn_Add_Cabinet";
            this.Btn_Add_Cabinet.Size = new System.Drawing.Size(27, 27);
            this.Btn_Add_Cabinet.TabIndex = 6;
            this.Btn_Add_Cabinet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add_Cabinet.UseVisualStyleBackColor = true;
            this.Btn_Add_Cabinet.Click += new System.EventHandler(this.Btn_Add_Cabinet_Click);
            // 
            // listView_Cabinets
            // 
            this.listView_Cabinets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CabinetName});
            this.listView_Cabinets.FullRowSelect = true;
            this.listView_Cabinets.GridLines = true;
            this.listView_Cabinets.HideSelection = false;
            this.listView_Cabinets.Location = new System.Drawing.Point(4, 37);
            this.listView_Cabinets.Name = "listView_Cabinets";
            this.listView_Cabinets.Size = new System.Drawing.Size(191, 337);
            this.listView_Cabinets.TabIndex = 5;
            this.listView_Cabinets.UseCompatibleStateImageBehavior = false;
            this.listView_Cabinets.View = System.Windows.Forms.View.Details;
            this.listView_Cabinets.DoubleClick += new System.EventHandler(this.listView_Cabinets_DoubleClick);
            // 
            // CabinetName
            // 
            this.CabinetName.Text = "Кабинет(ы)";
            this.CabinetName.Width = 170;
            // 
            // Btn_Delete_Cabinet
            // 
            this.Btn_Delete_Cabinet.Image = global::APS_Desktop.Properties.Resources.trash;
            this.Btn_Delete_Cabinet.Location = new System.Drawing.Point(36, 3);
            this.Btn_Delete_Cabinet.Name = "Btn_Delete_Cabinet";
            this.Btn_Delete_Cabinet.Size = new System.Drawing.Size(27, 27);
            this.Btn_Delete_Cabinet.TabIndex = 4;
            this.Btn_Delete_Cabinet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Delete_Cabinet.UseVisualStyleBackColor = true;
            this.Btn_Delete_Cabinet.Click += new System.EventHandler(this.Btn_Delete_Cabinet_Click);
            // 
            // Btn_Edit_Cabinet
            // 
            this.Btn_Edit_Cabinet.Image = global::APS_Desktop.Properties.Resources.pencil_edit;
            this.Btn_Edit_Cabinet.Location = new System.Drawing.Point(3, 3);
            this.Btn_Edit_Cabinet.Name = "Btn_Edit_Cabinet";
            this.Btn_Edit_Cabinet.Size = new System.Drawing.Size(27, 27);
            this.Btn_Edit_Cabinet.TabIndex = 4;
            this.Btn_Edit_Cabinet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Edit_Cabinet.UseVisualStyleBackColor = true;
            this.Btn_Edit_Cabinet.Click += new System.EventHandler(this.Btn_Edit_Cabinet_Click);
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.SystemColors.Control;
            this.panel_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_footer.Controls.Add(this.Btn_ok);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 423);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(432, 27);
            this.panel_footer.TabIndex = 6;
            // 
            // DepartmentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_cabinet);
            this.Controls.Add(this.panel_position);
            this.Controls.Add(this.comboBox_choise);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DepartmentEditForm";
            this.Text = "Редактирование отдела";
            this.Load += new System.EventHandler(this.DepartmentEditForm_Load);
            this.panel_position.ResumeLayout(false);
            this.panel_cabinet.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_choise;
        private System.Windows.Forms.Button Btn_Edit_Position;
        private System.Windows.Forms.Button Btn_Delete_Position;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Panel panel_position;
        private System.Windows.Forms.ListView listView_Positions;
        private System.Windows.Forms.ColumnHeader PositionName;
        private System.Windows.Forms.Panel panel_cabinet;
        private System.Windows.Forms.ListView listView_Cabinets;
        private System.Windows.Forms.ColumnHeader CabinetName;
        private System.Windows.Forms.Button Btn_Delete_Cabinet;
        private System.Windows.Forms.Button Btn_Edit_Cabinet;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Button Btn_Add_Position;
        private System.Windows.Forms.Button Btn_Add_Cabinet;
    }
}