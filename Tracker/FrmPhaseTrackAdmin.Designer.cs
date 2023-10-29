namespace Tracker
{
    partial class FrmPhaseTrackAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnPhase1 = new System.Windows.Forms.Button();
            this.DataGridPhase1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnPhase2 = new System.Windows.Forms.Button();
            this.BtnPreviewPhase1 = new System.Windows.Forms.Button();
            this.DataGridPhase2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnPrePhase2 = new System.Windows.Forms.Button();
            this.DataGridPhase3 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1307, 592);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnPhase1);
            this.tabPage1.Controls.Add(this.DataGridPhase1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1299, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phase (I)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnPhase1
            // 
            this.BtnPhase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnPhase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPhase1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPhase1.FlatAppearance.BorderSize = 0;
            this.BtnPhase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhase1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhase1.ForeColor = System.Drawing.Color.White;
            this.BtnPhase1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPhase1.Location = new System.Drawing.Point(3, 480);
            this.BtnPhase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPhase1.Name = "BtnPhase1";
            this.BtnPhase1.Size = new System.Drawing.Size(1293, 76);
            this.BtnPhase1.TabIndex = 56;
            this.BtnPhase1.Text = "Go For Ph II";
            this.BtnPhase1.UseVisualStyleBackColor = false;
            this.BtnPhase1.Click += new System.EventHandler(this.BtnPhase1_Click);
            // 
            // DataGridPhase1
            // 
            this.DataGridPhase1.AllowUserToAddRows = false;
            this.DataGridPhase1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPhase1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPhase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPhase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPhase1.Location = new System.Drawing.Point(3, 3);
            this.DataGridPhase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridPhase1.Name = "DataGridPhase1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPhase1.RowHeadersVisible = false;
            this.DataGridPhase1.Size = new System.Drawing.Size(1293, 553);
            this.DataGridPhase1.TabIndex = 52;
            this.DataGridPhase1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPhase1_CellClick);
            this.DataGridPhase1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridPhase1_CellPainting);
            this.DataGridPhase1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridPhase1_RowPrePaint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.DataGridPhase2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1299, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phase (II)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnPhase2);
            this.groupBox4.Controls.Add(this.BtnPreviewPhase1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1293, 100);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            // 
            // BtnPhase2
            // 
            this.BtnPhase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnPhase2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPhase2.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPhase2.FlatAppearance.BorderSize = 0;
            this.BtnPhase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhase2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhase2.ForeColor = System.Drawing.Color.White;
            this.BtnPhase2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPhase2.Location = new System.Drawing.Point(667, 31);
            this.BtnPhase2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPhase2.Name = "BtnPhase2";
            this.BtnPhase2.Size = new System.Drawing.Size(623, 66);
            this.BtnPhase2.TabIndex = 57;
            this.BtnPhase2.Text = "Go For Ph III";
            this.BtnPhase2.UseVisualStyleBackColor = false;
            this.BtnPhase2.Click += new System.EventHandler(this.BtnPhase2_Click);
            // 
            // BtnPreviewPhase1
            // 
            this.BtnPreviewPhase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnPreviewPhase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPreviewPhase1.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPreviewPhase1.FlatAppearance.BorderSize = 0;
            this.BtnPreviewPhase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreviewPhase1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviewPhase1.ForeColor = System.Drawing.Color.White;
            this.BtnPreviewPhase1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPreviewPhase1.Location = new System.Drawing.Point(3, 31);
            this.BtnPreviewPhase1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPreviewPhase1.Name = "BtnPreviewPhase1";
            this.BtnPreviewPhase1.Size = new System.Drawing.Size(677, 66);
            this.BtnPreviewPhase1.TabIndex = 56;
            this.BtnPreviewPhase1.Text = "Go For Ph I";
            this.BtnPreviewPhase1.UseVisualStyleBackColor = false;
            this.BtnPreviewPhase1.Click += new System.EventHandler(this.BtnPreviewPhase1_Click);
            // 
            // DataGridPhase2
            // 
            this.DataGridPhase2.AllowUserToAddRows = false;
            this.DataGridPhase2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPhase2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridPhase2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPhase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPhase2.Location = new System.Drawing.Point(3, 3);
            this.DataGridPhase2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridPhase2.Name = "DataGridPhase2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridPhase2.RowHeadersVisible = false;
            this.DataGridPhase2.Size = new System.Drawing.Size(1293, 553);
            this.DataGridPhase2.TabIndex = 52;
            this.DataGridPhase2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPhase2_CellClick);
            this.DataGridPhase2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridPhase2_CellPainting);
            this.DataGridPhase2.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridPhase2_RowPrePaint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnPrePhase2);
            this.tabPage3.Controls.Add(this.DataGridPhase3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1299, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phase (III)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnPrePhase2
            // 
            this.BtnPrePhase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnPrePhase2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPrePhase2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPrePhase2.FlatAppearance.BorderSize = 0;
            this.BtnPrePhase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrePhase2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrePhase2.ForeColor = System.Drawing.Color.White;
            this.BtnPrePhase2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrePhase2.Location = new System.Drawing.Point(0, 483);
            this.BtnPrePhase2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrePhase2.Name = "BtnPrePhase2";
            this.BtnPrePhase2.Size = new System.Drawing.Size(1299, 76);
            this.BtnPrePhase2.TabIndex = 56;
            this.BtnPrePhase2.Text = "Go For Ph II";
            this.BtnPrePhase2.UseVisualStyleBackColor = false;
            this.BtnPrePhase2.Click += new System.EventHandler(this.BtnPrePhase2_Click);
            // 
            // DataGridPhase3
            // 
            this.DataGridPhase3.AllowUserToAddRows = false;
            this.DataGridPhase3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridPhase3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridPhase3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPhase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPhase3.Location = new System.Drawing.Point(0, 0);
            this.DataGridPhase3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridPhase3.Name = "DataGridPhase3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPhase3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridPhase3.RowHeadersVisible = false;
            this.DataGridPhase3.Size = new System.Drawing.Size(1299, 559);
            this.DataGridPhase3.TabIndex = 52;
            this.DataGridPhase3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPhase3_CellClick);
            this.DataGridPhase3.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridPhase3_CellPainting);
            this.DataGridPhase3.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridPhase3_RowPrePaint);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1313, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1307, 100);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(503, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "POST-ADM PLG (26 WEEKS)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1313, 617);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // FrmPhaseTrackAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhaseTrackAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhaseTrack_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPhase3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DataGridPhase1;
        private System.Windows.Forms.DataGridView DataGridPhase2;
        private System.Windows.Forms.DataGridView DataGridPhase3;
        private System.Windows.Forms.Button BtnPhase1;
        private System.Windows.Forms.Button BtnPhase2;
        private System.Windows.Forms.Button BtnPreviewPhase1;
        private System.Windows.Forms.Button BtnPrePhase2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}