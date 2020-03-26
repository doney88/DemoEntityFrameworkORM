namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentHingeFS")]
    public partial class tblComponentHingeF
    {
        [Key]
        public int FHingeFSID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPadWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPadLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHingeWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHeight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHoleDiameter { get; set; }

        [StringLength(2)]
        public string FHingeType { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
