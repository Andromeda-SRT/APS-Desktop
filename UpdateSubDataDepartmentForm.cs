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
    public partial class UpdateSubDataDepartmentForm : Form
    {
        private SqlConnection sqlConnection = null;

        public UpdateSubDataDepartmentForm()
        {
            InitializeComponent();
        }

        public string department_name;
        public string old_name;
        public string flag;



        private void UpdateDepartmentProcedureForm_Load(object sender, EventArgs e)
        {
            textBox.Text = old_name; textBox.SelectionStart = 0; textBox.SelectionLength = textBox.Text.Length;
            string t_str = flag == "position" ? "должность " : "кабинет";
            this.Text = "Переименовать " + t_str + old_name + " в отделе " + '"'+department_name+'"';

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            string new_name = textBox.Text;
            if (!string.IsNullOrEmpty(new_name))
            {
                if (MessageBox.Show("Вы уверены что хотите изменить поле " + "'" + old_name + "'" + " на " + "'" + new_name + "'" + "? \n Это повлечёт изменение всех данных связанных с " + (flag == "position" ? "данной должностью. \nНаименование должностей у сотрудников так же измениться на новое" : (flag == "cabinet" ? "данным кабинетом. \nСотрудники связанные со старым кабинетом, так же переместяться в новый кабинет" : "мы не знаем что это такое, если бы мы знали что это такое - мы не знаем что это такое") + "!"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlDataReader dataReader = null;

                    try
                    {
                        string procName = "UpdateSubDataDepartment";

                        //Need to get cabinet
                        SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = department_name;
                        sqlCommand.Parameters.Add("@old_name", SqlDbType.NVarChar).Value = old_name;
                        sqlCommand.Parameters.Add("@new_name", SqlDbType.NVarChar).Value = new_name;
                        sqlCommand.Parameters.Add("@flag", SqlDbType.NVarChar).Value = flag;

                        //sqlCommand.Parameters.AddWithValue("@FLAG_CODE", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
                        //sqlCommand.Parameters.AddWithValue("@MESSAGE", SqlDbType.NVarChar).Direction = ParameterDirection.Output;

                        //SqlParameter returnCode = sqlCommand.Parameters.Add("@FLAG_CODE", SqlDbType.NVarChar);
                        //returnCode.Direction = ParameterDirection.Output;
                        //SqlParameter returnMsg = sqlCommand.Parameters.Add("@MESSAGE", SqlDbType.NVarChar);
                        //returnMsg.Direction = ParameterDirection.Output;

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
