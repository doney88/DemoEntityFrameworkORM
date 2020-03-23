namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderSubBOMPacking")]
    public partial class tblOrderSubBOMPacking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderSubBOMPacking()
        {
            tblProcurementSubBOMs = new HashSet<tblProcurementSubBOM>();
        }

        [Key]
        public int FOrderBOMPackingID { get; set; }

        public int FOrderID { get; set; }

        public int? FPackingTemplateSubID { get; set; }

        public int FMaterialID { get; set; }

        public int? FPackingMixTypeID { get; set; }

        public int FSupplierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStockUSE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPurchaseUSE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyArrive { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? FArrived { get; set; }

        public bool FPurchased { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FConfirmDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyUSE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? FUsed { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblPackingTemplateSub tblPackingTemplateSub { get; set; }

        public virtual tblPackingMixType tblPackingMixType { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }
    }
}
