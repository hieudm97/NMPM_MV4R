using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.LOGIC_LAYER;
using System.Threading;

namespace PROJECT.GUI.khachhang
{
    public partial class giaodienchinh : Form
    {
        //meme
        LOGIC lg = new LOGIC();
        string tendangnhap;
        int solanthem = 0;
        //func 

        public giaodienchinh(string tendangnhap)
        {
            Thread t = new Thread(new ThreadStart(startform));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            initialize_info();
            t.Abort();
        }
        public void startform()
        {
           // Application.Run(new GUI.dangkidangnhap.loadinghethong()); 
        }
        public void initialize_info()
        {
            //gio hang 
           
            lbl_giohang.Visible = false;
            //ten nguoi dung 
            string tendangnhap = this.tendangnhap;
            string tennguoidung = lg.laytennguoidung_GUI_khachhang_giaodienchinh(tendangnhap);
            lbl_tendangnhap.Text = tennguoidung;
            //khởi tạo loại thành viên
            label2.Text = lg.layloaithanhvienkhachang_GUI_cust_donhang(tendangnhap);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //tim ten san pham
            string tensanpham = txt_timkiem.Text;
            //hien thi san pham
            DataGridView dgv = new DataGridView();
            dgv.DataSource = lg.timsanpham_GUI_khachhang_giaodienchinh(tensanpham).ToList();
            panel7.Controls.Add(dgv);
            dgv.Dock = DockStyle.Fill;
            dgv.BringToFront();
            dgv.Columns[0].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.AutoSizeColumnsMode =
       DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btn_xemsanpham_Click(object sender, EventArgs e)
        {
            

            //hien thi cot so luong muon mua
            if (solanthem == 0 )
            {
                //khoi tao gio hang
                lbl_giohang.Visible = true;
                lbl_giohang.Text = "SỐ LƯỢNG: " + "0";
                //hien thi danh sach san pham
                dataGridView1.DataSource = lg.laydsdia_GUI_KHACHANG_GIAODIENCHINH().ToList();
                dataGridView1.BringToFront();
                //hiển thị cột số lượng mua hàng 
                dataGridView1.Columns.Add("soluongmua", "SỐ LƯỢNG MUA");
                //hiển thị cột tick mua hàng 
                //hien thi them cot tick mua hang 
                DataGridViewCheckBoxColumn check_mua_hang = new DataGridViewCheckBoxColumn();
                {
                    check_mua_hang.HeaderText = "TICK MUA HÀNG";
                    check_mua_hang.Name = "tick_mua_hang";
                    check_mua_hang.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    check_mua_hang.FlatStyle = FlatStyle.Standard;
                    check_mua_hang.CellTemplate = new DataGridViewCheckBoxCell(false);
                    check_mua_hang.CellTemplate.Style.BackColor = Color.White;
                }
                dataGridView1.Columns.Insert(0, check_mua_hang);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }
                ////tắt các cột không cần thiết: 1 3 4 8 9 10 
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                solanthem++;
            }
            else
            {
                dataGridView1.BringToFront();
            }
           
         
           
        }

        public int count_itemsbuy_cust()
        {
            int count = 0;
            
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        count++;
                    }
                }
                return count;
        }

        private void btn_muahang_Click(object sender, EventArgs e)
        {
            //dem so luong hang duoc tick trong datagridview
            int count_itemsbuy = count_itemsbuy_cust();
            //cap nhat lai so luong hang hoa
            lbl_giohang.Text = "SỐ LƯỢNG: "+ count_itemsbuy.ToString();
            MessageBox.Show("CẬP NHẬT GIỎ HÀNG THÀNH CÔNG");
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            //mở bảng xác nhận mua hàng
            string caption = "XÁC NHẬN";
            string text = "MUA HÀNG CHỨ ?";
            DialogResult dg_result = MessageBox.Show(caption, text, MessageBoxButtons.YesNo);
            //mo form donhang va truyen datagridview vao form don hang
            int soluonghangmua = count_itemsbuy_cust();
            if(dg_result == DialogResult.Yes)
            {
                if (lbl_giohang.Text != "SỐ LƯỢNG: 0")
                {
                    int tmp = 0;
                    /*kiểm tra cột nhập sl mua đĩa đã điền đầy đủ hay chưa và có đủ số lượng để mua hay ko*/
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if ((bool)item.Cells[0].Value == true)
                        {
                           if(item.Cells[11].Value == null)
                            {
                                MessageBox.Show("Bạn vui lòng nhập thêm số lượng đĩa mua"); 
                            }
                           else
                            {
                                //kiểm tra có đủ số lượng đĩa tồn để có thể mua hay không
                                int ma_id = int.Parse(item.Cells[1].Value.ToString());
                                if(int.Parse(item.Cells[11].Value.ToString()) > lg.laysoluongdiacontontaitrongkhodia_GUI_KH_gdql(ma_id))
                                {
                                    MessageBox.Show("SỐ LƯỢNG ĐĨA TỒN KHÔNG CÒN ĐỦ CHO BẠN MUA");
                                }
                                else
                                {
                                    tmp++;
                                }
                            }

                        }
                    }
                    if(soluonghangmua == tmp)
                    {
                        GUI.khachhang.donhang frm_donhang = new donhang(dataGridView1,tendangnhap);
                        frm_donhang.Show(); 
                        
                    }

                }
                else
                {
                    MessageBox.Show("GIỎ HÀNG CỦA BẠN HIỆN ĐANG TRỐNG. VUI LÒNG MUA THÊM HÀNG");
                }
            }
            else
            {
                MessageBox.Show("MỜI BẠN TIẾP TỤC MUA HÀNG");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy ID phim cần xem chi tiết
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            int dia_id = int.Parse(dr.Cells[1].Value.ToString());
            /*HIỂN THỊ CHI TIẾT SẢN PHẨM*/
            chitietsanpham frm_chitietsanpham = new chitietsanpham(dia_id);
            frm_chitietsanpham.Show(); 
            

        }   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            switch (cbo_phanloaisanpham.Text)
            {
                case "HDDVD":
                case "DVD":
                case "BLUERAY":
                    dgv.DataSource = lg.timkiemtheophanloaisanpham_GUI_KH(cbo_phanloaisanpham.Text).ToList();
                    break;
                case "GIÁ TỪ THẤP ĐẾN CAO":
                    dgv.DataSource = lg.laydanhsachtatcacacdiagiatang_GUI_KH().ToList();
                    break;
                case "GIÁ TỪ CAO ĐẾN THẤP":
                    /*hiển thị danh sách tất cả các đĩa*/
                    dgv.DataSource = lg.laydanhsachtatcacacdiagiagiam_GUI_KH().ToList();
                    
                    break;
            }
           
            dgv.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            panel7.Controls.Add(dgv);
            dgv.Dock = DockStyle.Fill;
            
            dgv.BringToFront();
            dgv.Columns[0].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.AutoSizeColumnsMode =
       DataGridViewAutoSizeColumnsMode.Fill;
          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /* mở form xác nhận logout */
            try
            {
                DialogResult dlr = MessageBox.Show("BẠN CÓ CHẮC MUỐN THOÁT KHỎI CHƯƠNG TRÌNH", "XÁC NHẬN", MessageBoxButtons.YesNo);
                /*yes: quay lại form đăng nhập*/
                if (dlr == DialogResult.Yes)
                {
                    GUI.dangkidangnhap.dangnhap frm_dn = new dangkidangnhap.dangnhap();
                    frm_dn.Show();
                    this.Close();
                }
                /* No: hiển thị tiếp tục mua hàng */
                else
                {
                    MessageBox.Show("MỜI BẠN TIẾP TỤC MUA HÀNG!!!");
                }
            }
            catch 
            {
                MessageBox.Show("Xin lỗi không thể thoát!!!");
            }
         
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            
            string timkiem = txt_timkiem.Text;
            DataGridView dgv = new DataGridView();
            dgv.DataSource =  lg.timkiemsanpham_GUI_KH_giaodienchinh(timkiem).ToList();
            panel7.Controls.Add(dgv);
            dgv.Dock = DockStyle.Fill;
            dgv.BringToFront();
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void giaodienchinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
