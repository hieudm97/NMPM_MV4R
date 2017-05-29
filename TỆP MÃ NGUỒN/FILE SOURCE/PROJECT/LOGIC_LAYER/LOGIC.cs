
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.LOGIC_LAYER
{
    public class LOGIC
    {
        //member 
        DB db = new DB();
        //func
        internal bool kiemtrataikhoan_GUI_dkdn_dn(string tendangnhap, string matkhau)
        {

            bool flag = false;
            KHACHHANG kh =  db.KHACHHANGs.Where(khach => khach.TENDANGNHAP == tendangnhap).First();
            if (kh == null)
            {
                flag = false;
            }
            else
            {
                if(kh.MATKHAU == matkhau)
                {
                    flag = true;
                }
            }
            return flag;

        }

        internal string laytenphim_GUI_KH_CTSP(int dia_id)
        {
            //  throw new NotImplementedException();
            DIA dia = db.DIAs.Find(dia_id);
            return dia.TEN;
        }

        internal string laylinktrailercuaphim_GUI_KH_CTSP(int dia_id)
        {
            // throw new NotImplementedException();
            DIA dia = db.DIAs.Where(d => d.ID == dia_id).First();
            return dia.DOANGIOITHIEU;
        }

        internal int kiemtrasoluongdiaphim_GUI_KH_CTSP(int dia_id)
        {
            //  throw new NotImplementedException();
            return (int)db.DIAs.Where(dia => dia.ID == dia_id).First().SOLUONG;
        }

        internal string laygiasanpham_GUI_KH_CTSP(int dia_id)
        {
            //  throw new NotImplementedException();
            return db.DIAs.Where(dia => dia.ID == dia_id).First().GIA.ToString();
        }

        internal string layloaidiaphim_GUI_KH_CTSP(int dia_id)
        {
            // throw new NotImplementedException();
            return db.DIAs.Where(dia => dia.ID == dia_id).First().LOAIDIA;
        }

        internal Image layhinhdaidiencuaphim_GUI_KH_CTSP(int dia_id)
        {
            // throw new NotImplementedException();
            DIA dia = db.DIAs.Where(d => d.ID == dia_id).First();
            Byte[] data = new Byte[0];
            data = (Byte[])(dia.HINHANHPHIM);
            MemoryStream mem = new MemoryStream(data);
            return Image.FromStream(mem);

        }

        internal string laythongtinphim_GUI_KH_CTSP(int dia_id)
        {
            //  throw new NotImplementedException();
            DIA dia = db.DIAs.Find(dia_id);
            return dia.THONGTINLIENQUAN;
        }

        internal IEnumerable<DIA> laydsdia_GUI_KHACHANG_GIAODIENCHINH()
        {
            // throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs;
            return ds_dia; 
        }

        internal IEnumerable<object> laythongtinchochitiethoadon_GUI_NV_QLHD_INHOADON(int donhang_id)
        {
            //hrow new NotImplementedException();
            var chitiethoadon = from hoadon in db.HOADONs
                                join donhang in db.DONHANGs on hoadon.DONHANG_ID equals donhang.DONHANG_ID
                                where hoadon.DONHANG_ID == donhang_id
                                select new
                                {
                                    mahoadon = hoadon.HOADON_ID,
                                    madonhang = donhang.DONHANG_ID,
                                    tongtien = donhang.TONGTIEN
                                };
            return chitiethoadon.ToList(); 
        }

        internal IEnumerable<object> hienthichitietdonhangtrongdonhang_GUI_QLDH_formxemctdh(int donhang_id)
        {
            //throw new NotImplementedException();
            var chitietdonhang = from chitiet in db.CHITIETDONHANGs
                                 join dia in db.DIAs on chitiet.DIA_ID equals dia.ID
                                 where chitiet.DONHANG_ID == donhang_id
                                 select new
                                 {
                                     dia.TEN,
                                     chitiet.SOLUONGDIAMUA,
                                     dia.GIA
                                 };
             
                                         
            return chitietdonhang.ToList(); 
        }

        internal bool kiemtrataikhoannhanvien_GUI_dkdn_dn(string tendangnhap, string matkhau)
        {
            // throw new NotImplementedException();
            bool flag = false;
            NHANVIEN nv = db.NHANVIENs.Where(nhanvien => nhanvien.TENDANGNHAP == tendangnhap).First();
            if(nv == null)
            {
                flag = false;
            }
            else
            {
                if(nv.MATKHAU == matkhau)
                {
                    flag = true;
                }
            }
            return flag;
            
        }

        internal IEnumerable<KHACHHANG> timkhachhangtheomakh_GUI_nhanvien_quanlikh(int makh)
        {
            //  throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs.Where(kh => kh.ID == makh);
            return ds_kh; 
        }

        internal IEnumerable<HOADON> timkiemhoadontheomahoadon_GUI_nhanvien_QLHD(int mahoadon)
        {
            // throw new NotImplementedException();
            IEnumerable<HOADON> ds_hd = db.HOADONs.Where(hd => hd.HOADON_ID == mahoadon);
            return ds_hd;

        }

        internal string laydiachikhachhang(string tendangnhap)
        {
            //  throw new NotImplementedException();
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().DIACHI;
        }

        internal float kiemtraloaithanhviendethanhtoan_GUI_cust_donhang(string tendangnhap)
        {
            //  throw new NotImplementedException();
            //tìm khách hàng
            KHACHHANG khach = db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First();
            string loaikhachhang = khach.LOAITHANHVIEN;
            float tienuudai = 0;
            switch (loaikhachhang)
            {
                case "THƯỜNG":
                    tienuudai = (float)(0.1);
                    break;
                case "THÂN THUỘC":
                    tienuudai = (float)(0.15);
                    break;
                case "VIP":
                    tienuudai = (float)(0.2);
                    break; 
            }
            return tienuudai;

        }

        internal string laydiachikhachang_GUI_cust_donhang(string tendangnhap)
        {
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().DIACHI.ToString();
        }

        internal string layloaithanhvienkhachang_GUI_cust_donhang(string tendangnhap)
        {
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().LOAITHANHVIEN.ToString();
        }

        internal string laytencongtykhachang_GUI_cust_donhang(string tendangnhap)
        {
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().TENCONGTY.ToString();
        }

        internal string laytuoikhachang_GUI_cust_donhang(string tendangnhap)
        {
            // throw new NotImplementedException();
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().TUOI.ToString();
        }

        internal int laysoluongdiacontontaitrongkhodia_GUI_KH_gdql(int ma_id)
        {
            //   throw new NotImplementedException();
            DIA dia = db.DIAs.Find(ma_id);
            return (int)dia.SOLUONG;
        }

        internal IEnumerable<KHACHHANG> timkiemkhachhangtheotenkhachhang_GUI_nhanvien_quanlikh(string tenkhachhang)
        {
            // throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs.Where(kh => kh.TEN == tenkhachhang);
            return ds_kh;
        }

        internal IEnumerable<DIA> timkiemtheophanloaisanpham_GUI_KH(string text)
        {
            //throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.Where(dia => dia.LOAIDIA == text);
            return ds_dia; 
        }

        internal IEnumerable<KHACHHANG> timkiemkhachhangtheotuoikhachhang_GUI_nhanvien_quanlikh(int tuoi)
        {
            // throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs.Where(kh => kh.TUOI == tuoi);
            return ds_kh;
        }

        internal IEnumerable<object> hienthidshoadon_GUI_nhanvien_QLHD()
        {
            // throw new NotImplementedException();
            var ds_hd = from hoadon in db.HOADONs
                        join donhang in db.DONHANGs on hoadon.DONHANG_ID equals donhang.DONHANG_ID
                        select new
                        {
                            hoadon.HOADON_ID,
                            donhang.DONHANG_ID,
                            donhang.TONGTIEN
                        };
            return ds_hd.ToList();
           
           
        }

        internal IEnumerable<KHACHHANG> timkiemkhachhangtheotendangnhapkhachhang_GUI_nhanvien_quanlikh(string tendangnhap)
        {
            // throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap);
            return ds_kh;
        }

        internal IEnumerable<DIA> laydanhsachtatcacacdiagiatang_GUI_KH()
        {
            //  throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.OrderBy(dia => dia.GIA);
            return ds_dia;
        }

        internal void xoabotsodiakhachmua_GUI_QLDONHANG(int donhang_id)
        {
            //   throw new NotImplementedException();
            /* lấy ra một tập các đĩa đã mua trong bảng CHITIETHOADON */
            IEnumerable<CHITIETDONHANG> ds_ctdh = db.CHITIETDONHANGs.Where(ctdh => ctdh.DONHANG_ID == donhang_id);
            #region
            //foreach (var cthd in ds_ctdh)
            //{
            //    //tìm thằng đĩa_id tương ứng 
            //    DIA dia = db.DIAs.Where(d => d.ID == cthd.DIA_ID).First();
            //    //xóa số lượng đĩa 
            //    dia.SOLUONG = dia.SOLUONG  -  cthd.SOLUONGDIAMUA;
            //    //cập nhật
            //    db.SaveChanges(); 
            //}
            #endregion
            for (int i = 0; i < ds_ctdh.Count(); i++)
            {
                CHITIETDONHANG ctdh = ds_ctdh.ElementAt(i);
                //tìm thằng đĩa_id tương ứng 
                DIA dia = db.DIAs.Where(d => d.ID == ctdh.DIA_ID).First();
                //xóa số lượng đĩa 
                dia.SOLUONG = dia.SOLUONG - ctdh.SOLUONGDIAMUA;
                //cập nhật
                db.SaveChanges();
            }
        }

        internal IEnumerable<DIA> laydanhsachtatcacacdiagiagiam_GUI_KH()
        {
            // throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.OrderByDescending(dia => dia.GIA);
            return ds_dia;
        }

        internal IEnumerable<object> timkiemsanpham_GUI_KH_giaodienchinh(string timkiem)
        {
            // throw new NotImplementedException();
            var ds_dia = from dia in db.DIAs
                         where dia.TEN.Contains(timkiem)
                         select dia;
            return ds_dia;
        }

        internal void luudonhangvuaduocxacnhanvaobanghoadon_GUI_QLDONHANG(int donhang_id)
        {
            // throw new NotImplementedException();
            HOADON hd = new HOADON();
            hd.DONHANG_ID = donhang_id;
            db.HOADONs.Add(hd);
            db.SaveChanges();
        }

        internal IEnumerable<KHACHHANG> timkiemkhachhangtheoloaikhachhang_GUI_nhanvien_quanlikh(string loaithanhvien)
        {
           // throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs.Where(kh => kh.LOAITHANHVIEN == loaithanhvien);
            return ds_kh;
        }

        internal string laytennguoidung_GUI_khachhang_giaodienchinh(string tendangnhap)
        {
            // throw new NotImplementedException();
            KHACHHANG kh = db.KHACHHANGs.Where(kha => kha.TENDANGNHAP == tendangnhap).First();
            return kh.TEN; 
        }

        internal IEnumerable<DONHANG> timdonhangtheomadonhang_GUI_QLDONHANG(int madonhang)
        {
            //  throw new NotImplementedException();
            IEnumerable<DONHANG> ds_donhang = db.DONHANGs.Where(dh => dh.DONHANG_ID == madonhang);
            return ds_donhang;
        }

        internal void themchitietdonhangvaobangchitietdonhang(int madonhang, Dictionary<int, int> danhsachdiavasoluong)
        {
            //throw new NotImplementedException();
            foreach (KeyValuePair<int, int> diavasoluong in danhsachdiavasoluong)
            {
                //lưu vào trong ds đơn hàng 
                //khởi tạo thông tin cần thiết
                CHITIETDONHANG ctdh = new CHITIETDONHANG();
                ctdh.DONHANG_ID = madonhang;
                ctdh.DIA_ID = diavasoluong.Key;
                ctdh.SOLUONGDIAMUA = diavasoluong.Value;
                //lưu vào đơn hàng
                db.CHITIETDONHANGs.Add(ctdh);
                db.SaveChanges(); 
            }

        }

        internal bool kiemtratendangnhap(string tENDANGNHAP)
        {
            // throw new NotImplementedException();
            int dem = db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tENDANGNHAP).Count();
            if(dem == 0 )
            {
                return false;
            }
            return false;
        }

        internal void xoadonhangkhoibangchitietdonhang_GUI_QLDONHANG(int donhang_id)
        {
            // throw new NotImplementedException();
            IEnumerable<CHITIETDONHANG> ds_chitietdonhang = db.CHITIETDONHANGs.Where(ctdh => ctdh.DONHANG_ID == donhang_id);
            db.CHITIETDONHANGs.RemoveRange(ds_chitietdonhang);
        }   

        internal IEnumerable<DIA> timsanpham_GUI_khachhang_giaodienchinh(string tensanpham)
        {
            // throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.Where(dia => dia.TEN == tensanpham);
            return ds_dia;
        }

        internal int themthanhvien_GUI_dkdn_dangky(string hovaten, 
            int tuoi, DateTime ngaysinh, string tencongty, string diachi,
            string tendangnhap, string matkhau)
        {
            // throw new NotImplementedException();
            if(db.KHACHHANGs.Where(kh=>kh.TENDANGNHAP == tendangnhap).Count() >= 1)
            {
                return 0;
            }
            //TẠO KHÁCH HÀNG MỚI
            else
            {
                KHACHHANG kh = new KHACHHANG();
                kh.TEN = hovaten;
                kh.TUOI = tuoi;
                kh.NGAYSINH = ngaysinh;
                kh.TENCONGTY = tencongty;
                kh.TENDANGNHAP = tendangnhap;
                kh.MATKHAU = matkhau;
                kh.DIACHI = diachi;
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                return 1;
            }
           

        }

        internal void themkhachhang_GUI_nhanvien_quanlikh(string tEN, int tUOI, DateTime nGAYSINH, 
            string tENCONGTY, string tENDANGNHAP, string mATKHAU, string lOAITHANHVIEN)
        {
            //  throw new NotImplementedException();
            KHACHHANG kh = new KHACHHANG();
            kh.TEN = tEN;
            kh.TUOI = tUOI;
            kh.NGAYSINH = nGAYSINH;
            kh.TENCONGTY = tENCONGTY;
            kh.TENDANGNHAP = tENDANGNHAP;
            kh.MATKHAU = mATKHAU;
            kh.LOAITHANHVIEN = lOAITHANHVIEN;
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }

        internal void xoakhachhang_GUI_nhanvien_quanlikh(int makhachhang)
        {
            //  throw new NotImplementedException();
            KHACHHANG kh = db.KHACHHANGs.Where(kha => kha.ID == makhachhang).First();
            db.KHACHHANGs.Remove(kh);
            db.SaveChanges();
        }

        internal IEnumerable<DONHANG> timdonhangtheotrangthai_GUI_QLDONHANG(string trangthaidonhang)
        {

           // throw new NotImplementedException();
           //xác định là T/F: xác nhận rồi -> T / chưa xác nhận -> F
           if(trangthaidonhang == "XÁC NHẬN")
            {
                trangthaidonhang = "True";
            }
           else
            {
                trangthaidonhang = "False";
            }

            if (trangthaidonhang == "False")
            {
                //hiển thị các đơn hàng chưa được xử lý
                IEnumerable<DONHANG> ds_donhang = from dh in db.DONHANGs
                                                  join dhxl in db.DONHANGCANXULies on dh.DONHANG_ID equals dhxl.DONHANG_ID
                                                  where dhxl.TRANGTHAIDONHANG == false
                                                  select dh;
                return ds_donhang;
            }
            else
            {

                IEnumerable<DONHANG> ds_donhang = from dh in db.DONHANGs
                                                  join dhxl in db.DONHANGCANXULies on dh.DONHANG_ID equals dhxl.DONHANG_ID
                                                  where dhxl.TRANGTHAIDONHANG == true
                                                  select dh;
                return ds_donhang;


                 }

            }

        internal void suakhachhang_GUI_nhanvien_quanlikh(int iD, string tEN, int tUOI,
            DateTime nGAYSINH, string tENCONGTY, string tENDANGNHAP,
            string mATKHAU, string lOAITHANHVIEN)
        {
            // throw new NotImplementedException();
            KHACHHANG kh = db.KHACHHANGs.Where(kha => kha.ID == iD).First();
            kh.TEN = tEN;
            kh.TUOI = tUOI;
            kh.NGAYSINH = nGAYSINH;
            kh.TENCONGTY = tENCONGTY;
            kh.TENDANGNHAP = tENDANGNHAP;
            kh.MATKHAU = mATKHAU;
            kh.LOAITHANHVIEN = lOAITHANHVIEN;
            db.SaveChanges();

        }

        internal IEnumerable<KHACHHANG> laydskhachhang_GUI_nhanvien_quanlikh()
        {
            // throw new NotImplementedException();
            IEnumerable<KHACHHANG> ds_kh = db.KHACHHANGs;
            return ds_kh;
        }

        internal void chuyendoitrangthaidonhangthanhdaxuly_GUI_QLDONHANG(int donhang_id)
        {
            // throw new NotImplementedException();
            DONHANGCANXULY donhangxl = db.DONHANGCANXULies.Where(dhxl => dhxl.DONHANG_ID == donhang_id).First();
            donhangxl.TRANGTHAIDONHANG = true;
            db.SaveChanges();
        }

        internal bool kiemtratrangthaidonhang_GUI_QLDONHANG(int donhang_id)
        {
            //  throw new NotImplementedException();
            DONHANGCANXULY donhangxl = db.DONHANGCANXULies.Where(dhxl => dhxl.DONHANG_ID == donhang_id).First();
            bool trangthaidonhang = (bool)donhangxl.TRANGTHAIDONHANG;
            return trangthaidonhang;
        }

        internal void xoadonhangkhoibangdonhang_GUI_QLDONHANG(int donhang_id)
        {
            // throw new NotImplementedException();
            DONHANG dh = db.DONHANGs.Where(dhang => dhang.DONHANG_ID == donhang_id).First();
            db.DONHANGs.Remove(dh);
            db.SaveChanges();
        }

        internal void xoadonhangkhoibangtrangthaidonhang_GUI_QLDONHANG(int donhang_id)
        {
            //   throw new NotImplementedException();
            DONHANGCANXULY dhxl = db.DONHANGCANXULies.Where(dh => dh.DONHANG_ID == donhang_id).First();
            db.DONHANGCANXULies.Remove(dhxl);
            db.SaveChanges();
        }

        internal IEnumerable<DIA> laydanhsachdiatheotendia_GUI_nhanvien_quanlidia(string tendia)
        {
            // throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.Where(dia => dia.TEN == tendia);
            return ds_dia; 
        }

        internal IEnumerable<object> laydsdonhang_GUI_QLDONHANG()
        {
            //throw new NotImplementedException();
            var qry = from dh in db.DONHANGs
                      from dhxl in db.DONHANGCANXULies
                      where dh.DONHANG_ID == dhxl.DONHANG_ID
            select new
                      {
                          dh.DONHANG_ID,
                          dh.NGAYKHOITAO,
                          dh.KHACHHANG_ID,
                          dh.NHANVIEN_ID,
                          dh.TONGTIEN,
                          dhxl.TRANGTHAIDONHANG
                      };
            return qry.ToList();
        }

        internal IEnumerable<DIA> laydanhsachdiatheogia_GUI_nhanvien_quanlidia(float gia)
        {
            // throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.Where(dia => dia.GIA == gia);
            return ds_dia;
        }

        internal IEnumerable<DIA> laydanhsachdiatheoid_GUI_nhanvien_quanlidia(int dia_id)
        {
            //  throw new NotImplementedException();
            IEnumerable<DIA> ds_dia = db.DIAs.Where(dia => dia.ID == dia_id);
            return ds_dia;
        }

        internal string layngaunhienidnv_GUI_cust_donhang()
        {
            int min = 1; 
                int max = db.NHANVIENs.Count();
            Random rd = new Random();
            return rd.Next(min, max).ToString();
            
            //throw new NotImplementedException();
            
        }

        internal string laytenkhachang_GUI_cust_donhang(string tendangnhap)
        {
            //throw new NotImplementedException();
            KHACHHANG kh = db.KHACHHANGs.Where(kha => kha.TENDANGNHAP == tendangnhap).First();
            return kh.TEN;
        }

        internal int laymakhachang_GUI_cust_donhang(string tendangnhap)
        {
            //throw new NotImplementedException();
            return db.KHACHHANGs.Where(kh => kh.TENDANGNHAP == tendangnhap).First().ID;
        }

        internal void themdia_GUI_nhanvien_quanlidia(string tendia, DateTime ngaynhapdia, 
            int soluong, string thongtinlienquan, float gia,string loaidia, Image hinhanhdia)
        {
            //   throw new NotImplementedException();
            DIA dia = new DIA();
            dia.TEN = tendia;
            dia.NGAYNHAPDIA = ngaynhapdia;
            dia.SOLUONG = soluong;
            dia.THONGTINLIENQUAN = thongtinlienquan;
            dia.GIA = gia;
            dia.LOAIDIA = loaidia;

            ImageConverter _imageConverter = new ImageConverter();
            byte[] hinhanh = (byte[])_imageConverter.ConvertTo(hinhanhdia, typeof(byte[]));
            dia.HINHANHPHIM = hinhanh;
            db.DIAs.Add(dia);
            db.SaveChanges(); 
        }

        internal IEnumerable<DIA> laydsdia_GUI_nhanvien_quanlidia()
        {
            //  throw new NotImplementedException();
            /* HIỂN THỊ DANH SÁCH ĐĨA TRONG HỆ THỐNG*/
            IEnumerable<DIA> ds_dia = db.DIAs;
            return ds_dia;
        }

        internal int laymaidnhanvien_GUI_cust_donhang(string text)
        {
            throw new NotImplementedException();
        }

        internal void themvaodonhang(DateTime ngaykhoitao, int khachhang_id, int nhanvien_id, float tongtien,string diachigiaohang)
        {
            // throw new NotImplementedException();
            DONHANG dh = new DONHANG();
            dh.NGAYKHOITAO = ngaykhoitao;
            dh.KHACHHANG_ID = khachhang_id;
            dh.NHANVIEN_ID = nhanvien_id;
            dh.TONGTIEN = tongtien;
            dh.DIACHI = diachigiaohang;
            db.DONHANGs.Add(dh);
            db.SaveChanges();
        }

        internal int laymadonhangmoinhat__GUI_cust_donhang()
        {
            //  throw new NotImplementedException();
            /* giúp lấy đơn hàng vừa import vào hệ thống*/
            return db.DONHANGs.Max(dh => dh.DONHANG_ID);
        }

        internal void themvaotrangthaidonhang(int madonhang, DateTime ngaykhoitao
            , bool trangthaidonhang)
        {
            // throw new NotImplementedException();
            DONHANGCANXULY dhxl = new DONHANGCANXULY();
            dhxl.DONHANG_ID = madonhang;
            dhxl.NGAYDATHANG = ngaykhoitao;
            dhxl.TRANGTHAIDONHANG = trangthaidonhang;
            db.DONHANGCANXULies.Add(dhxl);
            db.SaveChanges(); 
        }

        internal void xoadia_GUI_nhanvien_quanlidia(int dia_id)
        {
            //  throw new NotImplementedException();
            DIA dia = db.DIAs.Where(d => d.ID == dia_id).First();
            db.DIAs.Remove(dia);
            db.SaveChanges();
        }

        internal void suadia_GUI_nhanvien_quanlidia(int ID , string tendia, DateTime ngaynhapdia, 
            int soluong, string thongtinlienquan, float gia)
        {
            //  throw new NotImplementedException();
            DIA dia = db.DIAs.Where(d => d.ID == ID).First();
            dia.TEN = tendia;   
            dia.NGAYNHAPDIA = ngaynhapdia;
            dia.SOLUONG = soluong;
            dia.THONGTINLIENQUAN = thongtinlienquan;
            dia.GIA = gia;
            db.SaveChanges();
        }
      
    }
}
