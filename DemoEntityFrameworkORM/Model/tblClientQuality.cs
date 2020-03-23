namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientQuality")]
    public partial class tblClientQuality
    {
        [Key]
        public int FClientQualityID { get; set; }

        public int FClientID { get; set; }

        public int? FProcessID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        public virtual tblClient tblClient { get; set; }

        public virtual tblProcess tblProcess { get; set; }
    }
}
