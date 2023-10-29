using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Configuration;
using DEntities;
using Tracker;
using Dal;
using lmitp;

namespace EasyAccounting
{
    public partial class Login : Form
    {
        ClassUser ObjUser =new ClassUser();
        ClassUserDal ObjUserDal = new ClassUserDal();
        ClassEncDecPassword ObjEncDec = new ClassEncDecPassword();
        string appExpired = ConfigurationSettings.AppSettings["Appcrash"].ToString();
        public static int _UserId = 0;
        public static int _BranchId = 0;
        public static int _RolId = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //string appCrash = ObjEncDec.decrypt(appExpired);
            //string appCrash = "02/20/2019";
            string appCrash = "04/07/2025";
            string todays = DateTime.Now.ToString("MM/dd/yyyy");
           // string D1 = "12/25/2017";
            DateTime dtCrash = Convert.ToDateTime(appCrash);
            DateTime dtTodays = DateTime.Now;
            //string to
            if (dtTodays >= dtCrash)
            {
                //string msg = "alert('Your application is expired. so please contact to your service provider.');"; //clsMessage.InvalidLogin();
                //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "key", msg, true);
                MessageBox.Show("You are using trial and it has expire,Please contact service provider");
            }
            //if (todays == appCrash)
            //{
            //    //string msg = "alert('Your application is expired. so please contact to your service provider.');"; //clsMessage.InvalidLogin();
            //    //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "key", msg, true);
            //    MessageBox.Show("Your application is expired. so please contact to your service provider");
            //}
            else
            {
                AuthenticateUser();
            }
        }

        protected void AuthenticateUser()
        {

            string Password = ObjEncDec.encrypt(TxtPass.Text.Trim());
            ObjUser.UserName = TxtUserName.Text.Trim();
            ObjUser.Password = Password;
            DataSet dsUserDetail = ObjUserDal.AuthenticateUser(ObjUser);

            if (dsUserDetail.Tables[0].Rows.Count > 0)
            {
                ObjUser.UserId = Convert.ToInt32(dsUserDetail.Tables[0].Rows[0]["UserId"]);
                _UserId = ObjUser.UserId;
                _BranchId = Convert.ToInt32(dsUserDetail.Tables[0].Rows[0]["BranchId"]);
                _RolId = Convert.ToInt32(dsUserDetail.Tables[0].Rows[0]["UserGroupId"]);
                string ExpDate = Convert.ToString(dsUserDetail.Tables[0].Rows[0]["ExpiryDate"]);
                string todays = DateTime.Now.ToString("dd/MM/yyyy");
                //if (ObjUserLogBLL.CheckLoginUser(ObjUserLogDE))
                //{
                //if (ExpDate>= todays)
                //{
                if (20 >= 0)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    //Home frm = new Home();
                    frm.Show();
                }
                else
                {
                    //string msg = "alert('Sorry! Your account is expired please contact to administrator.');"; //clsMessage.InvalidLogin();
                    //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "key", msg, true);
                    MessageBox.Show("Sorry! Your account is expired please contact to administrator.");
                }
                //}
                //else
                //{
                //    string msg = "alert('Sorry! already Your are login from another system.please contact to administrator.');"; //clsMessage.InvalidLogin();
                //    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "key", msg, true);
                //}


            }
            else
            {

                MessageBox.Show("Invalid User & Password");
                //alertmsg.Visible = true;
                ////string msg = "alert('Invalid Username or Password.');";
                //ObjUserLogDE.UserId = Convert.ToInt32(0);
                //ObjUserLogDE.LogStatus = "LoginFail";
                //// ObjUserLogDE.BranchId = Convert.ToInt32(Session["BranchId"]);
                //// ObjUserLogDE.Operation = "Login";
                //ObjUserLogDE.IpAddress = Request.UserHostAddress;
                //ObjUserLogDE.LogDate = DateTime.Now;
                //ObjUserLogDE.LoginTime = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
                //ObjUserLogBLL.CreateLoginDetail(ObjUserLogDE);
                //// //string msg = "alert('Invalid User & Password');";
                //ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "key",msg,true);
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
      
    }
}
