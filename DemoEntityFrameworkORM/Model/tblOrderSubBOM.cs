namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderSubBOM")]
    public partial class tblOrderSubBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderSubBOM()
        {
            tblMWHOuts = new HashSet<tblMWHOut>();
            tblMWHOutTemps = new HashSet<tblMWHOutTemp>();
            tblProcurementSubBOMs = new HashSet<tblProcurementSubBOM>();
        }

        [Key]
        public int FOrderBOMID { get; set; }

        public int FSKUID { get; set; }

        public int? FBOMID { get; set; }

        public int? FOrderProcessBOMID { get; set; }

        public int FMaterialID { get; set; }

        public int FSupplierID { get; set; }

        [Required]
        [StringLength(2)]
        public string FSource { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStockUSE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FPurchaseUSE { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FPurchased { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FConfirmDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyUsed { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyArrive { get; set; }

        [Column(TypeName = "money")]
        public decimal? FMaterialAmount { get; set; }

        public bool FIsLorR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FQtySpend { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FQtyScrap { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FQtyBalance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? FUsed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? FArrived { get; set; }

        public virtual tblBOM tblBOM { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOut> tblMWHOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOutTemp> tblMWHOutTemps { get; set; }

        public virtual tblOrderProcessBOM tblOrderProcessBOM { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }
    }
}
