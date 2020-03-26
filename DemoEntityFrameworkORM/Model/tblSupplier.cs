namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSupplier")]
    public partial class tblSupplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSupplier()
        {
            tblBOMs = new HashSet<tblBOM>();
            tblClaims = new HashSet<tblClaim>();
            tblComponents = new HashSet<tblComponent>();
            tblComponentBOMs = new HashSet<tblComponentBOM>();
            tblComponentSubs = new HashSet<tblComponentSub>();
            tblMaterials = new HashSet<tblMaterial>();
            tblMWHInBills = new HashSet<tblMWHInBill>();
            tblMWHInPBills = new HashSet<tblMWHInPBill>();
            tblOrderMoulds = new HashSet<tblOrderMould>();
            tblOrderPrintingMoulds = new HashSet<tblOrderPrintingMould>();
            tblOrderSubBOMs = new HashSet<tblOrderSubBOM>();
            tblOrderSubBOMPackings = new HashSet<tblOrderSubBOMPacking>();
            tblPDTWHBills = new HashSet<tblPDTWHBill>();
            tblPDTWHFreights = new HashSet<tblPDTWHFreight>();
            tblPDTWHInBills = new HashSet<tblPDTWHInBill>();
            tblPDTWHTemps = new HashSet<tblPDTWHTemp>();
            tblPDTWHTempFreights = new HashSet<tblPDTWHTempFreight>();
            tblPlateColors = new HashSet<tblPlateColor>();
            tblProcessSubs = new HashSet<tblProcessSub>();
            tblProcurementChooses = new HashSet<tblProcurementChoose>();
            tblProductions = new HashSet<tblProduction>();
            tblQuotationBOMs = new HashSet<tblQuotationBOM>();
        }

        [Key]
        public int FSupplierID { get; set; }

        [Required]
        [StringLength(5)]
        public string FSupplierNum { get; set; }

        public int FCat2ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FCompany { get; set; }

        [Required]
        [StringLength(10)]
        public string FShortName { get; set; }

        [StringLength(2)]
        public string FPaymentTerm { get; set; }

        [StringLength(50)]
        public string FMainProduct { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(255)]
        public string FWebSite { get; set; }

        public string FNote { get; set; }

        public bool FVATDefault { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FVATPercent { get; set; }

        [StringLength(50)]
        public string FBank { get; set; }

        [StringLength(50)]
        public string FBeneficiary { get; set; }

        [StringLength(25)]
        public string FBankNum { get; set; }

        [StringLength(100)]
        public string FBankAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs { get; set; }

        public virtual tblCat2 tblCat2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClaim> tblClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponent> tblComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBOM> tblComponentBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSub> tblComponentSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterial> tblMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInBill> tblMWHInBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInPBill> tblMWHInPBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderMould> tblOrderMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingMould> tblOrderPrintingMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOM> tblOrderSubBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHBill> tblPDTWHBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHFreight> tblPDTWHFreights { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHInBill> tblPDTWHInBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHTemp> tblPDTWHTemps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHTempFreight> tblPDTWHTempFreights { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPlateColor> tblPlateColors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessSub> tblProcessSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementChoose> tblProcurementChooses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduction> tblProductions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationBOM> tblQuotationBOMs { get; set; }
    }
}
