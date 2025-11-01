namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbtitle = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.grbinfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinsdrect = new System.Windows.Forms.TextBox();
            this.grbfunct = new System.Windows.Forms.GroupBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnunin = new System.Windows.Forms.Button();
            this.grbsysinfo = new System.Windows.Forms.GroupBox();
            this.lblwin = new System.Windows.Forms.Label();
            this.grbtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbinfo.SuspendLayout();
            this.grbfunct.SuspendLayout();
            this.grbsysinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbtitle
            // 
            this.grbtitle.Controls.Add(this.pictureBox1);
            this.grbtitle.Controls.Add(this.lbltitle);
            this.grbtitle.Location = new System.Drawing.Point(1, 0);
            this.grbtitle.Name = "grbtitle";
            this.grbtitle.Size = new System.Drawing.Size(801, 81);
            this.grbtitle.TabIndex = 0;
            this.grbtitle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Black;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(177, 27);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(479, 39);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "BKAV UNINSTALLER TOOL";
            // 
            // grbinfo
            // 
            this.grbinfo.Controls.Add(this.label1);
            this.grbinfo.Controls.Add(this.txtinsdrect);
            this.grbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbinfo.Location = new System.Drawing.Point(3, 89);
            this.grbinfo.Name = "grbinfo";
            this.grbinfo.Size = new System.Drawing.Size(797, 104);
            this.grbinfo.TabIndex = 1;
            this.grbinfo.TabStop = false;
            this.grbinfo.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BKAV INSTALLED IN";
            // 
            // txtinsdrect
            // 
            this.txtinsdrect.Enabled = false;
            this.txtinsdrect.Location = new System.Drawing.Point(93, 72);
            this.txtinsdrect.Name = "txtinsdrect";
            this.txtinsdrect.Size = new System.Drawing.Size(613, 26);
            this.txtinsdrect.TabIndex = 0;
            // 
            // grbfunct
            // 
            this.grbfunct.Controls.Add(this.btnremove);
            this.grbfunct.Controls.Add(this.btnunin);
            this.grbfunct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbfunct.Location = new System.Drawing.Point(3, 199);
            this.grbfunct.Name = "grbfunct";
            this.grbfunct.Size = new System.Drawing.Size(797, 109);
            this.grbfunct.TabIndex = 2;
            this.grbfunct.TabStop = false;
            this.grbfunct.Text = "Choosen";
            // 
            // btnremove
            // 
            this.btnremove.Enabled = false;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(588, 36);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(171, 47);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Delete Leftover";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnunin
            // 
            this.btnunin.Enabled = false;
            this.btnunin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunin.Location = new System.Drawing.Point(39, 36);
            this.btnunin.Name = "btnunin";
            this.btnunin.Size = new System.Drawing.Size(171, 47);
            this.btnunin.TabIndex = 0;
            this.btnunin.Text = "Uninstall";
            this.btnunin.UseVisualStyleBackColor = true;
            this.btnunin.Click += new System.EventHandler(this.btnunin_Click);
            // 
            // grbsysinfo
            // 
            this.grbsysinfo.Controls.Add(this.lblwin);
            this.grbsysinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbsysinfo.Location = new System.Drawing.Point(3, 314);
            this.grbsysinfo.Name = "grbsysinfo";
            this.grbsysinfo.Size = new System.Drawing.Size(801, 77);
            this.grbsysinfo.TabIndex = 1;
            this.grbsysinfo.TabStop = false;
            this.grbsysinfo.Text = "Machine Info";
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwin.Location = new System.Drawing.Point(227, 38);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(66, 24);
            this.lblwin.TabIndex = 0;
            this.lblwin.Text = "label2";
            this.lblwin.Click += new System.EventHandler(this.lblwin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.grbsysinfo);
            this.Controls.Add(this.grbfunct);
            this.Controls.Add(this.grbinfo);
            this.Controls.Add(this.grbtitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 437);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BKAV UNINSTALLER TOOL (FREE)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbtitle.ResumeLayout(false);
            this.grbtitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbinfo.ResumeLayout(false);
            this.grbinfo.PerformLayout();
            this.grbfunct.ResumeLayout(false);
            this.grbsysinfo.ResumeLayout(false);
            this.grbsysinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbtitle;
        private System.Windows.Forms.GroupBox grbinfo;
        private System.Windows.Forms.GroupBox grbfunct;
        private System.Windows.Forms.GroupBox grbsysinfo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinsdrect;
        private System.Windows.Forms.Button btnunin;
        private System.Windows.Forms.Label lblwin;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

