namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THOIKHOABIEU")]
    public partial class THOIKHOABIEU
    {
        [StringLength(5)]
        public string id { get; set; }

        [StringLength(5)]
        public string id_giaovien { get; set; }

        [StringLength(5)]
        public string id_monhoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayday { get; set; }

        public byte? tietbatdau { get; set; }

        public byte? tietketthuc { get; set; }

        [StringLength(10)]
        public string ten_lop { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual MONHOC MONHOC { get; set; }
    }
}
