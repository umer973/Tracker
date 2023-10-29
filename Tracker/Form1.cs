using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker;

namespace lmitp
{
    public partial class Form1 : Form
    {
        public event EventHandler ReclickRequest;
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if(FrmLogin._RolId==1)
            {
                button3.Visible = true;
                btnreports.Visible = true;
            }
            else
            {
                button3.Visible = false;
                btnreports.Visible = false;
            }
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
           
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        internal void button1_Click(object obj, EventArgs e)
        {
            this.Hide();
            FrmLogin Fl = new FrmLogin();
            Fl.Show();

            //loadform(new FrmUpdateTask());
            //loadform(new FrmUpdateTask());
            //loadform(new FrmUpdateTask());
        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
          loadform(new Home());
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
           loadform(new FrmProject());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
           loadform(new FrmMoniter());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbluser.Text = FrmLogin._UserName;
            // Home form2 = new Home();

            int id = Convert.ToInt32(Home._ProjectId);
            if(id>0)
            {
                loadform(new FrmUpdateTask());
            }
            else
            {
                loadform(new Home());
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FrmUser());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new FrmtaskMaster());
        }
    }
}
