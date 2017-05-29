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

namespace PROJECT
{
    public partial class Form1 : Form
    {
        //mem
        LOGIC lg = new LOGIC();
        //func 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_themthanhvien_Click(object sender, EventArgs e)
        {
           try
            {
                /* thực hiện thao tác thêm thành viên vào trong DB*/
                //khởi tạo thông tin thành viên
                string hovaten = txt_hoten.Text;
                int tuoi = int.Parse(txt_tuoi.Text);
                DateTime ngaysinh = DateTime.ParseExact(txt_ngaysinh.Text, "ddMMyyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);
                string tencongty = txt_tencongty.Text;
                string tendangnhap = txt_tendangnhap.Text;
                string matkhau = txt_matkhau.Text;
                string diachi = txt_diachi.Text;
                //thực hiện thao tác thêm
                if (lg.themthanhvien_GUI_dkdn_dangky(hovaten, tuoi, ngaysinh,
                    tencongty, diachi, tendangnhap, matkhau) == 1)
                {
                    //thông báo
                    MessageBox.Show("CHÚC MỪNG BẠN ĐÃ ĐĂNG KÝ THÀNH CÔNG!!!");
                }
                else
                {
                    //thông báo 
                    MessageBox.Show("XIN LỖI KHÔNG THỂ ĐĂNG KÝ!!!");
                }
            }
            catch
            {
                MessageBox.Show("VUI LÒNG KIỂM TRA LẠI THÔNG TIN NHẬP!!!");
            }
                
           
        }
    }
}
