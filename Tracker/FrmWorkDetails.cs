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
    public partial class FrmWorkDetails : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        string ID = "0";
        string ProjectId = "0";
        string TaskId = "0";
        int UserGroupId = 0;
        public static int _ProjectId = 0;
        public static int _TaskId = 0;
        public FrmWorkDetails()
        {
            InitializeComponent();
        }

        protected DataTable FillData()
        {
            ObjUser.UserId = 1;
            DataSet dsComypan = ObjUserDal.FetchDataId(ObjUser);
            DataTable dt = dsComypan.Tables[0];
            if (dsComypan.Tables[3].Rows.Count > 0)
            {
                //AddWButtonColumns(DataGridCustomer);
                DataGridPhase3.DataSource = dsComypan.Tables[3];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase3.Columns["StatusId"].Visible = false;
                DataGridPhase3.Columns["ProjectId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase3.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase3.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                DataGridPhase3.EnableHeadersVisualStyles = false;
                DataGridPhase3.RowHeadersVisible = false;
                DataGridPhase3.BackgroundColor = Color.White;
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
                DataGridPhase2_1.DataSource = dsComypan.Tables[4];

                // DataGridCustomer.Columns["StatusId"].Visible = false;
                DataGridPhase2_1.Columns["StatusId"].Visible = false;
                DataGridPhase2_1.Columns["ProjectId"].Visible = false;
                //DataGridCustomer.Columns["isPreAdmin"].Visible = false;
                //DataGridCustomer.Columns["isPostAdmin"].Visible = false;
                //DataGridCustomer.Columns["isExcute"].Visible = false;
                DataGridPhase2_1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
                //DataGridVenderDetails.HeaderCell.Style.ForeColor = Color.Red;
                // DataGridVenderDetails.ColumnHeadersHeight = 1000;
                DataGridPhase2_1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                DataGridPhase2_1.EnableHeadersVisualStyles = false;
                DataGridPhase2_1.RowHeadersVisible = false;
                DataGridPhase2_1.BackgroundColor = Color.White;
                //AddWButtonColumns(DataGridCustomer);
            }
            return dt;
        }

        private void FrmWorkDetails_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void DataGridPhase1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 0 & e.Value != null)
            //{

            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Pre Adm Plg.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;


            //}
            //if (e.ColumnIndex == 1 & e.Value != null)
            //{

            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Pre Adm Plg.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;


            //}


            //if (e.ColumnIndex == 2 & e.Value != null)
            //{

            //    //int StatusId = Convert.ToInt32(e.Value);

            //    if (Convert.ToString(e.Value) == "Pre Adm Plg.")
            //        e.CellStyle.BackColor = Color.Red;
            //    else
            //        e.CellStyle.BackColor = Color.Green;


            //}

          

        }

        private void DataGridPhase1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase3.Rows[e.RowIndex].Cells[1].Value)==1)
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else  if (Convert.ToInt32(DataGridPhase3.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                DataGridPhase3.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

        }

        private void DataGridPhase1_1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(DataGridPhase2_1.Rows[e.RowIndex].Cells[1].Value) == 1)
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(DataGridPhase2_1.Rows[e.RowIndex].Cells[1].Value) == 2)
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                DataGridPhase2_1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

        }
    }
}
