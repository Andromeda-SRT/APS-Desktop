using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APS_Desktop
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            MainForm newMDIChild_Main = new MainForm();

            //newMDIChild_Main.MdiParent = AutorizationForm.ActiveForm;
           
            newMDIChild_Main.Show();
            this.Hide();

            //AutorizationForm.ActiveForm.Close();
            //MainForm.ActiveForm.Show();
            //MainForm.ActiveForm.Activate();
        }
    }
}
