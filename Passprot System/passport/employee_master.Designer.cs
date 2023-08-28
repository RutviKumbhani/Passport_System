namespace passport
{
    partial class employee_master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_master));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Label();
            this.com_eid = new System.Windows.Forms.ComboBox();
            this.txt_enm = new System.Windows.Forms.TextBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_nm = new System.Windows.Forms.RadioButton();
            this.rb_id = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_jdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 692);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 473);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 209);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.Search);
            this.panel6.Controls.Add(this.com_eid);
            this.panel6.Controls.Add(this.txt_enm);
            this.panel6.Controls.Add(this.rb_all);
            this.panel6.Controls.Add(this.rb_nm);
            this.panel6.Controls.Add(this.rb_id);
            this.panel6.Location = new System.Drawing.Point(8, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 209);
            this.panel6.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(17, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(77, 28);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            // 
            // com_eid
            // 
            this.com_eid.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_eid.FormattingEnabled = true;
            this.com_eid.Location = new System.Drawing.Point(149, 66);
            this.com_eid.Name = "com_eid";
            this.com_eid.Size = new System.Drawing.Size(157, 31);
            this.com_eid.TabIndex = 4;
            this.com_eid.SelectedIndexChanged += new System.EventHandler(this.com_eid_SelectedIndexChanged);
            // 
            // txt_enm
            // 
            this.txt_enm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enm.Location = new System.Drawing.Point(149, 109);
            this.txt_enm.Name = "txt_enm";
            this.txt_enm.Size = new System.Drawing.Size(157, 30);
            this.txt_enm.TabIndex = 3;
            this.txt_enm.TextChanged += new System.EventHandler(this.txt_enm_TextChanged);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.BackColor = System.Drawing.Color.Transparent;
            this.rb_all.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_all.Location = new System.Drawing.Point(20, 148);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(54, 27);
            this.rb_all.TabIndex = 2;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All";
            this.rb_all.UseVisualStyleBackColor = false;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // rb_nm
            // 
            this.rb_nm.AutoSize = true;
            this.rb_nm.BackColor = System.Drawing.Color.Transparent;
            this.rb_nm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nm.Location = new System.Drawing.Point(19, 110);
            this.rb_nm.Name = "rb_nm";
            this.rb_nm.Size = new System.Drawing.Size(107, 27);
            this.rb_nm.TabIndex = 1;
            this.rb_nm.TabStop = true;
            this.rb_nm.Text = "By name";
            this.rb_nm.UseVisualStyleBackColor = false;
            this.rb_nm.CheckedChanged += new System.EventHandler(this.rb_nm_CheckedChanged);
            // 
            // rb_id
            // 
            this.rb_id.AutoSize = true;
            this.rb_id.BackColor = System.Drawing.Color.Transparent;
            this.rb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_id.Location = new System.Drawing.Point(21, 70);
            this.rb_id.Name = "rb_id";
            this.rb_id.Size = new System.Drawing.Size(78, 27);
            this.rb_id.TabIndex = 0;
            this.rb_id.TabStop = true;
            this.rb_id.Text = "By ID";
            this.rb_id.UseVisualStyleBackColor = false;
            this.rb_id.CheckedChanged += new System.EventHandler(this.rb_id_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.btn_insert);
            this.panel4.Controls.Add(this.txt_id);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btn_cancel);
            this.panel4.Controls.Add(this.txt_city);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.txt_salary);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_email);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtp_jdate);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_phone);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_name);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(8, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 292);
            this.panel4.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(541, 242);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 43);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.Black;
            this.btn_insert.Location = new System.Drawing.Point(325, 242);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(102, 43);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(206, 56);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(224, 29);
            this.txt_id.TabIndex = 19;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(433, 242);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 43);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(649, 242);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 43);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(206, 125);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(224, 29);
            this.txt_city.TabIndex = 17;
            this.txt_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_city_KeyPress);
            this.txt_city.Leave += new System.EventHandler(this.txt_city_Leave);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(757, 242);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 43);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "city:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(865, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(651, 89);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(228, 29);
            this.txt_salary.TabIndex = 15;
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            this.txt_salary.Leave += new System.EventHandler(this.txt_salary_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(521, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Salary:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(206, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(224, 29);
            this.txt_email.TabIndex = 12;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Master";
            // 
            // dtp_jdate
            // 
            this.dtp_jdate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_jdate.Location = new System.Drawing.Point(651, 158);
            this.dtp_jdate.Name = "dtp_jdate";
            this.dtp_jdate.Size = new System.Drawing.Size(224, 29);
            this.dtp_jdate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Joining date:";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(651, 123);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(224, 29);
            this.txt_phone.TabIndex = 3;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone no:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(206, 91);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(224, 29);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
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
            this.label1.Location = new System.Drawing.Point(202, 23);
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
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // employee_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 879);
            this.Controls.Add(this.panel1);
            this.Name = "employee_master";
            this.Text = "employee_master";
            this.Load += new System.EventHandler(this.employee_master_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox com_eid;
        private System.Windows.Forms.TextBox txt_enm;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_nm;
        private System.Windows.Forms.RadioButton rb_id;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_jdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}