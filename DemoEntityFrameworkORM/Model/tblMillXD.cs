namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMillXD")]
    public partial class tblMillXD
    {
        [Key]
        public int FComponentXDID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FEdgeDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FEdgeLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FShankDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FTotalLength { get; set; }

        public byte FEdgeQty { get; set; }

        public int FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
