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
    public partial class FrmUpdateTask : Form
    {
        ClassUser ObjUser = new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        public FrmUpdateTask()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        protected void BindTaskData(int Id)
        {

            ObjUser.UserId = Convert.ToInt32(Id);

            DataSet ds = ObjUserDal.FetchDataId(ObjUser);
            if (ds.Tables[11].Rows.Count > 0)
            {
                TxtTask.Text = Convert.ToString(ds.Tables[11].Rows[0]["Work"]);
               // Date.Text = Convert.ToString(ds.Tables[0].Rows[0]["Date"]);
               
            }
        }

        private void FrmUpdateTask_Load(object sender, EventArgs e)
        {
            // ObjCustomer.CreatedBy = Login._UserId;
            int Mod = Convert.ToInt32(FrmPhaseTrackAdmin._ModeId);
            if (Mod == 1)
            {
                ObjUser.WorkId = Convert.ToInt32(FrmPhaseTrackAdmin._WorkId);
            }
            else
            {
                ObjUser.WorkId = Convert.ToInt32(FrmPhaseTrack._WorkId);
            }
            BindTaskData(ObjUser.WorkId);
            BindStatus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
           
                if (BtnSave.Text == "Save")
                {
                    if (SaveData() == true)
                    {
                        MessageBox.Show("Data saved successfully");
                        this.DialogResult = DialogResult.OK;
                       // FillData();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                SaveData();
                    MessageBox.Show("Data updated successfully.");
                    Reset();
                    BtnSave.Text = "Save";
                   // FillData();
                }
            
        }
        protected void BindStatus()
        {
            DataSet dsBrand = ObjUserDal.FetchData(ObjUser);
            cmdStatus.DataSource = dsBrand.Tables[1];
            cmdStatus.DisplayMember = "Status";
            cmdStatus.ValueMember = "StatusId";
            //CmbCountry.Text = "--Select--";
        }
        protected bool SaveData()
        {
            bool flag = false;
            int Mod = Convert.ToInt32(FrmPhaseTrackAdmin._ModeId);
            if(Mod==1)
            {
                ObjUser.WorkId = Convert.ToInt32(FrmPhaseTrackAdmin._WorkId);
            }
            else
            {
                ObjUser.WorkId = Convert.ToInt32(FrmPhaseTrack._WorkId);
            }
           
            ObjUser.ProjectId = Convert.ToInt32(Home._ProjectId);
            ObjUser.UserGroupId = Convert.ToInt32(FrmLogin._RolId);
            ObjUser.Description = TxtDescription.Text.Trim();
            ObjUser.StatusId = Convert.ToInt32(cmdStatus.SelectedValue);
            ObjUser.TaskId = Convert.ToInt32(Home._TaskId);
            ObjUser.Date = Date.Value;

            int pkID = ObjUserDal.UpdateProjectExcuton(ObjUser);
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
        protected void Reset()
        {
           
            TxtDescription.Text = "";
            TxtTask.Text = "";
            cmdStatus.SelectedIndex = 0;
        }
    }
}
