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

namespace PROJECT.GUI.nhanvien.QUANLIHOADON
{
    public partial class quanlihdon : UserControl
    {
        //meme
        LOGIC lg = new LOGIC();
        //func  
        public quanlihdon()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///*Thực hiện hiển thị ra một form mới với đầy đủ chi tiết hóa đơn với dạng CRYSTAL REPORT*/
            //int donhang_id = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            //nhanvien.QUANLIHOADON.INHOADON frm_xuathoadon = new INHOADON(donhang_id);
            //frm_xuathoadon.Show(); 
            QUANLIHOADON.INHOADON frm_inhoadon = new INHOADON();
            frm_inhoadon.Show(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*tim kiem dua vao loai tim kiem trong combox tim kiem */
            string loaitimkiem = comboBox1.Text;

            //bat dau tim kiem
            switch (loaitimkiem)
            {

                case "MÃ HÓA ĐƠN":
                    //tim kiem thong tin theo MÃ HÓA ĐƠN
                    int mahoadon = int.Parse(dataGridView1.SelectedRows[0].Cells["HOADON_ID"].Value.ToString());
                    dataGridView1.DataSource = lg.timkiemhoadontheomahoadon_GUI_nhanvien_QLHD(mahoadon).ToList();
                    break;
                case "TỔNG TIỀN":
                    //tim kiem thong tin theo TỔNG TIỀN
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Hiển thị danh sách hóa đơn lên datagridview*/
            dataGridView1.DataSource = lg.hienthidshoadon_GUI_nhanvien_QLHD();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* đổ thông tin được chọn lên các control*/
        }
    }
}
