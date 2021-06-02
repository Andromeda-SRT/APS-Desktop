using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//For use our the database
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace APS_Desktop
{
    public partial class PeopleInfoForm : Form
    {
        private SqlConnection sqlConnection = null;

        public PeopleInfoForm()
        {
            InitializeComponent();
        }

        public string _lastName;
        public string _firstName;
        public string _phoneNumber;

        //================================================FUNCTION=================================================
        //Функция запускающая процедуру получения всех данных о выбранном сотруднике и добавляющая их на форму
        private void execGetAllInfAboutThisEmploye(string lastName, string firstName, string phoneNumber)
        {
            cB_department.Items.Clear();
            cB_position.Items.Clear();
            cB_cabinet.Items.Clear();

            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllInformationAboutThisEmploye";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@lstName", SqlDbType.NVarChar).Value = lastName;
                sqlCommand.Parameters.Add("@fstName", SqlDbType.NVarChar).Value = firstName;
                sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phoneNumber;

                SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);

                //dataReader = sqlCommand.ExecuteReader();
                sqlCommand.ExecuteNonQuery();


                string msg_code = returnCode.Value.ToString();
                string msg_text = returnMsg.Value.ToString();

                if (msg_code == "Error")
                {
                    MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }
                else
                {
                    dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        lb_uid_emp.Text = Convert.ToString(dataReader["uid_emp"]);
                        tB_name.Text = Convert.ToString(dataReader["firstName"]);
                        tB_lastName.Text = Convert.ToString(dataReader["lastName"]);
                        tB_middleName.Text = Convert.ToString(dataReader["middleName"]);
                        tB_phone.Text = Convert.ToString(dataReader["phoneNumber"]);
                        tB_sphone.Text = Convert.ToString(dataReader["scd_phoneNumber"]);
                        cB_department.Items.Add(Convert.ToString(dataReader["dpt_name"]));
                        cB_position.Items.Add(Convert.ToString(dataReader["pstn_name"]));
                        cB_cabinet.Items.Add(Convert.ToString(dataReader["cbnt_number"]));
                        lb_gcode.Text = Convert.ToString(dataReader["code"]);

                        setThisTxtinDpt_CmbBox(Convert.ToString(dataReader["dpt_name"]));
                        setThisTxtinPstn_CmbBox(Convert.ToString(dataReader["pstn_name"]));
                        setThisTxtinCbnt_CmbBox(Convert.ToString(dataReader["cbnt_number"]));
                    }
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

        private void exexDeleteThisEmploye(string c_lastName, string c_firstName, string c_phoneNumber)
        {
            if (MessageBox.Show("Выуверены что хотите удалить выбранного сотрудника?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string procName = "DeleteThisEmploye";

                    //Need to get cabinet
                    SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@lstName", SqlDbType.NVarChar).Value = c_lastName;
                    sqlCommand.Parameters.Add("@fstName", SqlDbType.NVarChar).Value = c_firstName;
                    sqlCommand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = c_phoneNumber;

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

            }

        }
        //Функция которая ставит выбор ComboBox-а на необходимую строку, которая уже существует в ComboBox-е
        private void setThisTxtinDpt_CmbBox (string setThisTxt)
        {
            for (int i = 0; i < cB_department.Items.Count; i++)
            {
                if (cB_department.Items[i].ToString() == setThisTxt )
                {
                    cB_department.SelectedIndex = i;
                }
            }
        }
        private void setThisTxtinPstn_CmbBox(string setThisTxt)
        {
            for (int i = 0; i < cB_position.Items.Count; i++)
            {
                if (cB_position.Items[i].ToString() == setThisTxt)
                {
                    cB_position.SelectedIndex = i;
                }
            }
        }
        private void setThisTxtinCbnt_CmbBox(string setThisTxt)
        {
            if (setThisTxt == "0" || setThisTxt == string.Empty)
            {
                checkBox1.Checked = true;
                cB_cabinet.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cB_cabinet.Items.Count; i++)
                {
                    if (cB_cabinet.Items[i].ToString() == setThisTxt)
                    {
                        cB_cabinet.SelectedIndex = i;
                    }
                }
            }
        }

        private void editMode(bool flag)
        {
            if (flag)
            {
                panel_standart.Enabled = false;
                tB_panel.Enabled = true;
                panel_changing.Visible = true;
                panel_comboBoxes.Enabled = true;
                changePhoto.Visible = true;
                checkBox1.Enabled = true;
                PeopleInfoForm.ActiveForm.Text = "Редактирование";
            }
            else
            {
                tB_panel.Enabled = false;
                panel_changing.Visible = false;
                panel_standart.Enabled = true;
                panel_comboBoxes.Enabled = false;
                changePhoto.Visible = false;
                checkBox1.Enabled = false;
                PeopleInfoForm.ActiveForm.Text = "Информация о сотруднике";
            }
        }

        //Функция подготавливающая данные для процедуры обновления данных сотрудника
        private void execUpdateDataThisEmploye(string uid_emp, string firstName, string lastName, string middleName, string phoneNumber, string subPhoneN, string dptName, string pstnName, string cbntNumber)
        {
            try
            {
                string procName = "UpdateDataThisEmploye";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@UID_EMPL", SqlDbType.NVarChar).Value = uid_emp;
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


                if (!(msg_code == "Error"))
                { /*Выдаём g-code*/
                    editMode(false);
                }
                MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void loadCb (string choisedDpt, string choisedPstn, string choisedCbnt)
        {
            cB_department.Items.Clear();
            cB_position.Items.Clear();
            cB_cabinet.Items.Clear();

            loadDepartment();
            setThisTxtinDpt_CmbBox(choisedDpt);
            loadPosition(choisedDpt);
            setThisTxtinPstn_CmbBox(choisedPstn);
            loadCabinet(choisedDpt);
            setThisTxtinCbnt_CmbBox(choisedCbnt);

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

        //==========================================================================================================

        private void edit_i_emp_Click(object sender, EventArgs e)
        {
            editMode(true);
            //Проверка на Empty ибо передать Empty мы не можем
            string strCbnt;
            if (cB_cabinet.SelectedIndex > -1) { strCbnt = cB_cabinet.SelectedItem.ToString(); } else { strCbnt = "0"; }

            loadCb(cB_department.SelectedItem.ToString(), cB_position.SelectedItem.ToString(), strCbnt);
            //cB_department.SelectedItem = cB_department.Items[0];
        }

        private void cancel_changes_Click(object sender, EventArgs e)
        {
            editMode(false);
            execGetAllInfAboutThisEmploye(_lastName, _firstName, _phoneNumber);
        }

        private void PeopleInfoForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            sqlConnection.Open();

            execGetAllInfAboutThisEmploye(_lastName, _firstName, _phoneNumber);
        }

        private void apply_changes_Click(object sender, EventArgs e)
        {
            string firstName, lastName, phoneNumber, dptName, pstnName, cbntNumber;
            string subPhoneN = "-";
            string middleName = "-";

            if (tB_name.Text != string.Empty)
            {
                if (tB_lastName.Text != string.Empty)
                {
                    if (tB_phone.Text != string.Empty)
                    {
                        if (cB_department.SelectedIndex > -1)
                        {
                            if (cB_position.SelectedIndex > -1)
                            {
                                cbntNumber = checkBox1.Checked ? "0" : cB_cabinet.SelectedItem.ToString();
                                pstnName = cB_position.SelectedItem.ToString();
                                dptName = cB_department.SelectedItem.ToString();
                                subPhoneN = tB_sphone.Text != string.Empty ? tB_sphone.Text : "-";
                                phoneNumber = tB_phone.Text;
                                middleName = tB_middleName.Text != string.Empty ? tB_middleName.Text : "-";
                                lastName = tB_lastName.Text;
                                firstName = tB_name.Text;

                                string uid_emp = lb_uid_emp.Text;
                                if (MessageBox.Show("Вы действительно хотите обновить информацию о сотруднике?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                execUpdateDataThisEmploye(uid_emp, firstName, lastName, middleName, phoneNumber, subPhoneN, dptName, pstnName, cbntNumber);
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

        private void delete_emp_Click(object sender, EventArgs e)
        {
            exexDeleteThisEmploye(tB_lastName.Text, tB_name.Text, tB_phone.Text);
            this.Close();
        }
        //Функция подгружающая комбобоксы в зависимости от выбранного комбобоква отдела
        private void cB_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem.ToString().Length > 0)
            {
                //MessageBox.Show(comboBox.SelectedItem.ToString());
                loadPosition(comboBox.SelectedItem.ToString());
                loadCabinet(comboBox.SelectedItem.ToString());
            }
        }

        private void tB_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && !Char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked == true)
            {
                //MessageBox.Show("true");
                cB_cabinet.Enabled = false;
            }
            else { cB_cabinet.Enabled = true; }
        }
    }
}
