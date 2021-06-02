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
    public partial class DepartmentCreateForm : Form
    {
        private SqlConnection sqlConnection = null;

        public DepartmentCreateForm()
        {
            InitializeComponent();
        }
        //==================================================FUNCTIONS=================================================
        //Функция возвращающая string "False" - если запрашиваемый отдел не существует в списке отделов
        private string returnBit(string department_name)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();

           
            string funcName = "CheckThisDepartment";

            SqlCommand sqlCommand = new SqlCommand(funcName, sqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;


            sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = department_name;
            SqlParameter returnBIT = new SqlParameter("@res", SqlDbType.Bit)
            { Direction = ParameterDirection.ReturnValue }; sqlCommand.Parameters.Add(returnBIT);

            sqlCommand.ExecuteNonQuery();


            string valueTorF = returnBIT.Value.ToString();

            sqlConnection.Close();

            return valueTorF;
           
        }
        private void execAddDepartment(string newDepartment_name)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();

            try
            {
                string procName = "CreateNewDepartment";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = newDepartment_name;

                SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);


                sqlCommand.ExecuteNonQuery();
                //dataReader = sqlCommand.ExecuteReader();  

                string msg_code = returnCode.Value.ToString();
                string msg_text = returnMsg.Value.ToString();

                if (msg_code == "Error")
                {
                    MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }


        private void execAddPosition(string department_name, string AddPosition_name)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();


            string flag = "position";

            try
            {
                string procName = "AddSubDataDepartment";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = department_name;
                sqlCommand.Parameters.Add("@new_name", SqlDbType.NVarChar).Value = AddPosition_name;
                sqlCommand.Parameters.Add("@flag", SqlDbType.NVarChar).Value = flag;

                SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);


                sqlCommand.ExecuteNonQuery();
                //dataReader = sqlCommand.ExecuteReader();  

                string msg_code = returnCode.Value.ToString();
                string msg_text = returnMsg.Value.ToString();

                if ( msg_code == "Error" )
                {
                    MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }

        private void execAddCabinet(string department_name, string AddCabinet_Name)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);
            sqlConnection.Open();

            string flag = "cabinet";

            try
            {
                string procName = "AddSubDataDepartment";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = department_name;
                sqlCommand.Parameters.Add("@new_name", SqlDbType.NVarChar).Value = AddCabinet_Name;
                sqlCommand.Parameters.Add("@flag", SqlDbType.NVarChar).Value = flag;

                SqlParameter returnCode = new SqlParameter("@FLAG_CODE", SqlDbType.NVarChar, 5)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnCode);

                SqlParameter returnMsg = new SqlParameter("@MESSAGE", SqlDbType.NVarChar, 200)
                { Direction = ParameterDirection.Output }; sqlCommand.Parameters.Add(returnMsg);


                sqlCommand.ExecuteNonQuery();
                //dataReader = sqlCommand.ExecuteReader();  

                string msg_code = returnCode.Value.ToString();
                string msg_text = returnMsg.Value.ToString();

                if (msg_code == "Error")
                {
                    MessageBox.Show(msg_text, msg_code, MessageBoxButtons.OK, msg_code == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }

        //=====================================================================================================================

        private void Btn_OkDpt_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != string.Empty )
            {
                string newDptName = textBox1.Text;
                if (returnBit(newDptName) == "False") //False - т.е данный отдел не существует (нет совпадений)
                {
                    textBox1.Text = newDptName; textBox1.Enabled = false;
                    label_dptName.Text = newDptName;
                    textBox2.Enabled = true; textBox3.Enabled = true;
                    textBox2.Text = ""; textBox3.Text = "";
                    Btn_addPosition.Enabled = true; Btn_addCabinet.Enabled = true;
                    Btn_Create.Enabled = true;
                    Btn_OkDpt.Enabled = false;
                }
                else 
                { 
                    MessageBox.Show("Отдел" + '"'+newDptName+'"' + "уже существует","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Enabled = false; textBox3.Enabled = false;
                    label_dptName.Text = "DepartmentName";
                }

            }
            else { MessageBox.Show("Необходимо заполнить поле!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Btn_EditDpt_Click(object sender, EventArgs e)
        {
            Btn_addPosition.Enabled = false; Btn_addCabinet.Enabled = false;
            textBox2.Enabled = false; textBox3.Enabled = false;
            textBox2.Text = ""; textBox3.Text = "";
            textBox1.Enabled = true;
            label_dptName.Text = "DepartmentName";
            listView_position.Items.Clear();
            listView_cabinet.Items.Clear();
            Btn_Create.Enabled = false;
            Btn_OkDpt.Enabled = true;
        }

        private void Btn_addPosition_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                string addStr = textBox2.Text;
                
                //For cheking to contains addStr item in listView
                bool flag_containsThisStr = false;
                for (int i = 0; i < listView_position.Items.Count; i++)
                {
                    if (listView_position.Items[i].SubItems[0].Text == addStr)
                    {
                        flag_containsThisStr = true;
                    }
                }

                if ( !flag_containsThisStr)
                {
                    listView_position.Items.Add(addStr);
                    textBox2.Text = "";
                }
                else { MessageBox.Show('"'+addStr+'"' + " уже существует в списке должностей", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); textBox2.Text = ""; }

            }
            else { MessageBox.Show("Необходимо заполнить поле 'Должность'!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Btn_addCabinet_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != string.Empty)
            {
                string addStr = textBox3.Text;

                //For cheking to contains addStr item in listView
                bool flag_containsThisStr = false;
                for (int i = 0; i < listView_cabinet.Items.Count; i++)
                {
                    if (listView_cabinet.Items[i].SubItems[0].Text == addStr)
                    {
                        flag_containsThisStr = true;
                    }
                }

                if (!flag_containsThisStr)
                {
                    listView_cabinet.Items.Add(addStr);
                    textBox3.Text = "";
                }
                else { MessageBox.Show('"' + addStr + '"' + " уже существует в списке должностей", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); textBox3.Text = ""; }
            }
            else { MessageBox.Show("Необходимо заполнить поле 'Кабинет'!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Btn_ClearThisPosition_Click(object sender, EventArgs e)
        {
            if (listView_position.SelectedItems.Count > 0)
            {
                //string choised_str = listView_position.FocusedItem.SubItems[1].Text;
                listView_position.FocusedItem.Remove();
            }
            else { MessageBox.Show("Необходимо выбрать должность в списке должностей!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Btn_ClearThisCabinet_Click(object sender, EventArgs e)
        {
            if ( listView_cabinet.SelectedItems.Count > 0)
            {
                //string choised_str = listView_position.FocusedItem.SubItems[1].Text;
                listView_cabinet.FocusedItem.Remove();
            }
            else { MessageBox.Show("Необходимо выбрать кабинет в списке кабинетов!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //Процедура создания отдела
            if (textBox1.Text != string.Empty )
            {
                execAddDepartment(textBox1.Text);
            }
            else { MessageBox.Show("Не введено названия создаваемого отдела", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            //Процедура добавления должности по выбранному отделу
            if (listView_position.Items.Count > 0)
            {
                for (int i = 0; i < listView_position.Items.Count; i++)
                {
                    //MessageBox.Show(listView_position.Items[i].SubItems[0].Text);
                    execAddPosition(textBox1.Text, listView_position.Items[i].SubItems[0].Text);
                }
            }

            //Процедура добавления кабинета по выбранному отделу
            if (listView_cabinet.Items.Count > 0)
            {
                for (int i = 0; i < listView_cabinet.Items.Count; i++)
                {
                    //MessageBox.Show(listView_cabinet.Items[i].SubItems[0].Text);
                    execAddCabinet(textBox1.Text, listView_cabinet.Items[i].SubItems[0].Text);
                }
            }

            if ( !(returnBit(textBox1.Text) == "False") )
            {
                MessageBox.Show("Отдел "+ '"'+textBox1.Text+'"' + " успешно создан!");
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox1.Enabled = true; textBox2.Enabled = false; textBox3.Enabled = false;
                listView_cabinet.Items.Clear(); listView_position.Items.Clear();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentCreateForm_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false; textBox3.Enabled = false;
            Btn_addPosition.Enabled = false; Btn_addCabinet.Enabled = false;
            Btn_Create.Enabled = false;
            Btn_Cancel.Enabled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ( !Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
