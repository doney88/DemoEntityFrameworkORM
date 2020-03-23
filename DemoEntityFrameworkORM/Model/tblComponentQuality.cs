namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentQuality")]
    public partial class tblComponentQuality
    {
        [Key]
        public int FComponentQualityID { get; set; }

        public int FComponentID { get; set; }

        public int? FClientID { get; set; }

        public int? FProcessID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime FCreateDate { get; set; }

        public virtual tblClient tblClient { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblProcess tblProcess { get; set; }
    }
}
