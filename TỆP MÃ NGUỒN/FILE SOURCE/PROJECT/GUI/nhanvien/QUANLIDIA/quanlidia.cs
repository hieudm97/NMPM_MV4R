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
    public partial class quanlidia : UserControl
    {
        //mem
        LOGIC lg = new LOGIC();
        //func
        public quanlidia()
        {
            
            InitializeComponent();
        }

    
        private void ancot()
        {
            dataGridView1.Columns[6].Visible = false; 
        }
        private void kiemtra_timkiemrong()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("HỆ THỐNG KHÔNG TÌM THẤY THÔNG TIN CẦN THIẾT");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*tim kiem dua vao loai tim kiem trong combox tim kiem */
            string loaitimkiem = comboBox1.Text;

            //bat dau tim kiem
            switch (loaitimkiem)
            {   
                case "ID":
                    /*tim kiem thong tin ĐĨA THEO ID*/
                    int dia_id = int.Parse(txt_search.Text);
                    dataGridView1.DataSource = lg.laydanhsachdiatheoid_GUI_nhanvien_quanlidia(dia_id).ToList();
                    ancot();
                    kiemtra_timkiemrong();

                    break;
                case "TÊN ĐĨA":
                    //tim kiem thong tin bang ten dia
                    string tendia = txt_search.Text;
                    dataGridView1.DataSource = lg.laydanhsachdiatheotendia_GUI_nhanvien_quanlidia(tendia).ToList();
                    ancot();
                    kiemtra_timkiemrong();
                    break;
                case "GIÁ":
                    //tim kiem thong tin dua vao gia
                    float gia = float.Parse(txt_search.Text);
                    dataGridView1.DataSource = lg.laydanhsachdiatheogia_GUI_nhanvien_quanlidia(gia).ToList();
                    ancot();
                    kiemtra_timkiemrong();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hien thi tat ca danh sach dia len gridview 
            dataGridView1.DataSource = lg.laydsdia_GUI_nhanvien_quanlidia().ToList();
            ancot();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*thuc hien thao tac them dia vao db*/
            //khoi tao thong tin
         //   int ID = int.Parse(txt_iddia.Text);
         try
            {
                string tendia = txt_tendia.Text;
                DateTime ngaynhapdia = DateTime.ParseExact(txt_ngaynhapdia.Text, "ddMMyyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                int soluong = int.Parse(txt_soluongdia.Text);
                string thongtinlienquan = richtxt_thongtinlienquan.Text;
                float gia = float.Parse(txt_giasanpham.Text);
                string loaidia = cbo_loaidia.Text;
                Image hinhanhphim = pictureBox1.Image;
                if(hinhanhphim == null)
                {
                    MessageBox.Show("VUI LÒNG CHÈN HÌNH ẢNH ĐẠI DIỆN CHO ĐĨA");
                }
                //thuc hien thao tac them dia 
                lg.themdia_GUI_nhanvien_quanlidia(tendia, ngaynhapdia, soluong, thongtinlienquan, gia,loaidia,hinhanhphim);
                //thong bao thanh cong 
                MessageBox.Show("CHÚC MỪNG!!! BẠN VỪA THÊM ĐĨA THÀNH CÔNG");
            }
            catch
            {
                MessageBox.Show("VUI LÒNG KIỂM TRA LẠI TOÀN BỘ THÔNG TIN VỪA NHẬP");
            }
          
        }

        private void btn_xoadia_Click(object sender, EventArgs e)
        {
            /* xoa dia duoc chọn trên datagridview */
            //lay ma id cua dia duoc chon tren datagridview
            int dia_id = 0 ;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                dia_id = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
            //thuc hien xoa dia 
            lg.xoadia_GUI_nhanvien_quanlidia(dia_id);
            //thong bao
            MessageBox.Show("BẠN VỪA XÓA MỘT ĐĨA");
        }

        private void btn_suathongtindia_Click(object sender, EventArgs e)
        {
            //khoi tao thong tin
            try
            {
                int ID = int.Parse(txt_iddia.Text);
                string tendia = txt_tendia.Text;
                DateTime ngaynhapdia = DateTime.ParseExact(txt_ngaynhapdia.Text, "ddMMyyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                int soluong = int.Parse(txt_soluongdia.Text);
                string thongtinlienquan = richtxt_thongtinlienquan.Text;
                float gia = float.Parse(txt_giasanpham.Text);
                //thuc hien thao tac sửa dia 
                lg.suadia_GUI_nhanvien_quanlidia(ID, tendia, ngaynhapdia, soluong, thongtinlienquan, gia);
                //thong bao thanh cong 
                MessageBox.Show("CHÚC MỪNG!!!SỬA THÔNG TIN ĐĨA THÀNH CÔNG");
            }
            catch
            {
                MessageBox.Show("VUI LÒNG KIỂM TRA LẠI THÔNG TIN ĐĨA!!!");
            }
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* đổ thông tin được chọn lên các control*/
            //lấy datagridview đc chọn
            DataGridViewRow dgv_row = dataGridView1.SelectedRows[0];
            //đổ dữ liệu
            txt_iddia.Text = dgv_row.Cells["ID"].Value.ToString();
            txt_tendia.Text = dgv_row.Cells["TEN"].Value.ToString();
            txt_ngaynhapdia.Text = dgv_row.Cells["NGAYNHAPDIA"].Value.ToString();
            txt_soluongdia.Text = dgv_row.Cells["SOLUONG"].Value.ToString();
            richtxt_thongtinlienquan.Text = dgv_row.Cells["THONGTINLIENQUAN"].Value.ToString();
            txt_giasanpham.Text = dgv_row.Cells["GIA"].Value.ToString();
            cbo_loaidia.Text = dgv_row.Cells["LOAIDIA"].Value.ToString();

            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(dgv_row.Cells["HINHANHPHIM"].Value));
            pictureBox1.Image = x;
        }

        private void btn_chenanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;

            }
        }
    }
}
    