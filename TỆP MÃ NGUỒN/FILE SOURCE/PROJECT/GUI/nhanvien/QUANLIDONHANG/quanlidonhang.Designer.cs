namespace PROJECT.GUI.nhanvien
{
    partial class quanlidonhang
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
            this.txt_ngaykhoitao = new System.Windows.Forms.TextBox();
            this.txt_madonhang = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.btn_themdonhang = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_hienthitatca = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_trangthaidonhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DONHANG_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKHOITAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHACHHANG_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAIDONHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ngaykhoitao
            // 
            this.txt_ngaykhoitao.Location = new System.Drawing.Point(137, 79);
            this.txt_ngaykhoitao.Name = "txt_ngaykhoitao";
            this.txt_ngaykhoitao.Size = new System.Drawing.Size(248, 22);
            this.txt_ngaykhoitao.TabIndex = 2;
            // 
            // txt_madonhang
            // 
            this.txt_madonhang.Location = new System.Drawing.Point(138, 27);
            this.txt_madonhang.Name = "txt_madonhang";
            this.txt_madonhang.Size = new System.Drawing.Size(248, 22);
            this.txt_madonhang.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(854, 318);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DONHANG_ID,
            this.NGAYKHOITAO,
            this.KHACHHANG_ID,
            this.NHANVIEN_ID,
            this.TONGTIEN,
            this.TRANGTHAIDONHANG});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 82);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_huy);
            this.panel5.Controls.Add(this.btn_xacnhan);
            this.panel5.Controls.Add(this.btn_themdonhang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(314, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 82);
            this.panel5.TabIndex = 1;
            // 
            // btn_huy
            // 
            this.btn_huy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_huy.Location = new System.Drawing.Point(370, 0);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(170, 82);
            this.btn_huy.TabIndex = 2;
            this.btn_huy.Text = "HỦY ĐƠN HÀNG";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_xacnhan.Location = new System.Drawing.Point(181, 0);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(189, 82);
            this.btn_xacnhan.TabIndex = 1;
            this.btn_xacnhan.Text = "XÁC NHẬN ĐƠN HÀNG";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_themdonhang
            // 
            this.btn_themdonhang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_themdonhang.Location = new System.Drawing.Point(0, 0);
            this.btn_themdonhang.Name = "btn_themdonhang";
            this.btn_themdonhang.Size = new System.Drawing.Size(181, 82);
            this.btn_themdonhang.TabIndex = 0;
            this.btn_themdonhang.Text = "XEM CHI TIẾT ĐƠN HÀNG";
            this.btn_themdonhang.UseVisualStyleBackColor = true;
            this.btn_themdonhang.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_hienthitatca);
            this.panel4.Controls.Add(this.btn_timkiem);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.txt_timkiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 82);
            this.panel4.TabIndex = 0;
            // 
            // btn_hienthitatca
            // 
            this.btn_hienthitatca.Location = new System.Drawing.Point(156, 44);
            this.btn_hienthitatca.Name = "btn_hienthitatca";
            this.btn_hienthitatca.Size = new System.Drawing.Size(152, 28);
            this.btn_hienthitatca.TabIndex = 3;
            this.btn_hienthitatca.Text = "HIỂN THỊ TẤT CẢ";
            this.btn_hienthitatca.UseVisualStyleBackColor = true;
            this.btn_hienthitatca.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(3, 44);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(147, 28);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "TÌM KIẾM";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MÃ ĐƠN HÀNG",
            "TRẠNG THÁI ĐƠN HÀNG"});
            this.comboBox1.Location = new System.Drawing.Point(190, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(3, 6);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(180, 22);
            this.txt_timkiem.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "MÃ NHÂN VIÊN";
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(521, 28);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(319, 22);
            this.txt_manhanvien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "TỔNG TIỀN";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(521, 78);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(319, 22);
            this.txt_tongtien.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MÃ KHÁCH HÀNG";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(138, 134);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(248, 22);
            this.txt_makhachhang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NGÀY KHỞI TẠO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_trangthaidonhang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_manhanvien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_tongtien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_makhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ngaykhoitao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_madonhang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "XÁC NHẬN",
            "CHƯA XÁC NHẬN"});
            this.comboBox2.Location = new System.Drawing.Point(0, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "TRẠNG THÁI \r\nĐƠN HÀNG";
            // 
            // txt_trangthaidonhang
            // 
            this.txt_trangthaidonhang.Location = new System.Drawing.Point(521, 136);
            this.txt_trangthaidonhang.Name = "txt_trangthaidonhang";
            this.txt_trangthaidonhang.Size = new System.Drawing.Size(319, 22);
            this.txt_trangthaidonhang.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ ĐƠN HÀNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 190);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 590);
            this.panel1.TabIndex = 1;
            // 
            // DONHANG_ID
            // 
            this.DONHANG_ID.DataPropertyName = "DONHANG_ID";
            this.DONHANG_ID.HeaderText = "MÃ ĐƠN HÀNG";
            this.DONHANG_ID.Name = "DONHANG_ID";
            this.DONHANG_ID.ReadOnly = true;
            // 
            // NGAYKHOITAO
            // 
            this.NGAYKHOITAO.DataPropertyName = "NGAYKHOITAO";
            this.NGAYKHOITAO.HeaderText = "NGÀY KHỞI TẠO ĐƠN HÀNG";
            this.NGAYKHOITAO.Name = "NGAYKHOITAO";
            this.NGAYKHOITAO.ReadOnly = true;
            // 
            // KHACHHANG_ID
            // 
            this.KHACHHANG_ID.DataPropertyName = "KHACHHANG_ID";
            this.KHACHHANG_ID.HeaderText = "MÃ KHÁCH HÀNG";
            this.KHACHHANG_ID.Name = "KHACHHANG_ID";
            this.KHACHHANG_ID.ReadOnly = true;
            // 
            // NHANVIEN_ID
            // 
            this.NHANVIEN_ID.DataPropertyName = "NHANVIEN_ID";
            this.NHANVIEN_ID.HeaderText = "MÃ NHÂN VIÊN";
            this.NHANVIEN_ID.Name = "NHANVIEN_ID";
            this.NHANVIEN_ID.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "TỔNG TIỀN";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // TRANGTHAIDONHANG
            // 
            this.TRANGTHAIDONHANG.DataPropertyName = "TRANGTHAIDONHANG";
            this.TRANGTHAIDONHANG.HeaderText = "TRẠNG THÁI ĐƠN HÀNG";
            this.TRANGTHAIDONHANG.Name = "TRANGTHAIDONHANG";
            this.TRANGTHAIDONHANG.ReadOnly = true;
            // 
            // quanlidonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "quanlidonhang";
            this.Size = new System.Drawing.Size(854, 590);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ngaykhoitao;
        private System.Windows.Forms.TextBox txt_madonhang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.Button btn_themdonhang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_hienthitatca;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_trangthaidonhang;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONHANG_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKHOITAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHACHHANG_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHANVIEN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAIDONHANG;
    }
}
