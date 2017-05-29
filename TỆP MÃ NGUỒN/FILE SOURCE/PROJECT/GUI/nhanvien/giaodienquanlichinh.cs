using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.GUI.nhanvien
{
    public partial class giaodienquanlichinh : Form
    {
        public giaodienquanlichinh()
        {
            Thread t = new Thread(new ThreadStart(starform));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort(); 
        }
        public void starform()
        {
            Application.Run(new GUI.dangkidangnhap.loadingnhanvien());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //hien thi user control quan li dia
            quanlidia uc_qldia = new quanlidia();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            //hien thi user control quan li dia
            quanlidia uc_qldia = new quanlidia();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //hien thi user control quan li hoa don 
            QUANLIHOADON.quanlihdon uc_qlhoadon = new QUANLIHOADON.quanlihdon();
            pn_display.Controls.Add(uc_qlhoadon);
            uc_qlhoadon.Dock = DockStyle.Fill;
            uc_qlhoadon.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //hien thi user control quan li hoa don
            QUANLIHOADON.quanlihdon uc_qlhoadon = new QUANLIHOADON.quanlihdon();
            pn_display.Controls.Add(uc_qlhoadon);
            uc_qlhoadon.Dock = DockStyle.Fill;
            uc_qlhoadon.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //hien thi user quan li khach hang 
            QUANLIKHACHHANG.quanlikhachhang uc_qldia = new QUANLIKHACHHANG.quanlikhachhang();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //hien thi user quan li khach hang 
            QUANLIKHACHHANG.quanlikhachhang uc_qldia = new QUANLIKHACHHANG.quanlikhachhang();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //hien thi user quan li don hang
           quanlidonhang uc_qldia = new quanlidonhang();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //hien thi user quan li don hang
            quanlidonhang uc_qldia = new quanlidonhang();
            pn_display.Controls.Add(uc_qldia);
            uc_qldia.Dock = DockStyle.Fill;
            uc_qldia.BringToFront();
        }

        private void giaodienquanlichinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
