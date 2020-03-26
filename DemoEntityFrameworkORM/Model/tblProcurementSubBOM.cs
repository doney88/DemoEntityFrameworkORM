namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurementSubBOM")]
    public partial class tblProcurementSubBOM
    {
        [Key]
        public int FProcurementBOMID { get; set; }

        public int? FOrderBOMID { get; set; }

        public int FPListID { get; set; }

        public int FMaterialID { get; set; }

        public int? FOrderPrintingMouldID { get; set; }

        public int? FOrderMouldID { get; set; }

        public int? FOrderBOMPackingID { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderMould tblOrderMould { get; set; }

        public virtual tblOrderPrintingMould tblOrderPrintingMould { get; set; }

        public virtual tblOrderSubBOM tblOrderSubBOM { get; set; }

        public virtual tblOrderSubBOMPacking tblOrderSubBOMPacking { get; set; }

        public virtual tblProcurementSub tblProcurementSub { get; set; }
    }
}
