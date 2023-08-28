namespace passport
{
    partial class cost_mas_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cost_mas_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comenm = new System.Windows.Forms.ComboBox();
            this.comeid = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.rball = new System.Windows.Forms.RadioButton();
            this.rbenm = new System.Windows.Forms.RadioButton();
            this.rbid = new System.Windows.Forms.RadioButton();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.axCrystalReport1 = new AxCrystal.AxCrystalReport();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 615);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.axCrystalReport1);
            this.panel5.Controls.Add(this.comenm);
            this.panel5.Controls.Add(this.comeid);
            this.panel5.Controls.Add(this.btnshow);
            this.panel5.Controls.Add(this.rball);
            this.panel5.Controls.Add(this.rbenm);
            this.panel5.Controls.Add(this.rbid);
            this.panel5.Controls.Add(this.btnexit);
            this.panel5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(8, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(968, 374);
            this.panel5.TabIndex = 3;
            // 
            // comenm
            // 
            this.comenm.FormattingEnabled = true;
            this.comenm.Location = new System.Drawing.Point(338, 138);
            this.comenm.Name = "comenm";
            this.comenm.Size = new System.Drawing.Size(303, 34);
            this.comenm.TabIndex = 13;
            // 
            // comeid
            // 
            this.comeid.FormattingEnabled = true;
            this.comeid.Location = new System.Drawing.Point(338, 66);
            this.comeid.Name = "comeid";
            this.comeid.Size = new System.Drawing.Size(303, 34);
            this.comeid.TabIndex = 12;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(216, 291);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(169, 42);
            this.btnshow.TabIndex = 11;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.Location = new System.Drawing.Point(212, 209);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(59, 30);
            this.rball.TabIndex = 10;
            this.rball.TabStop = true;
            this.rball.Text = "All";
            this.rball.UseVisualStyleBackColor = true;
            // 
            // rbenm
            // 
            this.rbenm.AutoSize = true;
            this.rbenm.Location = new System.Drawing.Point(212, 142);
            this.rbenm.Name = "rbenm";
            this.rbenm.Size = new System.Drawing.Size(89, 30);
            this.rbenm.TabIndex = 9;
            this.rbenm.TabStop = true;
            this.rbenm.Text = "Name";
            this.rbenm.UseVisualStyleBackColor = true;
            this.rbenm.CheckedChanged += new System.EventHandler(this.rbenm_CheckedChanged);
            // 
            // rbid
            // 
            this.rbid.AutoSize = true;
            this.rbid.Location = new System.Drawing.Point(212, 70);
            this.rbid.Name = "rbid";
            this.rbid.Size = new System.Drawing.Size(54, 30);
            this.rbid.TabIndex = 8;
            this.rbid.TabStop = true;
            this.rbid.Text = "ID";
            this.rbid.UseVisualStyleBackColor = true;
            this.rbid.CheckedChanged += new System.EventHandler(this.rbid_CheckedChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(456, 291);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(169, 42);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(8, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 47);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Costomer Master Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbltime);
            this.panel2.Controls.Add(this.lbldate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 162);
            this.panel2.TabIndex = 1;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(727, 128);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(55, 22);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "Time:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(728, 92);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(53, 22);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(724, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "205. Sardar palace,\r\nPuna kumbhariya Surat,\r\nGujarat 395010\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passport data management system \r\n                       for\r\n                Bor" +
    "ad consultancy\r\n";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 146);
            this.panel3.TabIndex = 0;
            // 
            // axCrystalReport1
            // 
            this.axCrystalReport1.Enabled = true;
            this.axCrystalReport1.Location = new System.Drawing.Point(756, 127);
            this.axCrystalReport1.Name = "axCrystalReport1";
            this.axCrystalReport1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalReport1.OcxState")));
            this.axCrystalReport1.Size = new System.Drawing.Size(28, 28);
            this.axCrystalReport1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cost_mas_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 636);
            this.Controls.Add(this.panel1);
            this.Name = "cost_mas_report";
            this.Text = "cost_mas_report";
            this.Load += new System.EventHandler(this.cost_mas_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private AxCrystal.AxCrystalReport axCrystalReport1;
        private System.Windows.Forms.ComboBox comenm;
        private System.Windows.Forms.ComboBox comeid;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.RadioButton rbenm;
        private System.Windows.Forms.RadioButton rbid;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;

    }
}