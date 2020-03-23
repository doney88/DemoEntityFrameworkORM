namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHoliday")]
    public partial class tblHoliday
    {
        [Key]
        public int FDateRestID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [Required]
        [StringLength(10)]
        public string FHoliday { get; set; }

        public bool FWork { get; set; }
    }
}
