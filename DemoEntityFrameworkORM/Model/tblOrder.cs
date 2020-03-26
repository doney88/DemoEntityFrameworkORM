namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrder")]
    public partial class tblOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrder()
        {
            tblClientARDetails = new HashSet<tblClientARDetail>();
            tblOrderAnalyzes = new HashSet<tblOrderAnalyze>();
            tblOrderComponents = new HashSet<tblOrderComponent>();
            tblOrderMoulds = new HashSet<tblOrderMould>();
            tblOrderPrintingInfoes = new HashSet<tblOrderPrintingInfo>();
            tblOrderPrintingMoulds = new HashSet<tblOrderPrintingMould>();
            tblOrderShipBatches = new HashSet<tblOrderShipBatch>();
            tblOrderSubBOMPackings = new HashSet<tblOrderSubBOMPacking>();
            tblPrintingInfoes = new HashSet<tblPrintingInfo>();
            tblProcurementChooses = new HashSet<tblProcurementChoose>();
            tblProductionSampleSubSubs = new HashSet<tblProductionSampleSubSub>();
            tblRptProductionHeads = new HashSet<tblRptProductionHead>();
            tblProcurementSubs = new HashSet<tblProcurementSub>();
            tblOrderSubs = new HashSet<tblOrderSub>();
            tblProformaInvoices = new HashSet<tblProformaInvoice>();
            tblQuotations = new HashSet<tblQuotation>();
        }

        [Key]
        public int FOrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string FOrderNum { get; set; }

        public int FClientID { get; set; }

        public int? FCustID { get; set; }

        [StringLength(255)]
        public string FOrderCust { get; set; }

        public int FOrderQty { get; set; }

        public short? FInputQty { get; set; }

        public short? FShipQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDeliveryDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FPlanDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FProduceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FFinishDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCancelDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Required]
        [StringLength(4)]
        public string FOrderType { get; set; }

        public bool FUrgent { get; set; }

        [StringLength(5)]
        public string FCurrency { get; set; }

        public bool FPrintInfo { get; set; }

        [StringLength(25)]
        public string FSortCode { get; set; }

        public int? FCustPrintingInfoID { get; set; }

        public short? FQtyYield { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public short? FQtyYieldBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? FShipAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCostAmount { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FAmountBalance { get; set; }

        public bool FMould { get; set; }

        public int? FPackingTemplateID { get; set; }

        public bool FPacking { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FBillDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public short? FQtyBalance { get; set; }

        [StringLength(10)]
        public string FStatus { get; set; }

        public byte? FModelQty { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetail> tblClientARDetails { get; set; }

        public virtual tblCust tblCust { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderAnalyze> tblOrderAnalyzes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderComponent> tblOrderComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderMould> tblOrderMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfo> tblOrderPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingMould> tblOrderPrintingMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderShipBatch> tblOrderShipBatches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrintingInfo> tblPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementChoose> tblProcurementChooses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionSampleSubSub> tblProductionSampleSubSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionHead> tblRptProductionHeads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSub> tblProcurementSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSub> tblOrderSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProformaInvoice> tblProformaInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotation> tblQuotations { get; set; }
    }
}
