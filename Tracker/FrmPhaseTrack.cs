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
    public partial class FrmPhaseTrack : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        string ID = "0";
        string ProjectId = "0";
        string TaskId = "0";
        int UserGroupId = 0;
        string WorkId = "0";
        public static int _ProjectId = 0;
        public static int _TaskId = 0;
        public static int _WorkId = 0;
       // public static int _ModeId = 0;
        public FrmPhaseTrack()
        {
            InitializeComponent();
        }

        private void FrmPhaseTrack_Load(object sender, EventArgs e)
        {
            //GroupBoxPhase1.Visible = true;
            //Lblp1.Visible = false;
            //Lbld.Visible = false;
            //LblProjectDate.Visible = false;
            //lblProjectName.Visible = false;
            _ProjectId = Home._ProjectId;
            FillData(Convert.ToInt32(_ProjectId));
        }
        protected DataTable FillData(int ProjectId)
        {
            ObjUser.UserId = ProjectId;
            ObjUser.TaskId = Convert.ToInt32(Home._TaskId);
            DataSet dsComypan = ObjUserDal.FetchDataId(ObjUser);
            DataTable dt = dsComypan.Tables[0];
            if (dsComypan.Tables[3].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase1.DataSource = dsComypan.Tables[3];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase1.Columns["StatusId"].Visible = false;
                DataGridPhase1.Columns["ProjectId"].Visible = false;
                DataGridPhase1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase1.EnableHeadersVisualStyles = false;
                DataGridPhase1.RowHeadersVisible = false;
                DataGridPhase1.BackgroundColor = Color.White;
                DataGridPhase1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                //DataGridCustomer.DataSource = null;
                //DataGridCustomer.DataBind();
            }
            if (dsComypan.Tables[4].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase1_1.DataSource = dsComypan.Tables[4];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase1_1.Columns["StatusId"].Visible = false;
                DataGridPhase1_1.Columns["ProjectId"].Visible = false;
                DataGridPhase1_1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase1_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase1_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase1_1.EnableHeadersVisualStyles = false;
                DataGridPhase1_1.RowHeadersVisible = false;
                DataGridPhase1_1.BackgroundColor = Color.White;
                DataGridPhase1_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[5].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase2.DataSource = dsComypan.Tables[5];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase2.Columns["StatusId"].Visible = false;
                DataGridPhase2.Columns["ProjectId"].Visible = false;
                DataGridPhase2.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase2.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase2.EnableHeadersVisualStyles = false;
                DataGridPhase2.RowHeadersVisible = false;
                DataGridPhase2.BackgroundColor = Color.White;
                DataGridPhase2.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[6].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase2_1.DataSource = dsComypan.Tables[6];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase2_1.Columns["StatusId"].Visible = false;
                DataGridPhase2_1.Columns["ProjectId"].Visible = false;
                DataGridPhase2_1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase2_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase2_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase2_1.EnableHeadersVisualStyles = false;
                DataGridPhase2_1.RowHeadersVisible = false;
                DataGridPhase2_1.BackgroundColor = Color.White;
                DataGridPhase2_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[7].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase3.DataSource = dsComypan.Tables[7];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase3.Columns["StatusId"].Visible = false;
                DataGridPhase3.Columns["ProjectId"].Visible = false;
                DataGridPhase3.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase3.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase3.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase3.EnableHeadersVisualStyles = false;
                DataGridPhase3.RowHeadersVisible = false;
                DataGridPhase3.BackgroundColor = Color.White;
                DataGridPhase3.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[8].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase3_1.DataSource = dsComypan.Tables[8];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase3_1.Columns["StatusId"].Visible = false;
                DataGridPhase3_1.Columns["ProjectId"].Visible = false;
                DataGridPhase3_1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase3_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase3_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase3_1.EnableHeadersVisualStyles = false;
                DataGridPhase3_1.RowHeadersVisible = false;
                DataGridPhase3_1.BackgroundColor = Color.White;
                DataGridPhase3_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[9].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase4.DataSource = dsComypan.Tables[9];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase4.Columns["StatusId"].Visible = false;
                DataGridPhase4.Columns["ProjectId"].Visible = false;
                DataGridPhase4.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase4.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase4.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
                DataGridPhase4.EnableHeadersVisualStyles = false;
                DataGridPhase4.RowHeadersVisible = false;
                DataGridPhase4.BackgroundColor = Color.White;
                DataGridPhase4.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            if (dsComypan.Tables[10].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase4_1.DataSource = dsComypan.Tables[10];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase4_1.Columns["StatusId"].Visible = false;
                DataGridPhase4_1.Columns["ProjectId"].Visible = false;
                DataGridPhase4_1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase4_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase4_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
             
             
                DataGridPhase4_1.EnableHeadersVisualStyles = false;
                DataGridPhase4_1.RowHeadersVisible = false;
                DataGridPhase4_1.BackgroundColor = Color.White;
                DataGridPhase4_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }

            return dt;
        }

        private void DataGridPhase1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

        }

        private void DataGridPhase1_1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase1_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase1_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase1_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase1_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase1_1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase1_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase1_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

        }

        private void DataGridPhase2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase2.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase2.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase2.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase2_1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase2_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase2_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase2_1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase3.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase3.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase3.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase3_1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase3_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase3_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase3_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase3_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase3_1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase3_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase3_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase4_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase4_1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void BtnPhase1_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage2;
        }

        private void BtnPreviewPhase1_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage1;
        }

        private void BtnPhase2_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage3;
        }

        private void BtnPrePhase2_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnPhase4_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage4;
        }

        private void btnPrephase3_Click(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage3;
        }

        private void DataGridPhase1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            FrmPhaseTrackAdmin._ModeId = 0;
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase1_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase1_1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase1_1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase2.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase2.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase2_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase2_1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase2_1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase3.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase3.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase3_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase3_1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase3_1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase4.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase4.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase4_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase4_1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase4_1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmPhaseTrackAdmin._ModeId = 0;
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase1_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridPhase3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrephase3_Click_1(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage3;
        }

        private void btnPhase4_Click_1(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage4;
        }

        private void BtnPrePhase2_Click_1(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage2;
        }

        private void BtnPhase2_Click_1(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage3;
        }

        private void BtnPreviewPhase1_Click_1(object sender, EventArgs e)
        {
            FillData(Convert.ToInt32(_ProjectId));
            tabControl1.SelectedTab = tabPage1;
        }

        private void DataGridPhase1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase1.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void DataGridPhase1_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase1_1.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void DataGridPhase2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase2.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void DataGridPhase2_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase2_1.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void DataGridPhase3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase3.Rows)
            {
                x.MinimumHeight = 50;
            }
        }

        private void DataGridPhase3_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow x in DataGridPhase3_1.Rows)
            {
                x.MinimumHeight = 40;
            }
        }

        private void DataGridPhase4_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void DataGridPhase4_1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void DataGridPhase4_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void DataGridPhase4_1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void DataGridPhase4_RowPrePaint_2(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase4.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase4.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase4_1_RowPrePaint_2(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase4_1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase4_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase4_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase4.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase4.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }

        private void DataGridPhase4_1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ProjectId = DataGridPhase4_1.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString();
            WorkId = DataGridPhase4_1.Rows[e.RowIndex].Cells["WorkId"].Value.ToString();
            _ProjectId = Convert.ToInt32(ProjectId);
            _WorkId = Convert.ToInt32(WorkId);
            FrmUpdateTask frmObj = new FrmUpdateTask();
            frmObj.WindowState = FormWindowState.Normal;
            frmObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frmObj.StartPosition = FormStartPosition.CenterScreen;


            frmObj.ShowDialog();
            if (frmObj.DialogResult == DialogResult.OK)
            {
                FillData(Convert.ToInt32(_ProjectId));
            }
        }
    }
}
