namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentHinge")]
    public partial class tblComponentHinge
    {
        [Key]
        public int FHingeID { get; set; }

        public int FComponentID { get; set; }

        [StringLength(2)]
        public string FHingeType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPadWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPadLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHingeWidth { get; set; }

        public byte FAngle { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCoreHeight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateDate { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
