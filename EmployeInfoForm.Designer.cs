namespace APS_Desktop
{
    partial class EmployeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeInfoForm));
            this.listView_EmployeInfo = new System.Windows.Forms.ListView();
            this.lb_uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_secondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_middleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_firstPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_secondPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_departmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_post = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_cabinet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TSBtn_add = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_editEmployeData = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_delete = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_search = new System.Windows.Forms.ToolStripButton();
            this.TSLbl_indicator = new System.Windows.Forms.ToolStripLabel();
            this.TSBtn_update_table = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_EmployeInfo
            // 
            this.listView_EmployeInfo.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView_EmployeInfo.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_EmployeInfo.BackColor = System.Drawing.Color.MintCream;
            this.listView_EmployeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_EmployeInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lb_uid,
            this.lb_firstName,
            this.lb_secondName,
            this.lb_middleName,
            this.lb_firstPhone,
            this.lb_secondPhone,
            this.lb_departmentName,
            this.lb_post,
            this.lb_cabinet});
            this.listView_EmployeInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView_EmployeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_EmployeInfo.FullRowSelect = true;
            this.listView_EmployeInfo.GridLines = true;
            this.listView_EmployeInfo.HideSelection = false;
            this.listView_EmployeInfo.Location = new System.Drawing.Point(3, 28);
            this.listView_EmployeInfo.MultiSelect = false;
            this.listView_EmployeInfo.Name = "listView_EmployeInfo";
            this.listView_EmployeInfo.Size = new System.Drawing.Size(742, 253);
            this.listView_EmployeInfo.TabIndex = 1;
            this.listView_EmployeInfo.UseCompatibleStateImageBehavior = false;
            this.listView_EmployeInfo.View = System.Windows.Forms.View.Details;
            this.listView_EmployeInfo.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView_EmployeInfo_ItemMouseHover);
            this.listView_EmployeInfo.DoubleClick += new System.EventHandler(this.listView_EmployeInfo_DoubleClick);
            // 
            // lb_uid
            // 
            this.lb_uid.Text = "UID";
            this.lb_uid.Width = 35;
            // 
            // lb_firstName
            // 
            this.lb_firstName.Text = "Фамилия";
            this.lb_firstName.Width = 120;
            // 
            // lb_secondName
            // 
            this.lb_secondName.Text = "Имя";
            // 
            // lb_middleName
            // 
            this.lb_middleName.Text = "Отчество";
            this.lb_middleName.Width = 120;
            // 
            // lb_firstPhone
            // 
            this.lb_firstPhone.Text = "Телефон";
            this.lb_firstPhone.Width = 70;
            // 
            // lb_secondPhone
            // 
            this.lb_secondPhone.Text = "Доп. телефон";
            // 
            // lb_departmentName
            // 
            this.lb_departmentName.Text = "Отдел";
            this.lb_departmentName.Width = 150;
            // 
            // lb_post
            // 
            this.lb_post.Text = "Должность";
            // 
            // lb_cabinet
            // 
            this.lb_cabinet.Text = "Кабинет";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.listView_EmployeInfo, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.toolStrip, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(748, 284);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.MintCream;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_add,
            this.TSBtn_editEmployeData,
            this.TSBtn_delete,
            this.TSBtn_search,
            this.TSLbl_indicator,
            this.TSBtn_update_table});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.toolStrip.Size = new System.Drawing.Size(748, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "Панель инструментов";
            // 
            // TSBtn_add
            // 
            this.TSBtn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_add.Image = global::APS_Desktop.Properties.Resources.add_emp;
            this.TSBtn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_add.Name = "TSBtn_add";
            this.TSBtn_add.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_add.Text = "Добавить сотрудника";
            this.TSBtn_add.Click += new System.EventHandler(this.TSBtn_add_Click);
            // 
            // TSBtn_editEmployeData
            // 
            this.TSBtn_editEmployeData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_editEmployeData.Image = global::APS_Desktop.Properties.Resources.update_emp;
            this.TSBtn_editEmployeData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_editEmployeData.Name = "TSBtn_editEmployeData";
            this.TSBtn_editEmployeData.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_editEmployeData.Text = "Редактировать данные сотрудника";
            this.TSBtn_editEmployeData.Click += new System.EventHandler(this.TSBtn_editEmployeData_Click);
            // 
            // TSBtn_delete
            // 
            this.TSBtn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_delete.Image = global::APS_Desktop.Properties.Resources.trash;
            this.TSBtn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_delete.Name = "TSBtn_delete";
            this.TSBtn_delete.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_delete.Text = "Удалить сотрудника";
            this.TSBtn_delete.Click += new System.EventHandler(this.TSBtn_delete_Click);
            // 
            // TSBtn_search
            // 
            this.TSBtn_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_search.Image = global::APS_Desktop.Properties.Resources.search;
            this.TSBtn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_search.Name = "TSBtn_search";
            this.TSBtn_search.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_search.Text = "Поиск";
            // 
            // TSLbl_indicator
            // 
            this.TSLbl_indicator.ActiveLinkColor = System.Drawing.Color.MintCream;
            this.TSLbl_indicator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSLbl_indicator.LinkColor = System.Drawing.Color.MintCream;
            this.TSLbl_indicator.Name = "TSLbl_indicator";
            this.TSLbl_indicator.Size = new System.Drawing.Size(46, 22);
            this.TSLbl_indicator.Text = "Статус:";
            this.TSLbl_indicator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TSLbl_indicator.ToolTipText = "Статус соединения с базой данных";
            this.TSLbl_indicator.VisitedLinkColor = System.Drawing.Color.MintCream;
            // 
            // TSBtn_update_table
            // 
            this.TSBtn_update_table.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBtn_update_table.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_update_table.Image = global::APS_Desktop.Properties.Resources.refresh;
            this.TSBtn_update_table.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_update_table.Name = "TSBtn_update_table";
            this.TSBtn_update_table.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_update_table.Text = "Запросить актуальные данные";
            this.TSBtn_update_table.Click += new System.EventHandler(this.TSBtn_update_table_Click);
            // 
            // EmployeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(748, 284);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(733, 222);
            this.Name = "EmployeInfoForm";
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.EmployeInfoForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TSBtn_search;
        private System.Windows.Forms.ToolStripButton TSBtn_add;
        private System.Windows.Forms.ToolStripButton TSBtn_editEmployeData;
        private System.Windows.Forms.ToolStripButton TSBtn_delete;
        private System.Windows.Forms.ToolStripLabel TSLbl_indicator;
        private System.Windows.Forms.ToolStripButton TSBtn_update_table;
        private System.Windows.Forms.ColumnHeader lb_uid;
        private System.Windows.Forms.ColumnHeader lb_firstName;
        private System.Windows.Forms.ColumnHeader lb_secondName;
        private System.Windows.Forms.ColumnHeader lb_middleName;
        private System.Windows.Forms.ColumnHeader lb_firstPhone;
        private System.Windows.Forms.ColumnHeader lb_secondPhone;
        private System.Windows.Forms.ColumnHeader lb_departmentName;
        private System.Windows.Forms.ColumnHeader lb_post;
        private System.Windows.Forms.ColumnHeader lb_cabinet;
        private System.Windows.Forms.ListView listView_EmployeInfo;
    }
}