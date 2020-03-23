namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderSub")]
    public partial class tblOrderSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderSub()
        {
            tblOrderPrintingInfoSubs = new HashSet<tblOrderPrintingInfoSub>();
            tblOrderShipBatchSubs = new HashSet<tblOrderShipBatchSub>();
            tblPDTWHInTemps = new HashSet<tblPDTWHInTemp>();
            tblPDTWHIns = new HashSet<tblPDTWHIn>();
            tblPDTWHTemps = new HashSet<tblPDTWHTemp>();
            tblProductionPlans = new HashSet<tblProductionPlan>();
            tblPDTWHs = new HashSet<tblPDTWH>();
            tblOrderSubBOMs = new HashSet<tblOrderSubBOM>();
            tblProductions = new HashSet<tblProduction>();
        }

        [Key]
        public int FSKUID { get; set; }

        public int FOrderID { get; set; }

        public byte? FSerial { get; set; }

        public int FMaterialID { get; set; }

        [StringLength(255)]
        public string FModelCust { get; set; }

        [Required]
        [StringLength(50)]
        public string FColorCust { get; set; }

        [StringLength(9)]
        public string FSizePrint { get; set; }

        public short FQty { get; set; }

        public short? FQtyInput { get; set; }

        public int? FQtyYield { get; set; }

        public short FQtyShip { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FAmount { get; set; }

        public bool FVAT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? FBalancePercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? FMaterialAmount { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? FQtyBalance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? FQtyYieldBalance { get; set; }

        [StringLength(255)]
        public string FModelPrint { get; set; }

        public bool FFinishSKU { get; set; }
        public string FItem { get; set; }
        public int FFlag { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfoSub> tblOrderPrintingInfoSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderShipBatchSub> tblOrderShipBatchSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHInTemp> tblPDTWHInTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHIn> tblPDTWHIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHTemp> tblPDTWHTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionPlan> tblProductionPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWH> tblPDTWHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOM> tblOrderSubBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduction> tblProductions { get; set; }
    }
}
