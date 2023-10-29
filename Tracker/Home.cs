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
    public partial class Home : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        string ID = "0";
        string ProjectId = "0";
        string TaskId = "0";
        int UserGroupId = 0;
        public static int _ProjectId = 0;
        public static int _TaskId = 0;
   
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
            GroupProjectProgerss.Visible = false;
            groupBox2.Visible = true;
            //Lblp1.Visible = false;
            //Lbld.Visible = false;
            //LblProjectDate.Visible = false;
            //lblProjectName.Visible = false;
            FillData();
          //  groupBox1.Visible = false;
        }

        //protected void BindCountry()
        //{
        //    DataSet dsBrand = ObjUserDal.FetchData(ObjUser);
        //    CmbCountry.DataSource = dsBrand.Tables[1];
        //    CmbCountry.DisplayMember = "Status";
        //    CmbCountry.ValueMember = "StatusId";
        //    //CmbCountry.Text = "--Select--";
        //}
        protected DataTable FillData()
        {
            
            DataSet dsComypan = ObjUserDal.FetchData(ObjUser);
            DataTable dt = dsComypan.Tables[0];
            if (dsComypan.Tables[0].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridCustomer.DataSource = dsComypan.Tables[0];

               // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridCustomer.Columns["Id"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 18.75F, FontStyle.Bold);
                DataGridCustomer.RowTemplate.Resizable = DataGridViewTriState.True;
                DataGridCustomer.RowTemplate.Height = 60;
                DataGridCustomer.RowTemplate.Height = 35;
                DataGridCustomer.EnableHeadersVisualStyles = false;
                DataGridCustomer.RowHeadersVisible = false;
                DataGridCustomer.BackgroundColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                //DataGridCustomer.DataSource = null;
                //DataGridCustomer.DataBind();
            }

            return dt;
        }

        private void AddWButtonColumns(DataGridView grd)
        {
            try
            {

                if (!grd.Columns.Contains("Select"))
                {
                    DataGridViewButtonColumn btnColEdit = new DataGridViewButtonColumn();
                    btnColEdit.Name = "Select";
                    btnColEdit.Text = "Select";
                    btnColEdit.HeaderText = "Select";
                    btnColEdit.UseColumnTextForButtonValue = true;
                    grd.Columns.Add(btnColEdit);
                    grd.Columns["Select"].Width = 70;
                }
                //if (!grd.Columns.Contains("Delete"))
                //{
                //    DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
                //    btnColDelete.Name = "Delete";
                //    btnColDelete.Text = "Delete";
                //    btnColDelete.HeaderText = "Delete";
                //    btnColDelete.UseColumnTextForButtonValue = true;
                //    grd.Columns.Add(btnColDelete);
                //    grd.Columns["Delete"].Width = 70;
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int UserGroupId = FrmLogin._RolId;

                if (e.ColumnIndex == DataGridCustomer.Columns["Project"].Index)
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    GroupProjectProgerss.Visible = true;
                    groupBox2.Visible = false;

                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    FillProjectProgressData(Convert.ToInt32(ID));
                }
                else
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    GroupProjectProgerss.Visible = true;
                    groupBox2.Visible = false;
                    FillProjectProgressData(Convert.ToInt32(ID));
                }



                //if (e.ColumnIndex == DataGridCustomer.Columns["Pre_Adm"].Index)
                //{
                //    if (UserGroupId == 1)
                //    {
                //        ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                //        string message = "Do you want to Approve?" + " " + Name;
                //        string title = "Approve Record";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            ObjUser.UserId = Convert.ToInt32(ID);
                //            int pkID = ObjUserDal.PreAdminProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //    else
                //    {
                //        string message = "you are not Authorised. " + " " + Name;
                //        string title = "you are not Authorised.";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            //ObjUser.UserId = Convert.ToInt32(ID);
                //            //int pkID = ObjUserDal.DeleteProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //}
                //if (e.ColumnIndex == DataGridCustomer.Columns["Post_Adm"].Index)
                //{
                //    if (UserGroupId == 2)
                //    {
                //        ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                //        string message = "Do you want to Approve?" + " ";
                //        string title = "Approve Record";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            ObjUser.UserId = Convert.ToInt32(ID);
                //            int pkID = ObjUserDal.PostAdminProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //    else
                //    {
                //        string message = "you are not Authorised. " + " " ;
                //        string title = "you are not Authorised.";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            //ObjUser.UserId = Convert.ToInt32(ID);
                //            //int pkID = ObjUserDal.DeleteProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //}
                //if (e.ColumnIndex == DataGridCustomer.Columns["Exec_Adm"].Index)
                //{
                //    if (UserGroupId == 3)
                //    {
                //        ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                //        string message = "Do you want to Approve?" + " ";
                //        string title = "Approve Record";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            ObjUser.UserId = Convert.ToInt32(ID);
                //            int pkID = ObjUserDal.ExcAdminProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //    else
                //    {
                //        string message = "you are not Authorised. " + " ";
                //        string title = "you are not Authorised.";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //        if (result == DialogResult.Yes)
                //        {
                //            //ObjUser.UserId = Convert.ToInt32(ID);
                //            //int pkID = ObjUserDal.DeleteProject(ObjUser);
                //            FillData();
                //        }
                //    }
                //}
                //else
                //{
                //    FillData();
                //}


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;

            //if (BtnSave.Text == "Save")
            //{
            //    if (Update() == true)
            //    {
            //        MessageBox.Show("Data saved successfully");
            //        this.DialogResult = DialogResult.OK;
            //       // DataGridCustomer.DataSource = null;
            //        DataGridCustomer.DataSource = null;
            //        FillData();
            //        TxtTask.Text = "";
            //        CmbCountry.SelectedIndex = 0;

            //        groupBox1.Visible = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error");
            //    }
            //}
            //else
            //{
            //    Update();
            //    //MessageBox.Show("Data updated successfully.");
            //    //// Reset();

            //    //this.DialogResult = DialogResult.OK;
            //    //DataGridCustomer.DataSource = null;
            //    DataGridCustomer.DataSource = null;
            //    DataGridCustomer.Rows.Clear();
            //    DataGridCustomer.Refresh();
            //    //DataGridCustomer.Rows.Clear();
            //    //DataGridCustomer.Refresh();
            //    FillData();
            //    TxtTask.Text = "";
            //    CmbCountry.SelectedIndex = 0;

            //    groupBox1.Visible = false;
            //}

        }

        protected bool Update()
        {
            bool flag = false;
            ObjUser.UserId = Convert.ToInt32(ID);
         //   ObjUser.StatusId= Convert.ToInt32(CmbCountry.SelectedValue);
           
            int pkID = ObjUserDal.UpdateUser(ObjUser);
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

        private void DataGridCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //string i = DataGridCustomer.Columns["StatusId"].ToString() ;
            //if (e.ColumnIndex==1 & e.Value!=null)
            //{
                
            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Pre Adm Plg.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;

               
            //}
            //if (e.ColumnIndex == 3 & e.Value != null)
            //{

            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Post Adm Plg.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;


            //}
     
         
            //if (e.ColumnIndex == 5 & e.Value != null)
            //{

            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Exec.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;


            //}
        }

        //private void BtnSave_Click(object sender, EventArgs e)
        //{

        //}

        protected DataTable FillProjectProgressData( int Id)
        {
            ObjUser.UserId = Id;
            DataSet ds = ObjUserDal.FetchDataId(ObjUser);
            DataTable dt = ds.Tables[0];
            if (ds.Tables[0].Rows.Count > 0)
            {
                //lblProjectName.Text = Convert.ToString(ds.Tables[0].Rows[0]["Task"]); ;
                //LblProjectDate.Text = Convert.ToString(ds.Tables[0].Rows[0]["Date"]);
                ////AddWButtonColumns(DataGridCustomer);
                //DataGridCustomer.DataSource = ds.Tables[0];

                //// DataGridCustomer.Columns["StatusId"].Visible = false;
                //DataGridCustomer.Columns["Id"].Visible = false;
                ////DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                ////DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                ////DataGridCustomer.Columns["isExcute"].Visible = false;
                //DataGridCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                ////DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                //// DataGridVenderDetails.ColumnHeadersHeight = 1000;
                //DataGridCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                //DataGridCustomer.EnableHeadersVisualStyles = false;
                //DataGridCustomer.RowHeadersVisible = false;
                //DataGridCustomer.BackgroundColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                //lblProjectName.Text = "" ;
                //LblProjectDate.Text = "";
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
               
                DataGridProgress.DataSource = ds.Tables[1];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridProgress.Columns["ProgressId"].Visible = false;
                DataGridProgress.Columns["ProjectId"].Visible = false;
                DataGridProgress.Columns["TaskId"].Visible = false;
                DataGridProgress.Columns["isPreAdmin"].Visible = false;
                DataGridProgress.Columns["isPostAdmin"].Visible = false;
                DataGridProgress.Columns["isExcute"].Visible = false;
                DataGridProgress.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridProgress.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 18.75F, FontStyle.Bold);
                DataGridProgress.RowTemplate.Resizable = DataGridViewTriState.True;
                DataGridProgress.RowTemplate.Height = 60;
                DataGridProgress.EnableHeadersVisualStyles = false;
                DataGridProgress.RowHeadersVisible = false;
                DataGridProgress.BackgroundColor = Color.White;
              //  DataGridProgress.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                //lblProjectName.Text = "";
                //LblProjectDate.Text = "";
            }


            return dt;
        }

        private void DataGridProgress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UserGroupId = FrmLogin._RolId;
            if(UserGroupId==1)
            { 
            if (e.ColumnIndex == DataGridProgress.Columns["Pre_Adm"].Index)
            {
                //if (UserGroupId == 1)
                //{
                    ProjectId = DataGridProgress.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
                    TaskId = DataGridProgress.Rows[e.RowIndex].Cells["TaskId"].Value.ToString();
                    _ProjectId = Convert.ToInt32(ProjectId);
                    _TaskId = Convert.ToInt32(TaskId);


                    //   FrmWorkDetails frmObj = new FrmWorkDetails();
                    FrmPhaseTrack frmObj = new FrmPhaseTrack();

                    //   f.btnr

                    //groupBox2.Visible = false;
                    //GroupProjectProgerss.Visible = false;

                    ////FrmUpdateTask frmObj = new FrmUpdateTask();
                    //FrmPhaseTrack frmObj = new FrmPhaseTrack();
                    frmObj.WindowState = FormWindowState.Maximized;
                    frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    frmObj.StartPosition = FormStartPosition.CenterScreen;


                    frmObj.ShowDialog();
                    //if (frmObj.DialogResult == DialogResult.OK)
                    //{
                    //    FillProjectProgressData(Convert.ToInt32(ID));
                    //}

              //  }
                //else
                //{
                //    string message = "you are not Authorised. " + " ";
                //    string title = "you are not Authorised.";
                //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //}
            }
            if (e.ColumnIndex == DataGridProgress.Columns["Post_Adm"].Index)
            {

                ProjectId = DataGridProgress.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
                TaskId = DataGridProgress.Rows[e.RowIndex].Cells["TaskId"].Value.ToString();
                _ProjectId = Convert.ToInt32(ProjectId);
                _TaskId = Convert.ToInt32(TaskId);


                //   FrmWorkDetails frmObj = new FrmWorkDetails();
                FrmPhaseTrackAdmin frmObj = new FrmPhaseTrackAdmin();

                //   f.btnr

                //groupBox2.Visible = false;
                //GroupProjectProgerss.Visible = false;

                ////FrmUpdateTask frmObj = new FrmUpdateTask();
                //FrmPhaseTrack frmObj = new FrmPhaseTrack();
                frmObj.WindowState = FormWindowState.Maximized;
                frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                frmObj.StartPosition = FormStartPosition.CenterScreen;


                frmObj.ShowDialog();
                //if (UserGroupId == 2)
                //{
                //    Boolean isPreActive = Convert.ToBoolean(DataGridProgress.Rows[e.RowIndex].Cells["isPreAdmin"].Value.ToString());
                //    //  Boolean isPostActive = Convert.ToBoolean(DataGridProgress.Rows[e.RowIndex].Cells["isPostAdmin"].Value.ToString());
                //    if (isPreActive == true)
                //    {
                //        ProjectId = DataGridProgress.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
                //        TaskId = DataGridProgress.Rows[e.RowIndex].Cells["TaskId"].Value.ToString();
                //        _ProjectId = Convert.ToInt32(ProjectId);
                //        _TaskId = Convert.ToInt32(TaskId);
                //        FrmUpdateTask frmObj = new FrmUpdateTask();
                //        frmObj.WindowState = FormWindowState.Normal;
                //        frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                //        frmObj.StartPosition = FormStartPosition.CenterScreen;


                //        frmObj.ShowDialog();
                //        if (frmObj.DialogResult == DialogResult.OK)
                //        {
                //            FillProjectProgressData(Convert.ToInt32(ID));
                //        }
                //    }
                //    else
                //    {
                //        string message = "First Checked Pre_Admin!!" + " ";
                //        string title = "First Checked Pre_Admin.";
                //        MessageBoxButtons buttons = MessageBoxButtons.OK;

                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //    }

                //}
                //else
                //{
                //    string message = "you are not Authorised. " + " ";
                //    string title = "you are not Authorised.";
                //    MessageBoxButtons buttons = MessageBoxButtons.OK;

                //    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                //}
            }
            if (e.ColumnIndex == DataGridProgress.Columns["Exec_Adm"].Index)
            {
                if (UserGroupId == 3)
                {

                  
                        Boolean isPreActive = Convert.ToBoolean(DataGridProgress.Rows[e.RowIndex].Cells["isPreAdmin"].Value.ToString());
                    Boolean isPostActive = Convert.ToBoolean(DataGridProgress.Rows[e.RowIndex].Cells["isPostAdmin"].Value.ToString());
                    if (isPreActive == true && isPostActive == true)
                    {
                        ProjectId = DataGridProgress.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
                        TaskId = DataGridProgress.Rows[e.RowIndex].Cells["TaskId"].Value.ToString();
                        _ProjectId = Convert.ToInt32(ProjectId);
                        _TaskId = Convert.ToInt32(TaskId);
                        FrmUpdateTask frmObj = new FrmUpdateTask();
                        frmObj.WindowState = FormWindowState.Normal;
                        frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                        frmObj.StartPosition = FormStartPosition.CenterScreen;


                        frmObj.ShowDialog();
                        if (frmObj.DialogResult == DialogResult.OK)
                        {
                            FillProjectProgressData(Convert.ToInt32(ID));
                        }
                    }
                    else
                    {
                        string message = "First Checked Pre_Admin & Post_Admin!!" + " ";
                        string title = "First Checked Pre_Admin.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    string message = "you are not Authorised. " + " ";
                    string title = "you are not Authorised.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FillProjectProgressData(Convert.ToInt32(ID));
            }
            }
            else
            {
                string message = "Please Connect with Admin!!" + " ";
                string title = "you are not authorized .";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }

        }

        private void DataGridProgress_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         
            e.CellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            //e.rowt.wi = new Font("Tahoma", 18.75F, FontStyle.Bold);
            // string i = DataGridCustomer.Columns["StatusId"].ToString();
            if (e.ColumnIndex == 2 & e.Value != null)
            {

                //int StatusId = Convert.ToInt32(e.Value);

                if (Convert.ToString(e.Value) == "Pre Adm Plg.")
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = Color.Green;

                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == 4 & e.Value != null)
            {

                //int StatusId = Convert.ToInt32(e.Value);

                if (Convert.ToString(e.Value) == "Post Adm Plg.")
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;

            }


            if (e.ColumnIndex == 6 & e.Value != null)
            {

                //int StatusId = Convert.ToInt32(e.Value);

                if (Convert.ToString(e.Value) == "Exec.")
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = Color.Green;

                e.CellStyle.ForeColor = Color.White;
            }

        }

        private void DataGridProgress_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridProgress.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
