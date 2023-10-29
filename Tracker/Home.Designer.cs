namespace Tracker
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridCustomer = new System.Windows.Forms.DataGridView();
            this.GroupProjectProgerss = new System.Windows.Forms.GroupBox();
            this.DataGridProgress = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).BeginInit();
            this.GroupProjectProgerss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridCustomer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1200, 692);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // DataGridCustomer
            // 
            this.DataGridCustomer.AllowUserToAddRows = false;
            this.DataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridCustomer.Location = new System.Drawing.Point(4, 28);
            this.DataGridCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridCustomer.Name = "DataGridCustomer";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridCustomer.RowHeadersVisible = false;
            this.DataGridCustomer.Size = new System.Drawing.Size(1192, 659);
            this.DataGridCustomer.TabIndex = 49;
            this.DataGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomer_CellClick);
            this.DataGridCustomer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridCustomer_CellFormatting);
            // 
            // GroupProjectProgerss
            // 
            this.GroupProjectProgerss.Controls.Add(this.DataGridProgress);
            this.GroupProjectProgerss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupProjectProgerss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupProjectProgerss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(70)))));
            this.GroupProjectProgerss.Location = new System.Drawing.Point(0, 0);
            this.GroupProjectProgerss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupProjectProgerss.Name = "GroupProjectProgerss";
            this.GroupProjectProgerss.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupProjectProgerss.Size = new System.Drawing.Size(1200, 692);
            this.GroupProjectProgerss.TabIndex = 68;
            this.GroupProjectProgerss.TabStop = false;
            this.GroupProjectProgerss.Text = "Details";
            // 
            // DataGridProgress
            // 
            this.DataGridProgress.AllowUserToAddRows = false;
            this.DataGridProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridProgress.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridProgress.Location = new System.Drawing.Point(4, 28);
            this.DataGridProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridProgress.Name = "DataGridProgress";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridProgress.RowHeadersVisible = false;
            this.DataGridProgress.Size = new System.Drawing.Size(1192, 659);
            this.DataGridProgress.TabIndex = 49;
            this.DataGridProgress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProgress_CellClick);
            this.DataGridProgress.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridProgress_CellFormatting);
            this.DataGridProgress.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridProgress_CellPainting);
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.GroupProjectProgerss);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).EndInit();
            this.GroupProjectProgerss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridCustomer;
        private System.Windows.Forms.GroupBox GroupProjectProgerss;
        private System.Windows.Forms.DataGridView DataGridProgress;
        private System.Windows.Forms.Timer Timer;
    }
}