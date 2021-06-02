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
    public partial class AddEmployeForm : Form
    {
        private SqlConnection sqlConnection = null;
        bool nonCabinetFlag = false;

        public AddEmployeForm()
        {
            InitializeComponent();
        }

        //=================================================FUNCTIONS====================================================
        private void loadDepartment()
        {
            cB_department.Items.Clear();
            cB_position.Items.Clear();
            cB_cabinet.Items.Clear();

            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllDepartments";

                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    cB_department.Items.Add(Convert.ToString(dataReader["name"]));
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

        private void loadPosition(string dpt_name)
        {
            cB_position.Items.Clear();
            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllPositionNameFromDpt";

                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@dptName", SqlDbType.NVarChar).Value = dpt_name;

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    cB_position.Items.Add(Convert.ToString(dataReader["PositionName"]));
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
        private void loadCabinet(string dpt_name)
        {
            cB_cabinet.Items.Clear();
            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllCabinetNumberFromDpt";

                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@dptName", SqlDbType.NVarChar).Value = dpt_name;

                dataReader = sqlCommand.ExecuteReader();
                //sqlCommand.ExecuteNonQuery();

                while (dataReader.Read())
                {
                    cB_cabinet.Items.Add(Convert.ToString(dataReader["CabinetNumber"]));
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

        private void startGenerateGCode(string lastName, string firstName, string phoneNumber)
        {
            try
            {
                string procName = "IssueGcode";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@lstName", SqlDbType.NVarChar).Value = lastName;
                sqlCommand.Parameters.Add("@fstName", SqlDbType.NVarChar).Value = firstName;
                sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phoneNumber;

                sqlCommand.ExecuteNonQuery();
                //dataReader = sqlCommand.ExecuteReader();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Функция создающая нового сотрудника в БД
        private void startCreateNewEmploye(string firstName, string lastName, string middleName, string phoneNumber, string subPhoneN, string dptName, string pstnName, string cbntNumber)
        {

            try
            {
                string procName = "CreateNewEmploye";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@lstName", SqlDbType.NVarChar).Value = lastName;
                sqlCommand.Parameters.Add("@fstName", SqlDbType.NVarChar).Value = firstName;
                sqlCommand.Parameters.Add("@mdlName", SqlDbType.NVarChar).Value = middleName;
                sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phoneNumber;
                sqlCommand.Parameters.Add("@sd_phone", SqlDbType.NVarChar).Value = subPhoneN;
                sqlCommand.Parameters.Add("@dptName", SqlDbType.NVarChar).Value = dptName;
                sqlCommand.Parameters.Add("@pstnName", SqlDbType.NVarChar).Value = pstnName;
                sqlCommand.Parameters.Add("@cbntNumber", SqlDbType.NVarChar).Value = cbntNumber;

                SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);


                sqlCommand.ExecuteNonQuery();
                //dataReader = sqlCommand.ExecuteReader();  

                string msg_code = returnCode.Value.ToString();
                string msg_text = returnMsg.Value.ToString();


                if (!(msg_code == "Error")) { /*Выдаём g-code*/ startGenerateGCode(lastName, firstName, phoneNumber) ;
                    //Поля в исходное положение 
                    cB_position.Enabled = false;
                    cB_cabinet.Enabled = false;
                    tB_firstName.Text = "";
                    tB_lastName.Text = "";
                    tB_middleName.Text = "";
                    tB_phoneNumber.Text = "";
                    tB_subPhoneNumber.Text = "";
                }
                MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //==============================================================================================================


        private void Cancellation_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
            this.Close();
        }

        private void AddEmployeForm_Load(object sender, EventArgs e)
        {
            //cB_position.Enabled = false;
            //cB_cabinet.Enabled = false;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();
            loadDepartment();
        }

        private void tB_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ( !Char.IsDigit(ch) && !Char.IsControl(ch) )
            {
                e.Handled = true;
            }

        }

        private void tB_subPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && !Char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void cB_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem.ToString().Length > 0) {
                cB_position.Enabled = true;
                cB_cabinet.Enabled = true;
                //MessageBox.Show(comboBox.SelectedItem.ToString());
                loadPosition(comboBox.SelectedItem.ToString());
                loadCabinet(comboBox.SelectedItem.ToString());
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if ( checkBox.Checked == true )
            {
                //MessageBox.Show("true");
                nonCabinetFlag = true;
                cB_cabinet.Enabled = false;
            }
            else { /*MessageBox.Show("false");*/ nonCabinetFlag = false; cB_cabinet.Enabled = true; }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firstName, lastName, phoneNumber, dptName, pstnName, cbntNumber;
            string subPhoneN = "-";
            string middleName = "-";


            if ( tB_firstName.Text != string.Empty )
            {
                if (tB_lastName.Text != string.Empty)
                {
                    if (tB_phoneNumber.Text != string.Empty)
                    {
                        if ( cB_department.SelectedIndex > -1 )
                        {
                            if ( cB_position.SelectedIndex > -1)
                            {
                                cbntNumber = nonCabinetFlag ? "0" : cB_cabinet.SelectedItem.ToString();
                                pstnName = cB_position.SelectedItem.ToString();
                                dptName = cB_department.SelectedItem.ToString();
                                subPhoneN = tB_subPhoneNumber.Text != string.Empty ? tB_subPhoneNumber.Text : "-";
                                phoneNumber = tB_phoneNumber.Text;
                                middleName = tB_middleName.Text != string.Empty ? tB_middleName.Text : "-" ;
                                lastName = tB_lastName.Text;
                                firstName = tB_firstName.Text;

                                startCreateNewEmploye(firstName, lastName, middleName, phoneNumber, subPhoneN, dptName, pstnName, cbntNumber);
                            }
                            else { MessageBox.Show("Необходимо выбрать поле " + '"' + "Должность" + '"', "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                        else { MessageBox.Show("Необходимо выбрать поле " + '"' + "Отдел" + '"', "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }  
                    }
                    else { MessageBox.Show("Необходимо заполнить поле " + '"' + "Телефон" + '"', "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("Необходимо заполнить поле " + '"' + "Фамилия" + '"', "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Необходимо заполнить поле " + '"' + "Имя" + '"', "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void Btn_loadActualVersion_Click(object sender, EventArgs e)
        {
            loadDepartment();
        }
    }
}
