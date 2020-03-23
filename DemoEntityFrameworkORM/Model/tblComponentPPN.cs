namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentPPN")]
    public partial class tblComponentPPN
    {
        [Key]
        public int FPinID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHeadDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThreadDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FTotalLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHeadThick { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
