namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIA")]
    public partial class DIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIA()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYNHAPDIA { get; set; }

        public int? SOLUONG { get; set; }

        public string THONGTINLIENQUAN { get; set; }

        public double? GIA { get; set; }

        public string LOAIDIA { get; set; }

        public string DOANGIOITHIEU { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANHPHIM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
    }
}
