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

namespace PROJECT.GUI.nhanvien.QUANLIDONHANG
{
    public partial class formxemchitietdonhang : Form
    {
        //meme
        LOGIC lg = new LOGIC();
        int donhang_id;
        //func
        public formxemchitietdonhang(int donhang_id)
        {
            this.donhang_id = donhang_id;
            InitializeComponent();
            khoitaodatagrid();
            
        }
        private void khoitaodatagrid()
        {
            MessageBox.Show("BẠN VỪA CHỌN XEM THÔNG TIN CHI TIẾT ĐƠN HÀNG: MÃ ĐƠN HÀNG " + donhang_id.ToString());
            dataGridView1.DataSource = lg.hienthichitietdonhangtrongdonhang_GUI_QLDH_formxemctdh(donhang_id);

        }
    }
}
