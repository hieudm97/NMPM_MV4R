namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANGCANXULY")]
    public partial class DONHANGCANXULY
    {
        public int ID { get; set; }

        public int DONHANG_ID { get; set; }

        public bool? TRANGTHAIDONHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDATHANG { get; set; }

        public virtual DONHANG DONHANG { get; set; }
    }
}
