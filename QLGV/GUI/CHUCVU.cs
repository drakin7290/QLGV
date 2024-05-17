namespace GUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVU")]
    public partial class CHUCVU
    {
        [StringLength(25)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
