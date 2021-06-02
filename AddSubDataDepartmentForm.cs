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
    public partial class AddSubDataDepartmentForm : Form
    {
        private SqlConnection sqlConnection = null;

        public AddSubDataDepartmentForm()
        {
            InitializeComponent();
        }

        public string department_name;
        public string flag;

        private void AddSubDataDepartmentForm_Load(object sender, EventArgs e)
        {
            string t_str = flag == "position" ? "должность" : "кабинет";
            this.Text = "Добавить " + t_str + " в отдел " + '"'+department_name+'"';

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            string new_name = textBox.Text;
            if ( !string.IsNullOrEmpty(new_name) )
            {
                if (MessageBox.Show($"Вы уверены что хотите добавить " + (flag == "cabinet" ? "кабинет" : "должность" + "'" + new_name + "'" + " в отдел " + "'" + department_name + "'" + "?"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlDataReader dataReader = null;

                    try
                    {
                        string procName = "AddSubDataDepartment";

                        //Need to get cabinet
                        SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = department_name;
                        sqlCommand.Parameters.Add("@new_name", SqlDbType.NVarChar).Value = new_name;
                        sqlCommand.Parameters.Add("@flag", SqlDbType.NVarChar).Value = flag;

                        SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                        { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                        SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                        { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);


                        sqlCommand.ExecuteNonQuery();
                        //dataReader = sqlCommand.ExecuteReader();  

                        string msg_code = returnCode.Value.ToString();
                        string msg_text = returnMsg.Value.ToString();

                        MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
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

                    //MessageBox.Show("Ща проведу процедуру dpt_name: "+ department_name +" old_Name: " + old_name + " new_Name: " + new_name + " flag: " + flag );
                    //Run Procedure 
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
