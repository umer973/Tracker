using Dal;
using DEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class FrmUser : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        ClassEncDecPassword ObjEncDec = new ClassEncDecPassword();
        string ID = "0";
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            FillData();
            BindStatus();
        }

        protected void BindStatus()
        {
            DataSet dsBrand = ObjUserDal.FetchData(ObjUser);
            cmdRole.DataSource = dsBrand.Tables[4];
            cmdRole.DisplayMember = "UserGroupName";
            cmdRole.ValueMember = "UserGroupId";
            //CmbCountry.Text = "--Select--";
        }

        protected DataTable FillData()
        {
            DataSet dsComypan = ObjUserDal.FetchData(ObjUser);
            DataTable dt = dsComypan.Tables[0];
            if (dsComypan.Tables[5].Rows.Count > 0)
            {
                DataGridCustomer.DataSource = dsComypan.Tables[5];
              
                DataGridCustomer.Columns["Id"].Visible = false;
                DataGridCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                DataGridCustomer.EnableHeadersVisualStyles = false;
                DataGridCustomer.RowHeadersVisible = false;
                DataGridCustomer.BackgroundColor = Color.White;
                AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                //dataGridView1.DataSource = null;
                //dataGridView1.DataBind();
            }

            return dt;
        }
        private void AddWButtonColumns(DataGridView grd)
        {
            try
            {

                if (!grd.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn btnColEdit = new DataGridViewButtonColumn();
                    btnColEdit.Name = "Edit";
                    btnColEdit.Text = "Edit";
                    btnColEdit.HeaderText = "Edit";
                    btnColEdit.UseColumnTextForButtonValue = true;
                    grd.Columns.Add(btnColEdit);
                    grd.Columns["Edit"].Width = 150;
                }
                if (!grd.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
                    btnColDelete.Name = "Delete";
                    btnColDelete.Text = "Delete";
                    btnColDelete.HeaderText = "Delete";
                    btnColDelete.UseColumnTextForButtonValue = true;
                    grd.Columns.Add(btnColDelete);
                    grd.Columns["Delete"].Width = 150;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if((isValid())==true)
            { 
            if (BtnSave.Text == "Save")
            {
                if (Update() == true)
                {
                    FillData();
                    //MessageBox.Show("Data saved successfully");
                    //this.DialogResult = DialogResult.OK;
                    //// DataGridCustomer.DataSource = null;
                    //DataGridCustomer.DataSource = null;
                    //FillData();
                    TxtUserName.Text = "";
                    TxtConfirmPassword.Text = "";
                    TxtPassword.Text = "";
                    ID = "0";
                    BindStatus();



                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                Update();
                FillData();
                TxtUserName.Text = "";
                TxtConfirmPassword.Text = "";
                TxtPassword.Text = "";
                ID = "0";
                BindStatus();
                //MessageBox.Show("Data updated successfully.");
                //// Reset();

                //this.DialogResult = DialogResult.OK;
                //DataGridCustomer.DataSource = null;
                //DataGridCustomer.DataSource = null;
                //DataGridCustomer.Rows.Clear();
                //DataGridCustomer.Refresh();
                //DataGridCustomer.Rows.Clear();
                //DataGridCustomer.Refresh();


            }
            }
        }

        protected bool isValid()
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {

                TxtUserName.Focus();
               
                MessageBox.Show("Enter User Name");
                return false;
                //  errorProviderApp.SetError(textBoxName, "Name should not be left blank!");
            }
            return flag;
        
        }


            protected bool Update()
           {
            bool flag = false;
            ObjUser.UserId = Convert.ToInt32(ID);
            ObjUser.ProjectName =TxtUserName.Text.Trim();
            ObjUser.Date = Date.Value;
            string strpassword = ObjEncDec.encrypt(TxtPassword.Text.Trim());
           ObjUser.Password = strpassword;
            ObjUser.ConfirmPassword = TxtConfirmPassword.Text;
            ObjUser.UserGroupId = Convert.ToInt32(cmdRole.SelectedValue);
            int pkID = ObjUserDal.InsertUser(ObjUser);
            if (pkID > 0)
            {

                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void DataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == DataGridCustomer.Columns["Edit"].Index)
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    ObjUser.UserId = Convert.ToInt32(ID);

                    DataSet ds = ObjUserDal.FetchDataId(ObjUser);
                    if (ds.Tables[15].Rows.Count > 0)
                    {

                        TxtUserName.Text = Convert.ToString(ds.Tables[15].Rows[0]["UserName"]);
                        //Date.Text = Convert.ToString(ds.Tables[15].Rows[0]["date"]);
                        cmdRole.SelectedValue = Convert.ToString(ds.Tables[15].Rows[0]["UserGroupID"]);
                        BtnSave.Text = "Update";
                    }
                }

                if (e.ColumnIndex == DataGridCustomer.Columns["Delete"].Index)
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    string message = "Do you want to Delete this Record?" + " " + Name;
                    string title = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ObjUser.UserId = Convert.ToInt32(ID);
                        int pkID = ObjUserDal.DeleteProject(ObjUser);
                        FillData();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
