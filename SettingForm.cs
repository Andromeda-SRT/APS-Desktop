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
    public partial class SettingForm : Form
    {
        private SqlConnection sqlConnection = null;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void Btn_ClearTimesheetAllTime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите очистить историю за всё время? Данные будут потеряны безвозвратно!","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("TRUNCATE TABLE historyAllTime", sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.Text;

                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Операция выполнена успешно", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();
        }
    }
}
