namespace APS_Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьЛогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЛогиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Setings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Workers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pSBtn_Close = new System.Windows.Forms.Button();
            this.pSBtn_Search = new System.Windows.Forms.Button();
            this.pS_textBox = new System.Windows.Forms.TextBox();
            this.listView_MainForm = new System.Windows.Forms.ListView();
            this.UID_emp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secondName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.middleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.method_entry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView_allTime = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_Setings,
            this.TSMI_Workers,
            this.TSMI_AddWorker,
            this.TSMI_Department,
            this.TSMI_AboutProgram,
            this.TSMI_Search,
            this.TSMI_Update});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьЛогиToolStripMenuItem,
            this.загрузитьЛогиToolStripMenuItem,
            this.выгрузитьНастройкиToolStripMenuItem,
            this.загрузитьНастройкиToolStripMenuItem});
            this.TSMI_File.Image = global::APS_Desktop.Properties.Resources.document;
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(64, 20);
            this.TSMI_File.Text = "Файл";
            // 
            // выгрузитьЛогиToolStripMenuItem
            // 
            this.выгрузитьЛогиToolStripMenuItem.Name = "выгрузитьЛогиToolStripMenuItem";
            this.выгрузитьЛогиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.выгрузитьЛогиToolStripMenuItem.Text = "Выгрузить логи";
            // 
            // загрузитьЛогиToolStripMenuItem
            // 
            this.загрузитьЛогиToolStripMenuItem.Name = "загрузитьЛогиToolStripMenuItem";
            this.загрузитьЛогиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.загрузитьЛогиToolStripMenuItem.Text = "Загрузить логи";
            // 
            // выгрузитьНастройкиToolStripMenuItem
            // 
            this.выгрузитьНастройкиToolStripMenuItem.Name = "выгрузитьНастройкиToolStripMenuItem";
            this.выгрузитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.выгрузитьНастройкиToolStripMenuItem.Text = "Выгрузить настройки";
            // 
            // загрузитьНастройкиToolStripMenuItem
            // 
            this.загрузитьНастройкиToolStripMenuItem.Name = "загрузитьНастройкиToolStripMenuItem";
            this.загрузитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.загрузитьНастройкиToolStripMenuItem.Text = "Загрузить настройки";
            // 
            // TSMI_Setings
            // 
            this.TSMI_Setings.Image = global::APS_Desktop.Properties.Resources.settings;
            this.TSMI_Setings.Name = "TSMI_Setings";
            this.TSMI_Setings.Size = new System.Drawing.Size(95, 20);
            this.TSMI_Setings.Text = "Настройки";
            this.TSMI_Setings.Click += new System.EventHandler(this.TSMI_Setings_Click);
            // 
            // TSMI_Workers
            // 
            this.TSMI_Workers.Image = global::APS_Desktop.Properties.Resources.workgroup;
            this.TSMI_Workers.Name = "TSMI_Workers";
            this.TSMI_Workers.Size = new System.Drawing.Size(101, 20);
            this.TSMI_Workers.Text = "Сотрудники";
            this.TSMI_Workers.Click += new System.EventHandler(this.TSMI_Workers_Click);
            // 
            // TSMI_AddWorker
            // 
            this.TSMI_AddWorker.Image = global::APS_Desktop.Properties.Resources.add;
            this.TSMI_AddWorker.Name = "TSMI_AddWorker";
            this.TSMI_AddWorker.Size = new System.Drawing.Size(153, 20);
            this.TSMI_AddWorker.Text = "Добавить сотрудника";
            this.TSMI_AddWorker.Click += new System.EventHandler(this.TSMI_AddWorker_Click);
            // 
            // TSMI_Department
            // 
            this.TSMI_Department.Image = global::APS_Desktop.Properties.Resources.departments;
            this.TSMI_Department.Name = "TSMI_Department";
            this.TSMI_Department.Size = new System.Drawing.Size(77, 20);
            this.TSMI_Department.Text = "Отделы";
            this.TSMI_Department.Click += new System.EventHandler(this.TSMI_Department_Click);
            // 
            // TSMI_AboutProgram
            // 
            this.TSMI_AboutProgram.Image = global::APS_Desktop.Properties.Resources.information;
            this.TSMI_AboutProgram.Name = "TSMI_AboutProgram";
            this.TSMI_AboutProgram.Size = new System.Drawing.Size(110, 20);
            this.TSMI_AboutProgram.Text = "О программе";
            this.TSMI_AboutProgram.Click += new System.EventHandler(this.TSMI_AboutProgram_Click);
            // 
            // TSMI_Search
            // 
            this.TSMI_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSMI_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TSMI_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMI_Search.Image = global::APS_Desktop.Properties.Resources.search;
            this.TSMI_Search.Name = "TSMI_Search";
            this.TSMI_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TSMI_Search.Size = new System.Drawing.Size(28, 20);
            this.TSMI_Search.Text = "Поиск";
            this.TSMI_Search.ToolTipText = "Поиск";
            this.TSMI_Search.Click += new System.EventHandler(this.TSMI_Search_Click_1);
            // 
            // TSMI_Update
            // 
            this.TSMI_Update.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSMI_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TSMI_Update.Image = global::APS_Desktop.Properties.Resources.refresh;
            this.TSMI_Update.Name = "TSMI_Update";
            this.TSMI_Update.Size = new System.Drawing.Size(89, 20);
            this.TSMI_Update.Text = "Обновить";
            this.TSMI_Update.ToolTipText = "Обновить";
            this.TSMI_Update.Click += new System.EventHandler(this.TSMI_Update_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSearch.BackColor = System.Drawing.Color.Azure;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.pSBtn_Close);
            this.panelSearch.Controls.Add(this.pSBtn_Search);
            this.panelSearch.Controls.Add(this.pS_textBox);
            this.panelSearch.Location = new System.Drawing.Point(179, 115);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(397, 62);
            this.panelSearch.TabIndex = 2;
            this.panelSearch.Visible = false;
            // 
            // pSBtn_Close
            // 
            this.pSBtn_Close.BackColor = System.Drawing.Color.Red;
            this.pSBtn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pSBtn_Close.Location = new System.Drawing.Point(371, 3);
            this.pSBtn_Close.Name = "pSBtn_Close";
            this.pSBtn_Close.Size = new System.Drawing.Size(21, 21);
            this.pSBtn_Close.TabIndex = 2;
            this.pSBtn_Close.Text = "X";
            this.pSBtn_Close.UseVisualStyleBackColor = false;
            this.pSBtn_Close.Click += new System.EventHandler(this.pSBtn_Close_Click);
            // 
            // pSBtn_Search
            // 
            this.pSBtn_Search.Location = new System.Drawing.Point(154, 30);
            this.pSBtn_Search.Name = "pSBtn_Search";
            this.pSBtn_Search.Size = new System.Drawing.Size(75, 23);
            this.pSBtn_Search.TabIndex = 1;
            this.pSBtn_Search.Text = "Поиск";
            this.pSBtn_Search.UseVisualStyleBackColor = true;
            // 
            // pS_textBox
            // 
            this.pS_textBox.Location = new System.Drawing.Point(3, 4);
            this.pS_textBox.Name = "pS_textBox";
            this.pS_textBox.Size = new System.Drawing.Size(365, 20);
            this.pS_textBox.TabIndex = 0;
            // 
            // listView_MainForm
            // 
            this.listView_MainForm.BackColor = System.Drawing.Color.MintCream;
            this.listView_MainForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UID_emp,
            this.firstName,
            this.secondName,
            this.middleName,
            this.department,
            this.position,
            this.date,
            this.time,
            this.route,
            this.method_entry});
            this.listView_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_MainForm.FullRowSelect = true;
            this.listView_MainForm.GridLines = true;
            this.listView_MainForm.HideSelection = false;
            this.listView_MainForm.Location = new System.Drawing.Point(3, 3);
            this.listView_MainForm.Name = "listView_MainForm";
            this.listView_MainForm.Size = new System.Drawing.Size(778, 322);
            this.listView_MainForm.TabIndex = 3;
            this.listView_MainForm.UseCompatibleStateImageBehavior = false;
            this.listView_MainForm.View = System.Windows.Forms.View.Details;
            // 
            // UID_emp
            // 
            this.UID_emp.Text = "ID";
            this.UID_emp.Width = 25;
            // 
            // firstName
            // 
            this.firstName.Text = "Фамилия";
            this.firstName.Width = 80;
            // 
            // secondName
            // 
            this.secondName.Text = "Имя";
            this.secondName.Width = 88;
            // 
            // middleName
            // 
            this.middleName.Text = "Отчество";
            this.middleName.Width = 105;
            // 
            // department
            // 
            this.department.Text = "Отдел";
            this.department.Width = 150;
            // 
            // position
            // 
            this.position.Text = "Должность";
            this.position.Width = 99;
            // 
            // date
            // 
            this.date.Text = "Дата";
            // 
            // time
            // 
            this.time.Text = "Время";
            // 
            // route
            // 
            this.route.Text = "Направление";
            // 
            // method_entry
            // 
            this.method_entry.Text = "Способ ввода ключа";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 354);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_MainForm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "История посещений";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView_allTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История за всё время";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView_allTime
            // 
            this.listView_allTime.BackColor = System.Drawing.Color.MintCream;
            this.listView_allTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView_allTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_allTime.FullRowSelect = true;
            this.listView_allTime.GridLines = true;
            this.listView_allTime.HideSelection = false;
            this.listView_allTime.Location = new System.Drawing.Point(3, 3);
            this.listView_allTime.Name = "listView_allTime";
            this.listView_allTime.Size = new System.Drawing.Size(778, 322);
            this.listView_allTime.TabIndex = 4;
            this.listView_allTime.UseCompatibleStateImageBehavior = false;
            this.listView_allTime.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Отдел";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Должность";
            this.columnHeader6.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Время";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Направление";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Способ ввода ключа";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(792, 378);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(808, 222);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "APS Desktop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьЛогиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЛогиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Setings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Workers;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddWorker;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AboutProgram;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Search;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button pSBtn_Close;
        private System.Windows.Forms.Button pSBtn_Search;
        private System.Windows.Forms.TextBox pS_textBox;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Update;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Department;
        private System.Windows.Forms.ListView listView_MainForm;
        private System.Windows.Forms.ColumnHeader UID_emp;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader secondName;
        private System.Windows.Forms.ColumnHeader middleName;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader route;
        private System.Windows.Forms.ColumnHeader method_entry;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_allTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}