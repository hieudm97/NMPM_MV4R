namespace PROJECT.GUI.nhanvien
{
    partial class quanlidia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAPDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGTINLIENQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_suathongtindia = new System.Windows.Forms.Button();
            this.btn_xoadia = new System.Windows.Forms.Button();
            this.btn_themdia = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_loaidia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richtxt_thongtinlienquan = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soluongdia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giasanpham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ngaynhapdia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_iddia = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_chenanh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 652);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(872, 292);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.NGAYNHAPDIA,
            this.SOLUONG,
            this.THONGTINLIENQUAN,
            this.GIA});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "MÃ ĐĨA";
            this.ID.Name = "ID";
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "TÊN ĐĨA";
            this.TEN.Name = "TEN";
            // 
            // NGAYNHAPDIA
            // 
            this.NGAYNHAPDIA.DataPropertyName = "NGAYNHAPDIA";
            this.NGAYNHAPDIA.HeaderText = "NGÀY NHẬP ĐĨA";
            this.NGAYNHAPDIA.Name = "NGAYNHAPDIA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "SỐ LƯỢNG TỒN";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // THONGTINLIENQUAN
            // 
            this.THONGTINLIENQUAN.DataPropertyName = "THONGTINLIENQUAN";
            this.THONGTINLIENQUAN.HeaderText = "THÔNG TIN PHIM";
            this.THONGTINLIENQUAN.Name = "THONGTINLIENQUAN";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "GIÁ BÁN";
            this.GIA.Name = "GIA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 82);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_suathongtindia);
            this.panel5.Controls.Add(this.btn_xoadia);
            this.panel5.Controls.Add(this.btn_themdia);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(314, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 82);
            this.panel5.TabIndex = 1;
            // 
            // btn_suathongtindia
            // 
            this.btn_suathongtindia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_suathongtindia.Location = new System.Drawing.Point(382, 0);
            this.btn_suathongtindia.Name = "btn_suathongtindia";
            this.btn_suathongtindia.Size = new System.Drawing.Size(176, 82);
            this.btn_suathongtindia.TabIndex = 2;
            this.btn_suathongtindia.Text = "SỬA THÔNG TIN ĐĨA";
            this.btn_suathongtindia.UseVisualStyleBackColor = true;
            this.btn_suathongtindia.Click += new System.EventHandler(this.btn_suathongtindia_Click);
            // 
            // btn_xoadia
            // 
            this.btn_xoadia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_xoadia.Location = new System.Drawing.Point(199, 0);
            this.btn_xoadia.Name = "btn_xoadia";
            this.btn_xoadia.Size = new System.Drawing.Size(183, 82);
            this.btn_xoadia.TabIndex = 1;
            this.btn_xoadia.Text = "XÓA ĐĨA";
            this.btn_xoadia.UseVisualStyleBackColor = true;
            this.btn_xoadia.Click += new System.EventHandler(this.btn_xoadia_Click);
            // 
            // btn_themdia
            // 
            this.btn_themdia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_themdia.Location = new System.Drawing.Point(0, 0);
            this.btn_themdia.Name = "btn_themdia";
            this.btn_themdia.Size = new System.Drawing.Size(199, 82);
            this.btn_themdia.TabIndex = 0;
            this.btn_themdia.Text = "THÊM ĐĨA";
            this.btn_themdia.UseVisualStyleBackColor = true;
            this.btn_themdia.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 82);
            this.panel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "HIỂN THỊ TẤT CẢ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "TÌM KIẾM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "TÊN ĐĨA",
            "GIÁ"});
            this.comboBox1.Location = new System.Drawing.Point(190, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(3, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 22);
            this.txt_search.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 278);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_chenanh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbo_loaidia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richtxt_thongtinlienquan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_soluongdia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_giasanpham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ngaynhapdia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tendia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_iddia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ";
            // 
            // cbo_loaidia
            // 
            this.cbo_loaidia.FormattingEnabled = true;
            this.cbo_loaidia.Items.AddRange(new object[] {
            "HDDVD",
            "DVD",
            "BLUERAY"});
            this.cbo_loaidia.Location = new System.Drawing.Point(103, 149);
            this.cbo_loaidia.Name = "cbo_loaidia";
            this.cbo_loaidia.Size = new System.Drawing.Size(248, 24);
            this.cbo_loaidia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "LOẠI ĐĨA";
            // 
            // richtxt_thongtinlienquan
            // 
            this.richtxt_thongtinlienquan.Location = new System.Drawing.Point(508, 125);
            this.richtxt_thongtinlienquan.Name = "richtxt_thongtinlienquan";
            this.richtxt_thongtinlienquan.Size = new System.Drawing.Size(333, 147);
            this.richtxt_thongtinlienquan.TabIndex = 11;
            this.richtxt_thongtinlienquan.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "THÔNG TIN\r\nSẢN PHẨM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "SỐ LƯỢNG TỒN";
            // 
            // txt_soluongdia
            // 
            this.txt_soluongdia.Location = new System.Drawing.Point(508, 27);
            this.txt_soluongdia.Name = "txt_soluongdia";
            this.txt_soluongdia.Size = new System.Drawing.Size(333, 22);
            this.txt_soluongdia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "GIÁ SẢN PHẨM";
            // 
            // txt_giasanpham
            // 
            this.txt_giasanpham.Location = new System.Drawing.Point(508, 77);
            this.txt_giasanpham.Name = "txt_giasanpham";
            this.txt_giasanpham.Size = new System.Drawing.Size(333, 22);
            this.txt_giasanpham.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "    NGÀY \r\nNHẬP ĐĨA";
            // 
            // txt_ngaynhapdia
            // 
            this.txt_ngaynhapdia.Location = new System.Drawing.Point(103, 112);
            this.txt_ngaynhapdia.Name = "txt_ngaynhapdia";
            this.txt_ngaynhapdia.Size = new System.Drawing.Size(248, 22);
            this.txt_ngaynhapdia.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txt_ngaynhapdia, "VUI LÒNG NHẬP THỜI GIAN DƯỚI DẠNG: ddmmyyyy\r\nEx: 17052017");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÊN ĐĨA";
            // 
            // txt_tendia
            // 
            this.txt_tendia.Location = new System.Drawing.Point(103, 66);
            this.txt_tendia.Name = "txt_tendia";
            this.txt_tendia.Size = new System.Drawing.Size(248, 22);
            this.txt_tendia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID ĐĨA";
            // 
            // txt_iddia
            // 
            this.txt_iddia.Location = new System.Drawing.Point(103, 27);
            this.txt_iddia.Name = "txt_iddia";
            this.txt_iddia.Size = new System.Drawing.Size(248, 22);
            this.txt_iddia.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(103, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "HÌNH ẢNH";
            // 
            // btn_chenanh
            // 
            this.btn_chenanh.Location = new System.Drawing.Point(25, 214);
            this.btn_chenanh.Name = "btn_chenanh";
            this.btn_chenanh.Size = new System.Drawing.Size(75, 58);
            this.btn_chenanh.TabIndex = 17;
            this.btn_chenanh.Text = "Chèn ảnh";
            this.btn_chenanh.UseVisualStyleBackColor = true;
            this.btn_chenanh.Click += new System.EventHandler(this.btn_chenanh_Click);
            // 
            // quanlidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "quanlidia";
            this.Size = new System.Drawing.Size(872, 652);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_suathongtindia;
        private System.Windows.Forms.Button btn_xoadia;
        private System.Windows.Forms.Button btn_themdia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richtxt_thongtinlienquan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soluongdia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giasanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ngaynhapdia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tendia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_iddia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAPDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGTINLIENQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbo_loaidia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_chenanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
