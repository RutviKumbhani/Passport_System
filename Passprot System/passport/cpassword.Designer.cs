namespace passport
{
    partial class cpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cpassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtconfirmpwd = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncontiue = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcurrentpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 580);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btncontiue);
            this.panel4.Controls.Add(this.btn_Exit);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtcurrentpwd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(8, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 385);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.txtnewpwd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtconfirmpwd);
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 233);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(605, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 193);
            this.panel5.TabIndex = 18;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpwd.Location = new System.Drawing.Point(229, 24);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.PasswordChar = '*';
            this.txtnewpwd.Size = new System.Drawing.Size(288, 33);
            this.txtnewpwd.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "New password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Confirm password:";
            // 
            // txtconfirmpwd
            // 
            this.txtconfirmpwd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpwd.Location = new System.Drawing.Point(229, 64);
            this.txtconfirmpwd.Name = "txtconfirmpwd";
            this.txtconfirmpwd.PasswordChar = '*';
            this.txtconfirmpwd.Size = new System.Drawing.Size(288, 33);
            this.txtconfirmpwd.TabIndex = 16;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.Location = new System.Drawing.Point(50, 162);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(175, 43);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.Location = new System.Drawing.Point(250, 162);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(175, 43);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "CLEAR";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btncontiue
            // 
            this.btncontiue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btncontiue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontiue.ForeColor = System.Drawing.Color.Black;
            this.btncontiue.Location = new System.Drawing.Point(566, 70);
            this.btncontiue.Name = "btncontiue";
            this.btncontiue.Size = new System.Drawing.Size(175, 43);
            this.btncontiue.TabIndex = 31;
            this.btncontiue.Text = "CONTINUE";
            this.btncontiue.UseVisualStyleBackColor = false;
            this.btncontiue.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(765, 70);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(175, 43);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change password";
            // 
            // txtcurrentpwd
            // 
            this.txtcurrentpwd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentpwd.Location = new System.Drawing.Point(237, 72);
            this.txtcurrentpwd.Name = "txtcurrentpwd";
            this.txtcurrentpwd.PasswordChar = '*';
            this.txtcurrentpwd.Size = new System.Drawing.Size(288, 33);
            this.txtcurrentpwd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Password:";
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
            this.panel2.Size = new System.Drawing.Size(984, 162);
            this.panel2.TabIndex = 2;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(747, 128);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(55, 22);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "Time:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(748, 92);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(53, 22);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "205. Sardar palace,\r\nPuna kumbhariya Surat,\r\nGujarat 395010\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 20);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 611);
            this.Controls.Add(this.panel1);
            this.Name = "cpassword";
            this.Text = "cpassword";
            this.Load += new System.EventHandler(this.cpassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txtconfirmpwd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcurrentpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncontiue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
    }
}