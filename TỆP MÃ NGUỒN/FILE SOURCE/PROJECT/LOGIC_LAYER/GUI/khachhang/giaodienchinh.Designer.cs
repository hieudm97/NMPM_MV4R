namespace PROJECT.GUI.khachhang
{
    partial class giaodienchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giaodienchinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.btn_muahang = new System.Windows.Forms.Button();
            this.btn_xemsanpham = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.cbo_phanloaisanpham = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_giohang = new System.Windows.Forms.Label();
            this.pic_giohang = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tt_timkiem = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_giohang)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 553);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_thanhtoan);
            this.panel8.Controls.Add(this.btn_muahang);
            this.panel8.Controls.Add(this.btn_xemsanpham);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 490);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1004, 63);
            this.panel8.TabIndex = 1;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(686, 11);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(315, 45);
            this.btn_thanhtoan.TabIndex = 2;
            this.btn_thanhtoan.Text = "THANH TOÁN";
            this.tt_timkiem.SetToolTip(this.btn_thanhtoan, "THANH TOÁN SẢN PHẨM SAU KHI CẬP NHẬT ");
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // btn_muahang
            // 
            this.btn_muahang.Location = new System.Drawing.Point(354, 10);
            this.btn_muahang.Name = "btn_muahang";
            this.btn_muahang.Size = new System.Drawing.Size(325, 45);
            this.btn_muahang.TabIndex = 1;
            this.btn_muahang.Text = "CẬP NHẬT GIỎ HÀNG";
            this.tt_timkiem.SetToolTip(this.btn_muahang, "CẬP NHẬT GIỎ HÀNG ĐỂ TIẾN HÀNH THANH TOÁN");
            this.btn_muahang.UseVisualStyleBackColor = true;
            this.btn_muahang.Click += new System.EventHandler(this.btn_muahang_Click);
            // 
            // btn_xemsanpham
            // 
            this.btn_xemsanpham.Location = new System.Drawing.Point(3, 11);
            this.btn_xemsanpham.Name = "btn_xemsanpham";
            this.btn_xemsanpham.Size = new System.Drawing.Size(344, 45);
            this.btn_xemsanpham.TabIndex = 0;
            this.btn_xemsanpham.Text = "XEM SẢN PHẨM";
            this.tt_timkiem.SetToolTip(this.btn_xemsanpham, "XEM DANH SÁCH SẢN PHẨM TẠI ĐÂY");
            this.btn_xemsanpham.UseVisualStyleBackColor = true;
            this.btn_xemsanpham.Click += new System.EventHandler(this.btn_xemsanpham_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1004, 490);
            this.panel7.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 72);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.txt_timkiem);
            this.panel6.Controls.Add(this.cbo_phanloaisanpham);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(617, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 72);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(293, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.tt_timkiem.SetToolTip(this.pictureBox1, "VUI LÒNG NHẬP TÊN SẢN PHẨM CẦN TÌM KIẾM");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.tt_timkiem.SetToolTip(this.pictureBox2, "VUI LÒNG NHẬP TÊN SẢN PHẨM CẦN TÌM KIẾM");
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(6, 8);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(203, 22);
            this.txt_timkiem.TabIndex = 0;
            this.tt_timkiem.SetToolTip(this.txt_timkiem, "VUI LÒNG NHẬP TÊN SẢN PHẨM CẦN TÌM KIẾM");
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // cbo_phanloaisanpham
            // 
            this.cbo_phanloaisanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phanloaisanpham.FormattingEnabled = true;
            this.cbo_phanloaisanpham.Items.AddRange(new object[] {
            "HDDVD",
            "DVD",
            "BLUERAY",
            "GIÁ TỪ THẤP ĐẾN CAO",
            "GIÁ TỪ CAO ĐẾN THẤP"});
            this.cbo_phanloaisanpham.Location = new System.Drawing.Point(6, 42);
            this.cbo_phanloaisanpham.Name = "cbo_phanloaisanpham";
            this.cbo_phanloaisanpham.Size = new System.Drawing.Size(203, 24);
            this.cbo_phanloaisanpham.TabIndex = 3;
            this.cbo_phanloaisanpham.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbl_giohang);
            this.panel5.Controls.Add(this.pic_giohang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(357, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 72);
            this.panel5.TabIndex = 1;
            // 
            // lbl_giohang
            // 
            this.lbl_giohang.AutoSize = true;
            this.lbl_giohang.Location = new System.Drawing.Point(106, 24);
            this.lbl_giohang.Name = "lbl_giohang";
            this.lbl_giohang.Size = new System.Drawing.Size(82, 17);
            this.lbl_giohang.TabIndex = 1;
            this.lbl_giohang.Text = "SỐ LƯỢNG";
            // 
            // pic_giohang
            // 
            this.pic_giohang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_giohang.Image = ((System.Drawing.Image)(resources.GetObject("pic_giohang.Image")));
            this.pic_giohang.Location = new System.Drawing.Point(0, 0);
            this.pic_giohang.Name = "pic_giohang";
            this.pic_giohang.Size = new System.Drawing.Size(100, 70);
            this.pic_giohang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_giohang.TabIndex = 0;
            this.pic_giohang.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbl_tendangnhap);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 72);
            this.panel4.TabIndex = 0;
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.Location = new System.Drawing.Point(212, 8);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(89, 17);
            this.lbl_tendangnhap.TabIndex = 2;
            this.lbl_tendangnhap.Text = "THÔNG TIN ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tt_timkiem
            // 
            this.tt_timkiem.AutoPopDelay = 5000;
            this.tt_timkiem.InitialDelay = 500;
            this.tt_timkiem.ReshowDelay = 50;
            this.tt_timkiem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tt_timkiem.ToolTipTitle = "THÔNG TIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÀNH VIÊN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TÊN TV:";
            // 
            // giaodienchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 625);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giaodienchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giaodienchinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giaodienchinh_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_giohang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button btn_muahang;
        private System.Windows.Forms.Button btn_xemsanpham;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_giohang;
        private System.Windows.Forms.PictureBox pic_giohang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ToolTip tt_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_phanloaisanpham;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}