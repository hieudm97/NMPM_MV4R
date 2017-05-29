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

namespace PROJECT.GUI.khachhang
{
    public partial class donhang : Form
    {
        //mem
        DataGridView dgv;
        LOGIC lg = new LOGIC();
        string tendangnhap;
        //func
        public donhang(DataGridView dgv, string tendangnhap)
        {
            this.tendangnhap = tendangnhap;
            this.dgv = dgv;
            InitializeComponent();
           khoitaothongtin();
        }
        private float tinhtongtien()
        {
            //tinh het tong tien
            float sum_dh = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                //  tinh tong tien san pham cua moi dong = gia san pham *so luong mua moi san pham
                float tongtiensanpham =
                    float.Parse(row.Cells[6].Value.ToString()) *
                    int.Parse(row.Cells[11].Value.ToString());
                //cong don vao tong tien don han
                sum_dh += tongtiensanpham;


            }
            //return
            return sum_dh;
        }

        private void khoitaothongtin()
        {
            //KHỞI TẠO DỮ LIỆU DATAGRIDVIEW VÀ TẮT CÁC CỘT KHÔNG CẦN THIẾT
            try
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item.Cells[0].Value.ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item.Cells[3].Value.ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item.Cells[4].Value.ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item.Cells[5].Value.ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item.Cells[6].Value.ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item.Cells[7].Value.ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item.Cells[8].Value.ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item.Cells[9].Value.ToString();
                        dataGridView1.Rows[n].Cells[10].Value = item.Cells[10].Value.ToString();
                        dataGridView1.Rows[n].Cells[11].Value = item.Cells[11].Value.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("LỖI!!!");
            }
      
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;


            /*KHỞI TẠO THÔNG TIN*/

            /*KHỞI TẠO THÔNG TIN ĐƠN HÀNG*/
            //  string madonhang = lg.laymadh_GUI_cust_donhang();
            //  string ngaykhoitao = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();
            string ngaykhoitao = DateTime.Now.ToString("ddMMyyyy");
           
            string nhanvien_id = lg.layngaunhienidnv_GUI_cust_donhang();
            string diachigiaohang = lg.laydiachikhachhang(tendangnhap);
            /*khởi tạo text field tổng tiền*/
            //kiểm tra loại thành viên
            float tienuudai = lg.kiemtraloaithanhviendethanhtoan_GUI_cust_donhang(tendangnhap);
            MessageBox.Show("CHÚC MỪNG BẠN NHẬN ĐƯỢC MỘT ƯU ĐÃI KHI MUA PHIM VỚI GIÁ TIỀN GIẢM: " + (tienuudai * 100).ToString() + "%");
            //trừ tiền ưu đãi vào tổng tiền
            float tong = tinhtongtien();
            string tongtien = (tong - (tong * tienuudai)).ToString();
            //txt_madonhang.Text = madonhang;
            txt_ngaykhoitao.Text = ngaykhoitao;
            txt_nhanvien.Text = nhanvien_id;
            txt_diachi.Text = diachigiaohang;
            txt_tongtien.Text = tongtien;
            txt_tienkhuyenmai.Text = (tong * tienuudai).ToString();
            lbl_ngaygiaohang.Text = "THỜI GIAN GIAO HÀNG DỰ KIẾN LÀ: " + DateTime.Now.AddDays(5).ToString("dd/MM/yyyy");


            /*KHỞI TẠO THÔNG TIN NGƯỜI DÙNG*/
            string tenkhachhang  = lg.laytenkhachang_GUI_cust_donhang(tendangnhap);
            string tuoi = lg.laytuoikhachang_GUI_cust_donhang(tendangnhap);
            string tencongty = lg.laytencongtykhachang_GUI_cust_donhang(tendangnhap);
            string loaithanhvien = lg.layloaithanhvienkhachang_GUI_cust_donhang(tendangnhap);
            string diachi = lg.laydiachikhachang_GUI_cust_donhang(tendangnhap);

            txt_tenkhachhang.Text = tenkhachhang;
            txt_tuoi.Text = tuoi;
            txt_tencongty.Text = tencongty;
            txt_loaithanhvien.Text = loaithanhvien;
            txt_diachikh.Text = diachi; 

        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
          

        }

        private Dictionary<int, int> laydanhsachdiavasoluongmuahang_GUI_cust_donhang()
        {
            // throw new NotImplementedException();
            Dictionary<int, int> dsdiamuavasoluongmua = new Dictionary<int, int>();
            //duyệt hết các dòng trong datagrid và lưu mã đĩa tương đương số lượng
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                int dia_id = int.Parse(dr.Cells[1].Value.ToString());
                int soluongdia = int.Parse(dr.Cells[11].Value.ToString());
                dsdiamuavasoluongmua.Add(dia_id, soluongdia);
            }
            //trả về 
            
            return dsdiamuavasoluongmua; 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click_1(object sender, EventArgs e)
        {
            //khoi tao gia tri can thiet

            DateTime ngaykhoitao = DateTime.ParseExact(txt_ngaykhoitao.Text, "ddMMyyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            int khachhang_id = lg.laymakhachang_GUI_cust_donhang(tendangnhap);
            int nhanvien_id = int.Parse(txt_nhanvien.Text);
            float tongtien = float.Parse(txt_tongtien.Text);
            string diachigiaohang = txt_diachi.Text;
            //THÊM VÀO TABLE ĐƠN HÀNG
            lg.themvaodonhang(ngaykhoitao, khachhang_id, nhanvien_id, tongtien, diachigiaohang);
            //them vao table TRẠNG THÁI ĐƠN HÀNG
            int madonhang = lg.laymadonhangmoinhat__GUI_cust_donhang();
            bool trangthaidonhang = false;
            lg.themvaotrangthaidonhang(madonhang, ngaykhoitao, trangthaidonhang);
            // thêm vào bảng CHI TIÊT ĐƠN HÀNG:mảng đĩa_id và số lượng + đơn hàng id
            Dictionary<int, int> danhsachdiavasoluong = laydanhsachdiavasoluongmuahang_GUI_cust_donhang();
            lg.themchitietdonhangvaobangchitietdonhang(madonhang, danhsachdiavasoluong);
            //hien thi messbox :"DON HANG CHO XU LY" 
            MessageBox.Show("CHÚC MỪNG BẠN ĐÃ ĐẶT HÀNG THÀNH CÔNG.ĐƠN HÀNG CỦA BẠN ĐANG CHỜ XỬ LÝ...");
        }
    }
}
