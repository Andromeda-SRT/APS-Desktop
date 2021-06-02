namespace APS_Desktop
{
    partial class DepartmentsInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsInfoForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TSBtn_Create = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Search = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Update = new System.Windows.Forms.ToolStripButton();
            this.listView_DepartmentsInfoForm = new System.Windows.Forms.ListView();
            this.department_uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView_DepartmentsInfoForm, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_Create,
            this.TSBtn_Edit,
            this.TSBtn_Delete,
            this.TSBtn_Search,
            this.TSBtn_Update});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.toolStrip.Size = new System.Drawing.Size(349, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // TSBtn_Create
            // 
            this.TSBtn_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Create.Image = global::APS_Desktop.Properties.Resources.add_emp;
            this.TSBtn_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Create.Name = "TSBtn_Create";
            this.TSBtn_Create.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Create.Text = "Создать отдел";
            this.TSBtn_Create.Click += new System.EventHandler(this.TSBtn_Create_Click);
            // 
            // TSBtn_Edit
            // 
            this.TSBtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Edit.Image = global::APS_Desktop.Properties.Resources.update_emp;
            this.TSBtn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Edit.Name = "TSBtn_Edit";
            this.TSBtn_Edit.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Edit.Text = "Редактировать отдел";
            this.TSBtn_Edit.Click += new System.EventHandler(this.TSBtn_Edit_Click);
            // 
            // TSBtn_Delete
            // 
            this.TSBtn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Delete.Image = global::APS_Desktop.Properties.Resources.trash;
            this.TSBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Delete.Name = "TSBtn_Delete";
            this.TSBtn_Delete.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Delete.Text = "Удалить отдел";
            this.TSBtn_Delete.Click += new System.EventHandler(this.TSBtn_Delete_Click);
            // 
            // TSBtn_Search
            // 
            this.TSBtn_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Search.Image = global::APS_Desktop.Properties.Resources.search;
            this.TSBtn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Search.Name = "TSBtn_Search";
            this.TSBtn_Search.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Search.Text = "Поиск";
            // 
            // TSBtn_Update
            // 
            this.TSBtn_Update.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtn_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Update.Image = global::APS_Desktop.Properties.Resources.refresh;
            this.TSBtn_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Update.Name = "TSBtn_Update";
            this.TSBtn_Update.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Update.Text = "Обновить";
            this.TSBtn_Update.Click += new System.EventHandler(this.TSBtn_Update_Click);
            // 
            // listView_DepartmentsInfoForm
            // 
            this.listView_DepartmentsInfoForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.department_uid,
            this.departmentName});
            this.listView_DepartmentsInfoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_DepartmentsInfoForm.FullRowSelect = true;
            this.listView_DepartmentsInfoForm.GridLines = true;
            this.listView_DepartmentsInfoForm.HideSelection = false;
            this.listView_DepartmentsInfoForm.Location = new System.Drawing.Point(3, 28);
            this.listView_DepartmentsInfoForm.Name = "listView_DepartmentsInfoForm";
            this.listView_DepartmentsInfoForm.Size = new System.Drawing.Size(343, 350);
            this.listView_DepartmentsInfoForm.TabIndex = 1;
            this.listView_DepartmentsInfoForm.UseCompatibleStateImageBehavior = false;
            this.listView_DepartmentsInfoForm.View = System.Windows.Forms.View.Details;
            this.listView_DepartmentsInfoForm.DoubleClick += new System.EventHandler(this.listView_DepartmentsInfoForm_DoubleClick);
            // 
            // department_uid
            // 
            this.department_uid.Text = "ID";
            // 
            // departmentName
            // 
            this.departmentName.Text = "Отдел";
            this.departmentName.Width = 277;
            // 
            // DepartmentsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(349, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 420);
            this.Name = "DepartmentsInfoForm";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.DepartmentsInfoForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TSBtn_Create;
        private System.Windows.Forms.ToolStripButton TSBtn_Edit;
        private System.Windows.Forms.ToolStripButton TSBtn_Delete;
        private System.Windows.Forms.ListView listView_DepartmentsInfoForm;
        private System.Windows.Forms.ColumnHeader department_uid;
        private System.Windows.Forms.ColumnHeader departmentName;
        private System.Windows.Forms.ToolStripButton TSBtn_Search;
        private System.Windows.Forms.ToolStripButton TSBtn_Update;
    }
}