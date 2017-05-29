namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DONHANGs = new HashSet<DONHANG>();
            NHANVIEN1 = new HashSet<NHANVIEN>();
        }

        public int ID { get; set; }

        public string TENNHANVIEN { get; set; }

        public int? TUOI { get; set; }

        public string QUEQUAN { get; set; }

        public int? QUANLI_ID { get; set; }

        public string TENDANGNHAP { get; set; }

        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIEN1 { get; set; }

        public virtual NHANVIEN NHANVIEN2 { get; set; }
    }
}
