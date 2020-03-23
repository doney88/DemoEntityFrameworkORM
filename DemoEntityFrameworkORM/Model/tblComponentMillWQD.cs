namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentMillWQD")]
    public partial class tblComponentMillWQD
    {
        [Key]
        public int FWQDID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FBellyLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FBellyDiameter { get; set; }

        public byte FTotalLength { get; set; }

        public bool? FLeftHelix { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
