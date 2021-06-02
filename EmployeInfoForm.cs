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
    public partial class EmployeInfoForm : Form
    {
        //This class is could execute/run all operations with our database
        private SqlConnection sqlConnection = null;

        public EmployeInfoForm()
        {
            InitializeComponent();
        }

        //==========================================================FUNCTIONS=========================================================

        private void indicator(bool res)
        {
            if (res)
            {
                Image indicatorTrue = Image.FromFile("C:\\Users\\Andromeda\\Desktop\\ЯГТУ\\2 КУРС 20-21\\4 семестр\\ЛР и ПР\\СУБД\\LR7 (Проект)\\APS Desktop\\Resources\\indicatorTrue.png");
                TSLbl_indicator.Image = indicatorTrue;
            }
            else {
                Image indicatorFalse = Image.FromFile("C:\\Users\\Andromeda\\Desktop\\ЯГТУ\\2 КУРС 20-21\\4 семестр\\ЛР и ПР\\СУБД\\LR7 (Проект)\\APS Desktop\\Resources\\indicatorFalse.png");
                TSLbl_indicator.Image = indicatorFalse;
            }
        }
        //Функция обновляющая данные ListView в котором распологается информация обо всех сотрудниках
        private void updateListView()
        {
            listView_EmployeInfo.Items.Clear();

            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT uid_emp, lastName, firstName, middleName, phoneNumber, scd_phoneNumber, dpt_name, pstn_name, cbnt_number FROM employe INNER JOIN department on id_dpt = uid_dpt WHERE uid_emp IS NOT NULL;", sqlConnection);

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    {   Convert.ToString(dataReader["uid_emp"]),
                        Convert.ToString(dataReader["lastName"]),
                        Convert.ToString(dataReader["firstName"]),
                        Convert.ToString(dataReader["middleName"]),
                        Convert.ToString(dataReader["phoneNumber"]),
                        Convert.ToString(dataReader["scd_phoneNumber"]),
                        Convert.ToString(dataReader["dpt_name"]),
                        Convert.ToString(dataReader["pstn_name"]),
                        Convert.ToString(dataReader["cbnt_number"])
                    });

                    //item = new ListViewItem(Convert.ToString(dataReader["uid_emp"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["lastName"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["firstName"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["middleName"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["phoneNumber"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["scd_phoneNumber"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["dpt_name"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["pstn_name"]));
                    //item.SubItems.Add(Convert.ToString(dataReader["cbnt_number"]));

                    listView_EmployeInfo.Items.Add(item);
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

        private void startPeopleInfoForm()
        {
            if (listView_EmployeInfo.SelectedItems.Count > 0)
            {
                string c_lastName = string.Empty;
                string c_firstName = string.Empty;
                string c_phoneNumber = string.Empty;
                //get data of choised string into listview
                c_lastName = listView_EmployeInfo.FocusedItem.SubItems[1].Text;
                c_firstName = listView_EmployeInfo.FocusedItem.SubItems[2].Text;
                c_phoneNumber = listView_EmployeInfo.FocusedItem.SubItems[4].Text;

                using (PeopleInfoForm form = new PeopleInfoForm())
                {
                    if (c_lastName != string.Empty && c_firstName != string.Empty && c_phoneNumber != string.Empty )
                    {
                        form._lastName = c_lastName;
                        form._firstName = c_firstName;
                        form._phoneNumber = c_phoneNumber;
                        form.ShowDialog(this);
                    }
                    else { MessageBox.Show("Ошибка! В вызываемом элементе обнаружено значение Null ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    
                }
            }
            else { MessageBox.Show("Необходимо выбрать сотрудника", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        //========================================================================================================

        //At the moment of creating the form
        private void EmployeInfoForm_Load(object sender, EventArgs e)
        {
            //Creating an instance of the class to initialize
            //and write the link to the sqlConnection variable
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();


            if (sqlConnection.State == ConnectionState.Open) { indicator(true); }
            else { indicator(false); }

            updateListView();

        }

        private void TSBtn_add_Click(object sender, EventArgs e)
        {
            using (AddEmployeForm form = new AddEmployeForm())
            {
                form.ShowDialog();
            }
            updateListView();
        }

        

        private void TSBtn_update_table_Click(object sender, EventArgs e)
        {
            updateListView();
        }

        private void listView_EmployeInfo_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            listView_EmployeInfo.Cursor = Cursors.Hand;
        }

        private void TSBtn_delete_Click(object sender, EventArgs e)
        {
            if (listView_EmployeInfo.SelectedItems.Count > 0)
            {
                string c_lastName = string.Empty;
                string c_firstName = string.Empty;
                string c_phoneNumber = string.Empty;
                //get data of choised string into listview
                c_lastName = listView_EmployeInfo.FocusedItem.SubItems[1].Text;
                c_firstName = listView_EmployeInfo.FocusedItem.SubItems[2].Text;
                c_phoneNumber = listView_EmployeInfo.FocusedItem.SubItems[4].Text;

                //MessageBox.Show(c_firstName + c_lastName + c_phoneNumber);
                
                exexDeleteThisEmploye(c_lastName, c_firstName, c_phoneNumber);
            }
            else { MessageBox.Show("Необходимо выбрать удаляемого сотрудника!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            updateListView();
        }

        private void listView_EmployeInfo_DoubleClick(object sender, EventArgs e)
        {
            startPeopleInfoForm();
            updateListView();
        }

        private void TSBtn_editEmployeData_Click(object sender, EventArgs e)
        {
            startPeopleInfoForm();
            updateListView();
        }
    }
}
