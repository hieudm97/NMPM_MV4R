using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.LOGIC_LAYER;

namespace PROJECT.GUI.nhanvien.QUANLIKHACHHANG
{
    public partial class quanlikhachhang : UserControl
    {
        //mem
        LOGIC lg = new LOGIC();
        //func
        public quanlikhachhang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*tìm kiếm dựa vào combox tìm kiếm*/
            /*tim kiem dua vao loai tim kiem trong combox tim kiem */
            string loaitimkiem = comboBox1.Text;

            //bat dau tim kiem
            switch (loaitimkiem)
            {
                case "MÃ KHÁCH HÀNG":
                    //tim kiem thong tin theo MÃ KHÁCH HÀNG 
                    int makh = int.Parse(txt_timkiem.Text);
                    dataGridView1.DataSource = lg.timkhachhangtheomakh_GUI_nhanvien_quanlikh(makh).ToList();
                    break;
                case "TÊN KHÁCH HÀNG":
                    //tim kiem thong tin theo TÊN KHÁCH HÀNG
                    string tenkhachhang = txt_timkiem.Text;
                    dataGridView1.DataSource = lg.timkiemkhachhangtheotenkhachhang_GUI_nhanvien_quanlikh(tenkhachhang).ToList();
                    break;
                case "TUỔI":
                    //tim kiem thong tin theo TUỔI 
                    int tuoi = int.Parse(txt_timkiem.Text);
                    dataGridView1.DataSource = lg.timkiemkhachhangtheotuoikhachhang_GUI_nhanvien_quanlikh(tuoi).ToList();
                    break;
                case "TÊN ĐĂNG NHẬP":
                    //tim kiem thong tin theo TÊN ĐĂNG NHẬP
                    string tendangnhap = txt_timkiem.Text;
                    dataGridView1.DataSource = lg.timkiemkhachhangtheotendangnhapkhachhang_GUI_nhanvien_quanlikh(tendangnhap).ToList();
                    break;
                case "LOẠI THÀNH VIÊN":
                    //tim kiem thong tin theo LOẠI THÀNH VIÊN
                    string loaithanhvien = txt_timkiem.Text;
                    dataGridView1.DataSource = lg.timkiemkhachhangtheoloaikhachhang_GUI_nhanvien_quanlikh(loaithanhvien).ToList();
                    
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*hiển thị danh sách khách hàng lên datagridview*/
            dataGridView1.DataSource = lg.laydskhachhang_GUI_nhanvien_quanlikh().ToList();
            dataGridView1.Columns[9].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*thêm khách hàng vào trong DB*/
            //khởi tạo thông tin cần thiết 
            try
            {
                int ID = int.Parse(txt_makhachang.Text);
                string TEN = txt_hoten.Text;
                int TUOI = int.Parse(txt_tuoi.Text);
                DateTime NGAYSINH = DateTime.ParseExact(txt_ngaysinh.Text, "ddMMyyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string TENCONGTY = txt_tencongty.Text;
                string TENDANGNHAP = txt_tendangnhap.Text;
                string MATKHAU = txt_matkhau.Text;
                string LOAITHANHVIEN = cbo_loaithanhvien.Text;
                //thực hiện thao tác thêm
                if (lg.kiemtratendangnhap(TENDANGNHAP) == false)
                {

                    lg.themkhachhang_GUI_nhanvien_quanlikh(TEN, TUOI,
                                   NGAYSINH, TENCONGTY, TENDANGNHAP,
                                   MATKHAU, LOAITHANHVIEN);
                    //thông báo 
                    MessageBox.Show("CHÚC MỪNG BẠN VỪA THÊM THÀNH CÔNG KHÁCH HÀNG");


                }
                else
                {
                    MessageBox.Show("TÊN ĐĂNG NHẬP CỦA BẠN ĐÃ ĐƯỢC SỬ DỤNG!!!");
                }
            }
            catch
            {
                MessageBox.Show("VUI LÒNG KIỂM TRA LẠI TOÀN BỘ THÔNG TIN VỪA NHẬP");
            }
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*xóa khách hàng khỏi DB*/
            //thông báo xác nhận
            string caption = "XÁC NHẬN HÀNH VI";
            string text = "BẠN MUỐN XÓA DỮ LIỆU?";
            DialogResult dr =  MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                //lấy id khách hàng được chọn
                int makhachhang = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                //thực hiện thao tác xóa
                lg.xoakhachhang_GUI_nhanvien_quanlikh(makhachhang);
                //hiển thị xóa thành công
                MessageBox.Show("BẠN VỪA XÓA THÀNH CÔNG MỘT KHÁCH HÀNG!!!");
            }
            else
            {
                MessageBox.Show("Quay lại nào!!!"); 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*thực hiện sửa thông tin khách hàng và ghi lại vào DB*/
            //khởi tạo thông tin cần thiết
            int ID = int.Parse(txt_makhachang.Text);
            string TEN = txt_hoten.Text;
            int TUOI = int.Parse(txt_tuoi.Text);
            DateTime NGAYSINH = DateTime.ParseExact(txt_ngaysinh.Text, "ddmmyyyy",
                                   System.Globalization.CultureInfo.InvariantCulture);
            string TENCONGTY = txt_tencongty.Text;
            string TENDANGNHAP = txt_tendangnhap.Text;
            string MATKHAU = txt_matkhau.Text;
            string LOAITHANHVIEN = cbo_loaithanhvien.Text;
            //thực hiện thao tác sửa
            lg.suakhachhang_GUI_nhanvien_quanlikh(ID, TEN, TUOI,
                NGAYSINH, TENCONGTY, TENDANGNHAP,
                MATKHAU, LOAITHANHVIEN);
            //thông báo 
            MessageBox.Show("SỬA THÔNG TIN KHÁCH HÀNG THÀNH CÔNG!!!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* đổ thông tin được chọn lên các control*/
            //lấy datagridview đc chọn
            DataGridViewRow dgv_row = dataGridView1.SelectedRows[0];
            //đổ dữ liệu
            txt_makhachang.Text = dgv_row.Cells["ID"].Value.ToString();
            txt_hoten.Text = dgv_row.Cells["TEN"].Value.ToString();
            txt_tuoi.Text = dgv_row.Cells["TUOI"].Value.ToString();
            txt_ngaysinh.Text = dgv_row.Cells["NGAYSINH"].Value.ToString();
            txt_tencongty.Text = dgv_row.Cells["TENCONGTY"].Value.ToString();
            txt_tendangnhap.Text = dgv_row.Cells["TENDANGNHAP"].Value.ToString();
            txt_matkhau.Text = dgv_row.Cells["MATKHAU"].Value.ToString();
            cbo_loaithanhvien.Text = dgv_row.Cells["LOAITHANHVIEN"].Value.ToString();
        }
    }
}
