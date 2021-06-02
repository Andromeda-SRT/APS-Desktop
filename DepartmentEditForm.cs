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
    public partial class DepartmentEditForm : Form
    {
        private SqlConnection sqlConnection = null;

        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        public string TextValue {
                get {return comboBox_choise.Text;}
                set {comboBox_choise.Items.Add(value); comboBox_choise.SelectedIndex = 0; }
            }


        // ------>>>> FUNCTIONS <<<<<<-------------

        //Функция загрузки данных из БД и добавления их в ListView (ListView_Positions)
        private void updateLV_Positions()
        {
            listView_Positions.Items.Clear();

            SqlDataReader dataReader = null;

            try
            {
                string procName_getDpt = "GetAllPositionNameFromDpt";

                //Need to get positions
                SqlCommand sqlCommand = new SqlCommand(procName_getDpt, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@dptName", SqlDbType.NVarChar).Value = comboBox_choise.Text;


                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    { Convert.ToString(dataReader["PositionName"])
                    });


                    listView_Positions.Items.Add(item);
                }

                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
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

        //Функция загрузки данных из БД и добавления их в ListView (listView_Cabinets)
        private void updateLV_Cabinets()
        {
            listView_Cabinets.Items.Clear();


            SqlDataReader dataReader = null;

            try
            {
                string procName_getCbnt = "GetAllCabinetNumberFromDpt";

                //Need to get cabinet
                SqlCommand sqlCommand = new SqlCommand(procName_getCbnt, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@dptName", SqlDbType.NVarChar).Value = comboBox_choise.Text;

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    { Convert.ToString(dataReader["CabinetNumber"])
                    });


                    listView_Cabinets.Items.Add(item);
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

        //Функция обновления (корретирования названий) данных для кабинета или должности, в зависимости от выбора пользователя, по уже ОТКРЫТОМУ отделу
        public void startUpdateForm(string NameTbleBeChanged)
        {
            //Подготовка данных к ПРОЦЕДУРЕ - UpdateSubDataDepartment
            string dpt_name = comboBox_choise.Text; //Открытый отдел (department_name в параметре процедуры)
            string choised_position = "";           //Выбранная должность (old_name в параметре процедуры)
            string choised_cabinet = "";            //Выбранный кабинет (old_name в параметре процедуры)
            string choised_flag = "";               //Что меняем кабинет или должность (flag в параметре процедуры)

            if (NameTbleBeChanged == "position")
            {
                if (listView_Positions.SelectedItems.Count > 0)
                {
                    //get data of choised string into listview
                    string choised_str = listView_Positions.FocusedItem.SubItems[0].Text;
                    choised_position = choised_str;
                    choised_flag = "position";

                    //MessageBox.Show(choised_position);
                    using (UpdateSubDataDepartmentForm form = new UpdateSubDataDepartmentForm())
                    {
                        form.department_name = dpt_name;
                        form.old_name = choised_position;
                        form.flag = choised_flag;
                        form.ShowDialog(this);
                    }
                }
                else { MessageBox.Show("Необходимо выбрать изменяемую должность!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (NameTbleBeChanged == "cabinet")
            {
                if (listView_Cabinets.SelectedItems.Count > 0)
                {
                    //get data of choised string into listview

                    string choised_str = listView_Cabinets.FocusedItem.SubItems[0].Text;
                    choised_cabinet = choised_str;
                    choised_flag = "cabinet";

                    //MessageBox.Show(choised_cabinet);
                    using (UpdateSubDataDepartmentForm form = new UpdateSubDataDepartmentForm())
                    {

                        form.department_name = dpt_name;
                        form.old_name = choised_cabinet;
                        form.flag = choised_flag;
                        form.ShowDialog(this);
                    }
                }
                else { MessageBox.Show("Необходимо выбрать изменяемый кабинет!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            

        }

        //Функция добавляющая новые должности/кабинеты к выбранному отделу
        public void startAddSubDptData(string NameTbleBeChanged)
        {
            //Подготовка данных к ПРОЦЕДУРЕ - AddSubDataDepartment
            string dpt_name = comboBox_choise.Text; //Открытый отдел (department_name в параметре процедуры)
            string choised_flag = "";               //Что добавляем кабинет или должность (flag в параметре процедуры)

            if (NameTbleBeChanged == "position")
            {
                choised_flag = "position";

                using (AddSubDataDepartmentForm form = new AddSubDataDepartmentForm())
                {
                    form.department_name = dpt_name;
                    form.flag = choised_flag;
                    form.ShowDialog(this);
                }
            }
            else if (NameTbleBeChanged == "cabinet")
            {
                choised_flag = "cabinet";

                using (AddSubDataDepartmentForm form = new AddSubDataDepartmentForm())
                {

                    form.department_name = dpt_name;
                    form.flag = choised_flag;
                    form.ShowDialog(this);
                }
            }
        }

        //Функция удаляющая выбранную должность/кабинет, по открытому отделу. (Удаляются в т.ч и сотрудники связанные с
        //должностью или кабинетом соответственно)
        private void execDeleteSubDataDepartment(string d_name, string v, string f)
        {
            string t_str1 = (f == "cabinet" ? "кабинет" : "должность");
            string t_str2 = (f == "cabinet" ? "кабинетом" : "должностью");
            if (MessageBox.Show("Вы уверены что хотите удалить " + t_str1 + " из отдела " + '"' + d_name +'"' + "?\n" + "Информация о сотрудниках, связанных с " + t_str2 + " так же будет удалена!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlDataReader dataReader = null;

                try
                {
                    string procName = "DeleteSubDataDepartment";

                    //Need to get cabinet
                    SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = d_name;
                    sqlCommand.Parameters.Add("@value", SqlDbType.NVarChar).Value = v;
                    sqlCommand.Parameters.Add("@flag", SqlDbType.NVarChar).Value = f;

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
            }

        }

        //Функция подготовки к удалению
        public void startDeleteSubDptData(string NameTbleBeChanged)
        {
            //Подготовка данных к ПРОЦЕДУРЕ - DeleteSubDataDepartment
            string dpt_name = comboBox_choise.Text; //Открытый отдел (department_name в параметре процедуры)
            string value = "";                      //Удаляемое значение (value в параметре процедуры)
            string choised_flag = "";               //Что удаляем кабинет или должность (flag в параметре процедуры)

            if (NameTbleBeChanged == "position")
            {
                if (listView_Positions.SelectedItems.Count > 0)
                {
                    //get data of choised string into listview
                    string choised_str = listView_Positions.FocusedItem.SubItems[0].Text;
                    value = choised_str;
                    choised_flag = "position";

                    execDeleteSubDataDepartment(dpt_name, value, choised_flag);
                }
                else { MessageBox.Show("Необходимо выбрать удаляемую должность!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (NameTbleBeChanged == "cabinet")
            {
                if (listView_Cabinets.SelectedItems.Count > 0)
                {
                    //get data of choised string into listview

                    string choised_str = listView_Cabinets.FocusedItem.SubItems[0].Text;
                    value = choised_str;
                    choised_flag = "cabinet";

                    execDeleteSubDataDepartment(dpt_name, value, choised_flag);
                }
                else { MessageBox.Show("Необходимо выбрать удаляемый кабинет!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        //==========================================



        private void DepartmentEditForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();

            updateLV_Positions();
            updateLV_Cabinets();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //=============================POSITIONS============================
        //=============================BUTTONS==============================

        private void listView_Positions_DoubleClick(object sender, EventArgs e)
        {
            startUpdateForm("position");
            updateLV_Positions();
        }

        private void Btn_Edit_Position_Click(object sender, EventArgs e)
        {
            startUpdateForm("position");
            updateLV_Positions();
        }


        private void Btn_Delete_Position_Click(object sender, EventArgs e)
        {
            startDeleteSubDptData("position");
            updateLV_Positions();
        }

        private void Btn_Add_Position_Click(object sender, EventArgs e)
        {
            startAddSubDptData("position");
            updateLV_Positions();
        }

        //=============================CABINET==============================
        //=============================BUTTONS==============================

        private void listView_Cabinets_DoubleClick(object sender, EventArgs e)
        {
            startUpdateForm("cabinet");
            updateLV_Cabinets();
        }

        private void Btn_Edit_Cabinet_Click(object sender, EventArgs e)
        {
            startUpdateForm("cabinet");
            updateLV_Cabinets();
        }

        private void Btn_Delete_Cabinet_Click(object sender, EventArgs e)
        {
            startDeleteSubDptData("cabinet");
            updateLV_Cabinets();
        }

        private void Btn_Add_Cabinet_Click(object sender, EventArgs e)
        {
            startAddSubDptData("cabinet");
            updateLV_Cabinets();
        }
    }
}
