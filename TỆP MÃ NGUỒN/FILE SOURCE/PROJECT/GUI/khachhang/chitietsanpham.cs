using PROJECT.LOGIC_LAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.GUI.khachhang
{
    public partial class chitietsanpham : Form
    {
        //MEM
        LOGIC lg = new LOGIC();
        int dia_id; 
        //func 
        public chitietsanpham(int dia_id)
        {
            this.dia_id = dia_id;
            InitializeComponent();
            khoitaothongtin();
        }
        private void khoitaothongtin()
        {
            /*khởi tạo các thông tin cần thiết tương ứng với mỗi phim*/
            lbl_tuaphim.Text = lg.laytenphim_GUI_KH_CTSP(dia_id);
            richTextBox1.Text = lg.laythongtinphim_GUI_KH_CTSP(dia_id);
            pic_hinhphim.Image = lg.layhinhdaidiencuaphim_GUI_KH_CTSP(dia_id);
            axShockwaveFlash1.Movie = lg.laylinktrailercuaphim_GUI_KH_CTSP(dia_id);
            if(lg.kiemtrasoluongdiaphim_GUI_KH_CTSP(dia_id)>0)
            {
                txt_tinhtrangdonhang.Text = "CÒN HÀNG";
            }
            else
            {
                txt_tinhtrangdonhang.Text = "HẾT HÀNG";
            }
            txt_loaiphim.Text = lg.layloaidiaphim_GUI_KH_CTSP(dia_id);
            txt_giasp.Text = lg.laygiasanpham_GUI_KH_CTSP(dia_id)+" / 1 ĐĨA";


        }


        private void lbl_tuaphim_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
