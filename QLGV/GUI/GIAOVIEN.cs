namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVIEN")]
    public partial class GIAOVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOVIEN()
        {
            THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
        }

        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(3)]
        public string gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaysinh { get; set; }

        [Required]
        [StringLength(11)]
        public string sodienthoai { get; set; }

        [StringLength(30)]
        public string diachi { get; set; }

        public int? luong { get; set; }

        [StringLength(5)]
        public string id_monhoc { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
    }
}
