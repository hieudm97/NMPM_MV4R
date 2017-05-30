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

namespace PROJECT.GUI.dangkidangnhap
{
    public partial class dangnhap : Form
    {
        //mem
        LOGIC lg = new LOGIC(); 
        //func
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
           
                
        }

        private void lkl_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hien thi form dang ki 
            Form1 frm_dangki = new Form1();
            frm_dangki.Show();  

        }

        private void btn_dangnhap_Click_1(object sender, EventArgs e)
        {
            /*Thực hiện đăng nhập vào hệ thống*/

            //kiem tra thong tin 
            string tendangnhap = txt_tendangnhap.Text;
            string matkhau = txt_matkhau.Text;
            if(comboBox1.Text == "ĐĂNG NHẬP KHÁCH HÀNG")
            {
                try
                {
                    if (lg.kiemtrataikhoan_GUI_dkdn_dn(tendangnhap, matkhau) == true)
                    {
                        //hien thi form
                        this.Hide();
                        khachhang.giaodienchinh frm_giaodienchinh = new khachhang.giaodienchinh(tendangnhap);
                        frm_giaodienchinh.Show();
                        
                    }
                    else
                    {

                        DialogResult ketqua = MessageBox.Show("MUỐN THỬ LẠI", "LỖI ĐĂNG NHẬP", MessageBoxButtons.YesNo);
                        //neu yes => clear/
                        if (ketqua == DialogResult.Yes)
                        {
                            txt_matkhau.Text = "";
                        }
                        else
                        {
                            //exit chuong trinh
                            MessageBox.Show("HEN GẶP LẠI!!!");
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("XEM LẠI THAO TÁC"); 
                }
               
            }
            else
            {
                if(comboBox1.Text == "ĐĂNG NHẬP NHÂN VIÊN")
                {
                    try
                    {
                        if (lg.kiemtrataikhoannhanvien_GUI_dkdn_dn(tendangnhap, matkhau) == true)
                        {
                            //hien thi form
                            this.Hide();
                            nhanvien.giaodienquanlichinh frm_giaodienchinh = new nhanvien.giaodienquanlichinh();
                            frm_giaodienchinh.Show();
                            
                        }
                        else
                        {

                            DialogResult ketqua = MessageBox.Show("MUỐN THỬ LẠI", "LỖI ĐĂNG NHẬP", MessageBoxButtons.YesNo);
                            //neu yes => clear
                            if (ketqua == DialogResult.Yes)
                            {
                                txt_tendangnhap.Text = "";
                                txt_matkhau.Text = "";
                            }
                            else
                            {
                                //exit chuong trinh
                                MessageBox.Show("HEN GẶP LẠI!!!");
                                Application.Exit();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("VUI LÒNG KIỂM TRA LẠI THAO TÁC"); 
                    }
                    }
                    
            }
        

        }
    }
}
