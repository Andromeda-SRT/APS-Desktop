using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace APS_Desktop
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        //==========================================FUNCTIONS============================================
        private void updateLV_timeSheet()
        {
            listView_MainForm.Items.Clear();


            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllTimeSheet";

                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    { Convert.ToString(dataReader["id_emp"]),
                      Convert.ToString(dataReader["ts_lastName"]),
                      Convert.ToString(dataReader["ts_firstName"]),
                      Convert.ToString(dataReader["ts_middleName"]),
                      Convert.ToString(dataReader["ts_dpt_name"]),
                      Convert.ToString(dataReader["ts_pstn_name"]),
                      Convert.ToString(dataReader["ts_date"]),
                      Convert.ToString(dataReader["ts_time"]),
                      Convert.ToString(dataReader["ts_route"]),
                      Convert.ToString(dataReader["ts_method"]) });

                    listView_MainForm.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }


        private void updateLV_fullTime()
        {
            listView_allTime.Items.Clear();


            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM historyAllTime WHERE historyAllTime.uid_ts IS NOT NULL", sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.Text;

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    { Convert.ToString(dataReader["id_emp"]),
                      Convert.ToString(dataReader["ah_lastName"]),
                      Convert.ToString(dataReader["ah_firstName"]),
                      Convert.ToString(dataReader["ah_middleName"]),
                      Convert.ToString(dataReader["ah_dpt_name"]),
                      Convert.ToString(dataReader["ah_pstn_name"]),
                      Convert.ToString(dataReader["ah_date"]),
                      Convert.ToString(dataReader["ah_time"]),
                      Convert.ToString(dataReader["ah_route"]),
                      Convert.ToString(dataReader["ah_method"]) });

                    listView_allTime.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }



        //====================================================================================================

        bool fpanel_Seatch = false;

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Setings_Click(object sender, EventArgs e)
        {
            Form SF = new SettingForm();
            SF.Show();
        }

        private void TSMI_Workers_Click(object sender, EventArgs e)
        {
            Form WF = new EmployeInfoForm();
            WF.Show();
        }

        private void TSMI_AddWorker_Click(object sender, EventArgs e)
        {
            Form addWF = new AddEmployeForm();
            addWF.Show();
        }

        private void TSMI_AboutProgram_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Search()
        {
            if (fpanel_Seatch)
            {
                panelSearch.Visible = false;
                fpanel_Seatch = false;
            }
            else
            {
                panelSearch.Visible = true;
                fpanel_Seatch = true;
            }
        }


        private void pSBtn_Close_Click(object sender, EventArgs e)
        {
            panel_Search();
        }

        private void TSMI_Search_Click_1(object sender, EventArgs e)
        {
            panel_Search();
        }

        private void TSMI_Department_Click(object sender, EventArgs e)
        {
            Form dptInfoForm = new DepartmentsInfoForm();
            dptInfoForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();
            updateLV_timeSheet();
        }

        private void TSMI_Update_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPage1")
            {
                //MessageBox.Show("1");
                updateLV_timeSheet();
            }
            else if (tabControl.SelectedTab.Name == "tabPage2")
            {
                //MessageBox.Show("2");
                updateLV_fullTime();
            }
            else { MessageBox.Show("Необходимо выбрать одну из вкладок", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }
    }
}
