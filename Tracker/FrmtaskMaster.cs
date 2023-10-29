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
    public partial class FrmtaskMaster : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        string ID = "0";
        public FrmtaskMaster()
        {
            InitializeComponent();
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            FillData();
        }

        protected DataTable FillData()
        {
            DataSet dsComypan = ObjUserDal.FetchData(ObjUser);
            DataTable dt = dsComypan.Tables[0];
            if (dsComypan.Tables[6].Rows.Count > 0)
            {
                DataGridCustomer.DataSource = dsComypan.Tables[6];
              
                DataGridCustomer.Columns["TskId"].Visible = false;
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
                    TxtTask.Text = "";
                    ID = "0";



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
                TxtTask.Text = "";
                ID = "0";
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

        protected bool Update()
        {
            bool flag = false;
            ObjUser.UserId = Convert.ToInt32(ID);
            ObjUser.ProjectName =TxtTask.Text.Trim();
           /// ObjUser.Date = Date.Value;
            int pkID = ObjUserDal.UpdateTaskMaster1(ObjUser);
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
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["TskId"].Value.ToString();

                    ObjUser.UserId = Convert.ToInt32(ID);

                    DataSet ds = ObjUserDal.FetchDataId(ObjUser);
                    if (ds.Tables[16].Rows.Count > 0)
                    {
                        TxtTask.Text = Convert.ToString(ds.Tables[16].Rows[0]["Task"]);
                       // Date.Text = Convert.ToString(ds.Tables[0].Rows[0]["Date"]);
                        BtnSave.Text = "Update";
                    }
                }

                if (e.ColumnIndex == DataGridCustomer.Columns["Delete"].Index)
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["TskId"].Value.ToString();

                    string message = "Do you want to Delete this Record?" + " " + Name;
                    string title = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ObjUser.UserId = Convert.ToInt32(ID);
                        int pkID = ObjUserDal.DeleteTaskDetails1(ObjUser);
                        FillData();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmtaskMaster_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
