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
    public partial class DepartmentsInfoForm : Form
    {
        private SqlConnection sqlConnection = null;

        public DepartmentsInfoForm()
        {
            InitializeComponent();
        }

        // ------>>>> FUNCTIONS <<<<<<-------------
        private void updateListView()
        {
            listView_DepartmentsInfoForm.Items.Clear();

            SqlDataReader dataReader = null;

            try
            {
                string procName = "GetAllDepartments";

                SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                dataReader = sqlCommand.ExecuteReader();

                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    {   Convert.ToString(dataReader["id"]),
                        Convert.ToString(dataReader["name"])
                    });


                    listView_DepartmentsInfoForm.Items.Add(item);
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

        public void startUpdateForm()
        {
            if (listView_DepartmentsInfoForm.SelectedItems.Count > 0)
            {
                //get data of choised string into listview
                string choised_str = listView_DepartmentsInfoForm.FocusedItem.SubItems[1].Text;
                //MessageBox.Show(choised_str);
                using (DepartmentEditForm form = new DepartmentEditForm())
                {
                    form.TextValue = choised_str;
                    form.ShowDialog(this);
                }
            }
            else { MessageBox.Show("Необходимо выбрать отдел!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }

        //Функция, полностью удаляющая отдел. (в т.ч и сотрудников,должностей,кабинетов связанных с удаляемым отделом)
        private void execDeleteAppDataDepartment(string choised_department)
        {
            string dpt_name = string.Empty;
            dpt_name = choised_department;

            if (MessageBox.Show("Вы уверены что хотите удалить отдел " + '"' + dpt_name + '"' + "?\n" + "Вся информация связанная с данным отделом так же будет удалена!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlDataReader dataReader = null;

                try
                {
                    string procName = "DeleteAllDepartmentData";

                    //Need to get cabinet
                    SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add("@department_name", SqlDbType.NVarChar).Value = dpt_name;
                   
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
        
        //==========================================

        private void DepartmentsInfoForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cS_db"].ConnectionString);

            //Open connection to database 
            sqlConnection.Open();

            updateListView();
        }

        private void TSBtn_Create_Click(object sender, EventArgs e)
        {
            using (DepartmentCreateForm form = new DepartmentCreateForm())
            {
                form.ShowDialog(this);
            }

            updateListView();
        }

        private void TSBtn_Edit_Click(object sender, EventArgs e)
        {
            startUpdateForm();
        }

        private void TSBtn_Update_Click(object sender, EventArgs e)
        {
            updateListView();
        }

        private void listView_DepartmentsInfoForm_DoubleClick(object sender, EventArgs e)
        {
            startUpdateForm();
        }

        private void TSBtn_Delete_Click(object sender, EventArgs e)
        {
            string choised_department = string.Empty;
            if (listView_DepartmentsInfoForm.SelectedItems.Count > 0)
            {
                //get data of choised string into listview
                string choised_str = listView_DepartmentsInfoForm.FocusedItem.SubItems[1].Text;
                choised_department = choised_str;

                //MessageBox.Show(choised_department);
                execDeleteAppDataDepartment(choised_department);
            }
            else { MessageBox.Show("Необходимо выбрать удаляемый отдел!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            updateListView();
        }
    }
}
