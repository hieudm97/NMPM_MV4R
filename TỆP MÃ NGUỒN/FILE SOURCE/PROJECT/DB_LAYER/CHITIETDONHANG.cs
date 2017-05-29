namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DIA_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DONHANG_ID { get; set; }

        public int? SOLUONGDIAMUA { get; set; }

        public virtual DIA DIA { get; set; }

        public virtual DONHANG DONHANG { get; set; }
    }
}
