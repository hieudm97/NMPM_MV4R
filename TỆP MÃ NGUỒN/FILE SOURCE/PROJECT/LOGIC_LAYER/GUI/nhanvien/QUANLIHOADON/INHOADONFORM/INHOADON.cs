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
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace PROJECT.GUI.nhanvien.QUANLIHOADON
{
    public partial class INHOADON : Form
    {
        //mem
        LOGIC lg = new LOGIC();
      
        //func
        public INHOADON()
        {
          
            InitializeComponent();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void INHOADON_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(@"C:\Users\Asus\Desktop\ĐỒ ÁN\Đồ án trường\Phần mêm\ĐỒ ÁN CUỐI KÌ THỰC HÀNH - FILE EXE\DOAN_PM\FILE SOURCE\PROJECT\GUI\nhanvien\QUANLIHOADON\INHOADONFORM\CrystalReport1.rpt");
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch
            {
                MessageBox.Show("ĐANG XỬ LÝ..."); 
            }
            

        }
    }
}
