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

namespace PROJECT.GUI.nhanvien
{
    public partial class quanlidonhang : UserControl
    {
        //MEM
        LOGIC lg = new LOGIC(); 
        //func
        public quanlidonhang()
        {
            InitializeComponent();
            khoitaobandau();
        }

     private void khoitaobandau()
        {
            comboBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*tim kiem dua vao loai tim kiem trong combox tim kiem */
            string loaitimkiem = comboBox1.Text;
            //bat dau tim kiem
            switch (loaitimkiem)
            {
                case "MÃ ĐƠN HÀNG":
                    //tim kiem thong tin theo MÃ ĐƠN HÀNG
                    int madonhang = int.Parse(txt_timkiem.Text);
                    dataGridView1.DataSource = lg.timdonhangtheomadonhang_GUI_QLDONHANG(madonhang).ToList();
                    break;
                case "TRẠNG THÁI ĐƠN HÀNG":
                    //tim kiem thong tin theo TRẠNG THÁI ĐƠN HÀNG
                    string trangthaidonhang = comboBox2.Text;
                    dataGridView1.DataSource = lg.timdonhangtheotrangthai_GUI_QLDONHANG(trangthaidonhang).ToList();
                    break;
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*HIEN THI DANH SACH DON HANG CUNG VOI TRANG THAI DON HANG LEN GRIDVIEW*/
            dataGridView1.DataSource = lg.laydsdonhang_GUI_QLDONHANG();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*HIỂN THỊ DANH SÁCH CHI TIẾT ĐƠN HÀNG ĐÃ CHỌN*/
            try
            {
                //lấy mã id của đơn hàng đã chọn
                int donhang_id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //xuất chi tiết đơn hàng của đơn hàng chọn trong một form mới
                nhanvien.QUANLIDONHANG.formxemchitietdonhang frm_chitietdh = new QUANLIDONHANG.formxemchitietdonhang(donhang_id);
                frm_chitietdh.Show();
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*xác nhân đơn hàng được đặt bởi khách hàng*/
            //kiểm tra dòng được chọn là : CHƯA ĐƯỢC XỬ LÝ ? 
            int donhang_id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bool trangthaidonhang = lg.kiemtratrangthaidonhang_GUI_QLDONHANG(donhang_id);
            if(trangthaidonhang == false)
            {
                /*ĐÚNG: chuyển đổi trạng thái sang là đã xác nhận -> Lưu vào trong bảng hóa đơn -> Thông báo*/
                //Chuyển đổi trạng thái và Lưu đơn hàng vào trong bảng đơn hàng cần xử lý 
                lg.chuyendoitrangthaidonhangthanhdaxuly_GUI_QLDONHANG(donhang_id);
                //xóa bớt số đĩa khách đã mua khỏi DB
                lg.xoabotsodiakhachmua_GUI_QLDONHANG(donhang_id);
                //lưu vào bảng hóa đơn
                lg.luudonhangvuaduocxacnhanvaobanghoadon_GUI_QLDONHANG(donhang_id);
                //thông báo 
                MessageBox.Show("ĐƠN HÀNG VỪA ĐƯỢC XỬ LÝ XONG VÀ LƯU VÀO BẢNG HÓA ĐƠN. BẮT ĐẦU QUÁ TRÌNH GỬI HÀNG ĐI...");
            }
            else
            {
                //SAI: Hiển thị thông báo đã xác nhận rồi 
                MessageBox.Show("KHÔNG THỂ XÁC NHẬN LẦN NỮA!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* Hủy đơn hàng chưa xác nhận */
            //kiểm tra dòng được chọn là : CHƯA ĐƯỢC XỬ LÝ ? 

            int donhang_id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bool trangthaidonhang = lg.kiemtratrangthaidonhang_GUI_QLDONHANG(donhang_id);
            if (trangthaidonhang == false)
            {

                //Hiển thị thông báo xác nhận YES/NO
                string caption = "XÁC NHẬN HÀNH ĐỘNG";
                string text = "BẠN CÓ CHẮC MUỐN HỦY ĐƠN HÀNG ?";
                DialogResult dr = MessageBox.Show(text, caption, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    /*ĐÚNG: XÓA ĐƠN HÀNG KHỎI BẢNG ĐƠN HÀNG VÀ TRẠNG THÁI ĐƠN HÀNG VÀ CHI TIẾT ĐƠN HÀNG */
                    //thực hiện thao tác xóa đơn hàng trong TRẠNG THÁI ĐƠN HÀNG
                    lg.xoadonhangkhoibangtrangthaidonhang_GUI_QLDONHANG(donhang_id);
                    //thực hiện thao tác xóa đơn hàng trong CHI TIẾT ĐƠN HÀNG
                    lg.xoadonhangkhoibangchitietdonhang_GUI_QLDONHANG(donhang_id);
                    //thực hiện thao tác xóa đơn hàng trong  đơn hàng
                    lg.xoadonhangkhoibangdonhang_GUI_QLDONHANG(donhang_id);
                    MessageBox.Show("BẠN VỪA HỦY THÀNH CÔNG MỘT ĐƠN HÀNG");
                }
                else
                { 
                    //SAI: KHÔNG LÀM GÌ CẢ
                    MessageBox.Show("HÃY QUAY TRỞ LẠI"); 
                }

            }
            else
            {
                //SAI: Thông báo: Không thể hủy do đơn hàng đã được xác nhận
                MessageBox.Show("KHÔNG THỂ HỦY ĐƠN HÀNG VÌ BẠN ĐÃ XÁC NHẬN RỒI!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* đổ thông tin được chọn lên các control*/
            //lấy datagridview đc chọn
            DataGridViewRow dgv_row = dataGridView1.SelectedRows[0];
            //đổ dữ liệu
            txt_madonhang.Text = dgv_row.Cells[0].Value.ToString();

            DateTime date = DateTime.Parse(dgv_row.Cells[1].Value.ToString());
            txt_ngaykhoitao.Text = date.ToString("ddMMyyyy");

            txt_makhachhang.Text = dgv_row.Cells[2].Value.ToString();

            txt_manhanvien.Text = dgv_row.Cells[3].Value.ToString();
            txt_tongtien.Text = dgv_row.Cells[4].Value.ToString();
            if(dgv_row.Cells[5].Value.ToString() == "True")
            {
                txt_trangthaidonhang.Text = "ĐÃ XỬ LÝ";
            }
            else
            {
                if (dgv_row.Cells[5].Value.ToString() == "False")
                {
                    txt_trangthaidonhang.Text = "CHỜ XỬ LÝ...";
                }
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "TRẠNG THÁI ĐƠN HÀNG")
            {
                comboBox2.Visible = true; 
            }
            else
            {
                comboBox2.Visible = false;
            }
        }
    }
}
