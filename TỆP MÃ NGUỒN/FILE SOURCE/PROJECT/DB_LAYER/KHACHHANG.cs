namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            DONHANGs = new HashSet<DONHANG>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? TUOI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        public string TENCONGTY { get; set; }

        public string TENDANGNHAP { get; set; }

        public string MATKHAU { get; set; }

        public string LOAITHANHVIEN { get; set; }

        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
