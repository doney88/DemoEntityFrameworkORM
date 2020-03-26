namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurementTemp")]
    public partial class tblProcurementTemp
    {
        [Key]
        public int FPListTempID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyRequire { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FStockUse { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
