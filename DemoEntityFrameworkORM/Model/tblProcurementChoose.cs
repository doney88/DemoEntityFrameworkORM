namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurementChoose")]
    public partial class tblProcurementChoose
    {
        [Key]
        public int FProcurementChooseID { get; set; }

        public int FID { get; set; }

        public bool FCheck { get; set; }

        public int? FOrderID { get; set; }

        public int? FSKUID { get; set; }

        public int FSupplierID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FPurchaseUSE { get; set; }

        public bool FArrived { get; set; }

        public bool FPurchased { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FStockUSE { get; set; }

        [Required]
        [StringLength(2)]
        public string FSource { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Required]
        [StringLength(100)]
        public string FSourceTable { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
