namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentCore")]
    public partial class tblComponentCore
    {
        [Key]
        public int FCoreID { get; set; }

        public int FComponentID { get; set; }

        [Required]
        [StringLength(2)]
        public string FHingeType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHingeWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FHingeWidthTotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FCoreDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FBottomWidth { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
