namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int HOADON_ID { get; set; }

        public int? DONHANG_ID { get; set; }

        public virtual DONHANG DONHANG { get; set; }
    }
}
