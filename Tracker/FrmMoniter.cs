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
    public partial class FrmMoniter : Form
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
        public FrmMoniter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        protected DataTable FillDataPhase(int ProjectId,int TaskId, int StatusId)
        {
            ObjUser.UserId = ProjectId;
            ObjUser.TaskId = TaskId;
            ObjUser.StatusId = StatusId;
            DataSet dsComypan = ObjUserDal.FetchMoniter(ObjUser);
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
                DataGridPhase1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase1.EnableHeadersVisualStyles = false;
                DataGridPhase1.RowHeadersVisible = false;
                DataGridPhase1.BackgroundColor = Color.White;
                DataGridPhase1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase1.DataSource = null;
                //DataGridPhase1.DataBind();
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
                DataGridPhase1_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase1_1.EnableHeadersVisualStyles = false;
                DataGridPhase1_1.RowHeadersVisible = false;
                DataGridPhase1_1.BackgroundColor = Color.White;
                DataGridPhase1_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase1_1.DataSource = null;
                //DataGridPhase1.DataBind();
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
                DataGridPhase2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase2.EnableHeadersVisualStyles = false;
                DataGridPhase2.RowHeadersVisible = false;
                DataGridPhase2.BackgroundColor = Color.White;
                DataGridPhase2.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase2.DataSource = null;
                //DataGridPhase1.DataBind();
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
                DataGridPhase2_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase2_1.EnableHeadersVisualStyles = false;
                DataGridPhase2_1.RowHeadersVisible = false;
                DataGridPhase2_1.BackgroundColor = Color.White;
                DataGridPhase2_1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase2_1.DataSource = null;
                //DataGridPhase1.DataBind();
            }
            if (dsComypan.Tables[7].Rows.Count > 0)
            {

                DataGridPhase3.DataSource = dsComypan.Tables[7];


                DataGridPhase3.Columns["StatusId"].Visible = false;
                DataGridPhase3.Columns["ProjectId"].Visible = false;
                DataGridPhase3.Columns["WorkId"].Visible = false;

                DataGridPhase3.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;

                DataGridPhase3.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase3.EnableHeadersVisualStyles = false;
                DataGridPhase3.RowHeadersVisible = false;
                DataGridPhase3.BackgroundColor = Color.White;
                DataGridPhase3.ForeColor = Color.White;

            }
            else
            {
                DataGridPhase3.DataSource = null;
                //DataGridPhase1.DataBind();
            }
            if (dsComypan.Tables[8].Rows.Count > 0)
            {

                DataGridPhase3_1.DataSource = dsComypan.Tables[8];


                DataGridPhase3_1.Columns["StatusId"].Visible = false;
                DataGridPhase3_1.Columns["ProjectId"].Visible = false;
                DataGridPhase3_1.Columns["WorkId"].Visible = false;

                DataGridPhase3_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;

                DataGridPhase3_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase3_1.EnableHeadersVisualStyles = false;
                DataGridPhase3_1.RowHeadersVisible = false;
                DataGridPhase3_1.BackgroundColor = Color.White;
                DataGridPhase3_1.ForeColor = Color.White;

            }
            else
            {
                DataGridPhase3_1.DataSource = null;
                //DataGridPhase1.DataBind();
            }
            if (dsComypan.Tables[9].Rows.Count > 0)
            {

                DataGridPhase4.DataSource = dsComypan.Tables[9];


                DataGridPhase4.Columns["StatusId"].Visible = false;
                DataGridPhase4.Columns["ProjectId"].Visible = false;
                DataGridPhase4.Columns["WorkId"].Visible = false;

                DataGridPhase4.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;

                DataGridPhase4.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase4.EnableHeadersVisualStyles = false;
                DataGridPhase4.RowHeadersVisible = false;
                DataGridPhase4.BackgroundColor = Color.White;
                DataGridPhase4.ForeColor = Color.White;

            }
            else
            {
                DataGridPhase4.DataSource = null;
                //DataGridPhase1.DataBind();
            }
            if (dsComypan.Tables[10].Rows.Count > 0)
            {

                DataGridPhase4_1.DataSource = dsComypan.Tables[10];

                DataGridPhase4_1.Columns["StatusId"].Visible = false;
                DataGridPhase4_1.Columns["ProjectId"].Visible = false;
                DataGridPhase4_1.Columns["WorkId"].Visible = false;

                DataGridPhase4_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;

                DataGridPhase4_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);


                DataGridPhase4_1.EnableHeadersVisualStyles = false;
                DataGridPhase4_1.RowHeadersVisible = false;
                DataGridPhase4_1.BackgroundColor = Color.White;
                DataGridPhase4_1.ForeColor = Color.White;

            }
            else
            {
                DataGridPhase4_1.DataSource = null;
                //DataGridPhase1.DataBind();
            }
            if (dsComypan.Tables[12].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase11.DataSource = dsComypan.Tables[12];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase11.Columns["StatusId"].Visible = false;
                DataGridPhase11.Columns["ProjectId"].Visible = false;
                DataGridPhase11.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase11.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase11.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase11.EnableHeadersVisualStyles = false;
                DataGridPhase11.RowHeadersVisible = false;
                DataGridPhase11.BackgroundColor = Color.White;
                DataGridPhase11.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase11.DataSource = null;
                //DataGridCustomer.DataBind();
            }

            if (dsComypan.Tables[13].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase21.DataSource = dsComypan.Tables[13];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase21.Columns["StatusId"].Visible = false;
                DataGridPhase21.Columns["ProjectId"].Visible = false;
                DataGridPhase21.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase21.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase21.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                DataGridPhase21.EnableHeadersVisualStyles = false;
                DataGridPhase21.RowHeadersVisible = false;
                DataGridPhase21.BackgroundColor = Color.White;
                DataGridPhase21.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                DataGridPhase21.DataSource = null;
                //DataGridCustomer.DataBind();
            }

            if (dsComypan.Tables[14].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                dataGridView1.DataSource = dsComypan.Tables[14];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                dataGridView1.Columns["StatusId"].Visible = false;
                dataGridView1.Columns["ProjectId"].Visible = false;
                dataGridView1.Columns["WorkId"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12.75F, FontStyle.Bold);
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.ForeColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            else
            {
                dataGridView1.DataSource = null;
                //DataGridCustomer.DataBind();
            }

            return dt;
        }

        private void FrmMoniter_Load(object sender, EventArgs e)
        {
            FillData();
            groupBox1.Visible = false;
            groupBox5.Visible = true;
            DataGridCustomer.Visible = true;
            BindStatus();


        }

        protected void BindStatus()
        {
            DataSet dsBrand = ObjUserDal.FetchData(ObjUser);
            cmdStatus.DataSource = dsBrand.Tables[1];
            cmdStatus.DisplayMember = "Status";
            cmdStatus.ValueMember = "StatusId";
            //CmbCountry.Text = "--Select--";

            cmdTask.DataSource = dsBrand.Tables[3];
            cmdTask.DisplayMember = "Task";
            cmdTask.ValueMember = "TskId";
        }


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

        private void DataGridPhase11_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase11.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase11.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase11.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase11.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase11.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase11.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase11.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void DataGridPhase21_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase21.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase21.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase21.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase21.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(DataGridPhase21.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                DataGridPhase21.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                DataGridPhase21.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value) == 3)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
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
                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    FillDataPhase(Convert.ToInt32(ID),1,0);
                    groupBox1.Visible = true;
                    groupBox5.Visible = false;
                }
                else
                {
                    //ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    groupBox1.Visible = true;
                    groupBox5.Visible = false;
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

        private void DataGridCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int UserGroupId = FrmLogin._RolId;

                if (e.ColumnIndex == DataGridCustomer.Columns["Project"].Index)
                {
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();


                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    FillDataPhase(Convert.ToInt32(ID),1,0);
                    groupBox1.Visible = true;
                    groupBox5.Visible = false;
                }
                else
                {
                    //ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    //Lblp1.Visible = true;
                    //Lbld.Visible = true;
                    //LblProjectDate.Visible = true;
                    //lblProjectName.Visible = true;
                    ID = DataGridCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    groupBox1.Visible = true;
                    groupBox5.Visible = false;
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

        private void cmdStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmdStatus.SelectedIndex>0 && cmdTask.SelectedIndex>0)
            {
                FillDataPhase(Convert.ToInt32(ID),Convert.ToInt32(cmdTask.SelectedValue), Convert.ToInt32(cmdStatus.SelectedValue));
            }
        }

        private void cmdTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdTask.SelectedIndex > 0)
            {
                FillDataPhase(Convert.ToInt32(ID), Convert.ToInt32(cmdTask.SelectedValue), Convert.ToInt32(0));
            }
        }
    }
}
