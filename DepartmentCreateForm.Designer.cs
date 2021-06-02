namespace APS_Desktop
{
    partial class DepartmentCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentCreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_inputData = new System.Windows.Forms.Panel();
            this.Btn_EditDpt = new System.Windows.Forms.Button();
            this.Btn_OkDpt = new System.Windows.Forms.Button();
            this.Btn_addCabinet = new System.Windows.Forms.Button();
            this.Btn_addPosition = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_ClearThisPosition = new System.Windows.Forms.Button();
            this.panel_display = new System.Windows.Forms.Panel();
            this.Btn_ClearThisCabinet = new System.Windows.Forms.Button();
            this.panel_cabinet = new System.Windows.Forms.Panel();
            this.listView_cabinet = new System.Windows.Forms.ListView();
            this.cabinetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.panel_position = new System.Windows.Forms.Panel();
            this.listView_position = new System.Windows.Forms.ListView();
            this.positionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_dptName = new System.Windows.Forms.Label();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.panel_inputData.SuspendLayout();
            this.panel_display.SuspendLayout();
            this.panel_cabinet.SuspendLayout();
            this.panel_position.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название создаваемого отдела:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кабинет:";
            // 
            // panel_inputData
            // 
            this.panel_inputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inputData.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_inputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_inputData.Controls.Add(this.Btn_EditDpt);
            this.panel_inputData.Controls.Add(this.Btn_OkDpt);
            this.panel_inputData.Controls.Add(this.Btn_addCabinet);
            this.panel_inputData.Controls.Add(this.Btn_addPosition);
            this.panel_inputData.Controls.Add(this.textBox3);
            this.panel_inputData.Controls.Add(this.label1);
            this.panel_inputData.Controls.Add(this.textBox2);
            this.panel_inputData.Controls.Add(this.label2);
            this.panel_inputData.Controls.Add(this.textBox1);
            this.panel_inputData.Controls.Add(this.label3);
            this.panel_inputData.Location = new System.Drawing.Point(12, 12);
            this.panel_inputData.Name = "panel_inputData";
            this.panel_inputData.Size = new System.Drawing.Size(426, 111);
            this.panel_inputData.TabIndex = 3;
            // 
            // Btn_EditDpt
            // 
            this.Btn_EditDpt.Image = global::APS_Desktop.Properties.Resources.pencil_edit;
            this.Btn_EditDpt.Location = new System.Drawing.Point(396, 12);
            this.Btn_EditDpt.Name = "Btn_EditDpt";
            this.Btn_EditDpt.Size = new System.Drawing.Size(24, 24);
            this.Btn_EditDpt.TabIndex = 19;
            this.Btn_EditDpt.UseVisualStyleBackColor = true;
            this.Btn_EditDpt.Click += new System.EventHandler(this.Btn_EditDpt_Click);
            // 
            // Btn_OkDpt
            // 
            this.Btn_OkDpt.Image = global::APS_Desktop.Properties.Resources.check;
            this.Btn_OkDpt.Location = new System.Drawing.Point(372, 12);
            this.Btn_OkDpt.Name = "Btn_OkDpt";
            this.Btn_OkDpt.Size = new System.Drawing.Size(24, 24);
            this.Btn_OkDpt.TabIndex = 18;
            this.Btn_OkDpt.UseVisualStyleBackColor = true;
            this.Btn_OkDpt.Click += new System.EventHandler(this.Btn_OkDpt_Click);
            // 
            // Btn_addCabinet
            // 
            this.Btn_addCabinet.AutoSize = true;
            this.Btn_addCabinet.Image = global::APS_Desktop.Properties.Resources.right_arrow_add;
            this.Btn_addCabinet.Location = new System.Drawing.Point(372, 76);
            this.Btn_addCabinet.Name = "Btn_addCabinet";
            this.Btn_addCabinet.Size = new System.Drawing.Size(47, 23);
            this.Btn_addCabinet.TabIndex = 17;
            this.Btn_addCabinet.UseVisualStyleBackColor = true;
            this.Btn_addCabinet.Click += new System.EventHandler(this.Btn_addCabinet_Click);
            // 
            // Btn_addPosition
            // 
            this.Btn_addPosition.AutoSize = true;
            this.Btn_addPosition.Image = global::APS_Desktop.Properties.Resources.right_arrow_add;
            this.Btn_addPosition.Location = new System.Drawing.Point(372, 45);
            this.Btn_addPosition.Name = "Btn_addPosition";
            this.Btn_addPosition.Size = new System.Drawing.Size(47, 23);
            this.Btn_addPosition.TabIndex = 16;
            this.Btn_addPosition.UseVisualStyleBackColor = true;
            this.Btn_addPosition.Click += new System.EventHandler(this.Btn_addPosition_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Btn_ClearThisPosition
            // 
            this.Btn_ClearThisPosition.Image = global::APS_Desktop.Properties.Resources.trash;
            this.Btn_ClearThisPosition.Location = new System.Drawing.Point(90, 289);
            this.Btn_ClearThisPosition.Name = "Btn_ClearThisPosition";
            this.Btn_ClearThisPosition.Size = new System.Drawing.Size(27, 27);
            this.Btn_ClearThisPosition.TabIndex = 9;
            this.Btn_ClearThisPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ClearThisPosition.UseVisualStyleBackColor = true;
            this.Btn_ClearThisPosition.Click += new System.EventHandler(this.Btn_ClearThisPosition_Click);
            // 
            // panel_display
            // 
            this.panel_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_display.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_display.Controls.Add(this.Btn_ClearThisCabinet);
            this.panel_display.Controls.Add(this.Btn_ClearThisPosition);
            this.panel_display.Controls.Add(this.panel_cabinet);
            this.panel_display.Controls.Add(this.label4);
            this.panel_display.Controls.Add(this.panel_position);
            this.panel_display.Controls.Add(this.label_dptName);
            this.panel_display.Location = new System.Drawing.Point(12, 129);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(426, 321);
            this.panel_display.TabIndex = 4;
            // 
            // Btn_ClearThisCabinet
            // 
            this.Btn_ClearThisCabinet.Image = global::APS_Desktop.Properties.Resources.trash;
            this.Btn_ClearThisCabinet.Location = new System.Drawing.Point(310, 289);
            this.Btn_ClearThisCabinet.Name = "Btn_ClearThisCabinet";
            this.Btn_ClearThisCabinet.Size = new System.Drawing.Size(27, 27);
            this.Btn_ClearThisCabinet.TabIndex = 20;
            this.Btn_ClearThisCabinet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ClearThisCabinet.UseVisualStyleBackColor = true;
            this.Btn_ClearThisCabinet.Click += new System.EventHandler(this.Btn_ClearThisCabinet_Click);
            // 
            // panel_cabinet
            // 
            this.panel_cabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cabinet.Controls.Add(this.listView_cabinet);
            this.panel_cabinet.Location = new System.Drawing.Point(221, 26);
            this.panel_cabinet.Name = "panel_cabinet";
            this.panel_cabinet.Size = new System.Drawing.Size(199, 259);
            this.panel_cabinet.TabIndex = 12;
            // 
            // listView_cabinet
            // 
            this.listView_cabinet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cabinetName});
            this.listView_cabinet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_cabinet.FullRowSelect = true;
            this.listView_cabinet.GridLines = true;
            this.listView_cabinet.HideSelection = false;
            this.listView_cabinet.Location = new System.Drawing.Point(0, 0);
            this.listView_cabinet.Name = "listView_cabinet";
            this.listView_cabinet.Size = new System.Drawing.Size(199, 259);
            this.listView_cabinet.TabIndex = 0;
            this.listView_cabinet.UseCompatibleStateImageBehavior = false;
            this.listView_cabinet.View = System.Windows.Forms.View.Details;
            // 
            // cabinetName
            // 
            this.cabinetName.Text = "Кабинет";
            this.cabinetName.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название отдела: ";
            // 
            // panel_position
            // 
            this.panel_position.Controls.Add(this.listView_position);
            this.panel_position.Location = new System.Drawing.Point(6, 26);
            this.panel_position.Name = "panel_position";
            this.panel_position.Size = new System.Drawing.Size(199, 259);
            this.panel_position.TabIndex = 11;
            // 
            // listView_position
            // 
            this.listView_position.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.positionName});
            this.listView_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_position.FullRowSelect = true;
            this.listView_position.GridLines = true;
            this.listView_position.HideSelection = false;
            this.listView_position.Location = new System.Drawing.Point(0, 0);
            this.listView_position.Name = "listView_position";
            this.listView_position.Size = new System.Drawing.Size(199, 259);
            this.listView_position.TabIndex = 0;
            this.listView_position.UseCompatibleStateImageBehavior = false;
            this.listView_position.View = System.Windows.Forms.View.Details;
            // 
            // positionName
            // 
            this.positionName.Text = "Должность";
            this.positionName.Width = 180;
            // 
            // label_dptName
            // 
            this.label_dptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dptName.Location = new System.Drawing.Point(100, 6);
            this.label_dptName.Name = "label_dptName";
            this.label_dptName.Size = new System.Drawing.Size(315, 13);
            this.label_dptName.TabIndex = 10;
            this.label_dptName.Text = "DepartmentName";
            // 
            // Btn_Create
            // 
            this.Btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Create.Location = new System.Drawing.Point(288, 1);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(72, 23);
            this.Btn_Create.TabIndex = 5;
            this.Btn_Create.Text = "Создать";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(364, 2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 21);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Отмена";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // panel_controls
            // 
            this.panel_controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_controls.Controls.Add(this.Btn_Cancel);
            this.panel_controls.Controls.Add(this.Btn_Create);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controls.Location = new System.Drawing.Point(0, 456);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(452, 27);
            this.panel_controls.TabIndex = 8;
            // 
            // DepartmentCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(452, 483);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel_inputData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentCreateForm";
            this.Text = "Создание отдела";
            this.Load += new System.EventHandler(this.DepartmentCreateForm_Load);
            this.panel_inputData.ResumeLayout(false);
            this.panel_inputData.PerformLayout();
            this.panel_display.ResumeLayout(false);
            this.panel_display.PerformLayout();
            this.panel_cabinet.ResumeLayout(false);
            this.panel_position.ResumeLayout(false);
            this.panel_controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_inputData;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Panel panel_cabinet;
        private System.Windows.Forms.ListView listView_cabinet;
        private System.Windows.Forms.ColumnHeader cabinetName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_position;
        private System.Windows.Forms.ListView listView_position;
        private System.Windows.Forms.ColumnHeader positionName;
        private System.Windows.Forms.Label label_dptName;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Button Btn_addPosition;
        private System.Windows.Forms.Button Btn_addCabinet;
        private System.Windows.Forms.Button Btn_OkDpt;
        private System.Windows.Forms.Button Btn_EditDpt;
        private System.Windows.Forms.Button Btn_ClearThisPosition;
        private System.Windows.Forms.Button Btn_ClearThisCabinet;
    }
}