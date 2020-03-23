namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponent")]
    public partial class tblComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblComponent()
        {
            tblAcetates = new HashSet<tblAcetate>();
            tblClientARDetails = new HashSet<tblClientARDetail>();
            tblComponentDWDs = new HashSet<tblComponentDWD>();
            tblComponentSTNs = new HashSet<tblComponentSTN>();
            tblComponentSpringBoxes = new HashSet<tblComponentSpringBox>();
            tblComponentQualities = new HashSet<tblComponentQuality>();
            tblDesignFronts = new HashSet<tblDesignFront>();
            tblComponentMoulds = new HashSet<tblComponentMould>();
            tblComponentMoulds1 = new HashSet<tblComponentMould>();
            tblMouldTemplePunchMoulds = new HashSet<tblMouldTemplePunchMould>();
            tblOrderComponents = new HashSet<tblOrderComponent>();
            tblProductionSampleSubSubs = new HashSet<tblProductionSampleSubSub>();
            tblProducts = new HashSet<tblProduct>();
            tblProducts1 = new HashSet<tblProduct>();
            tblRptProductionCardComponents = new HashSet<tblRptProductionCardComponent>();
            tblRptProductionComponents = new HashSet<tblRptProductionComponent>();
            tblRptProductionCardComponents1 = new HashSet<tblRptProductionCardComponent>();
            tblRptProductionCardMoulds = new HashSet<tblRptProductionCardMould>();
            tblComponentCoreSPs = new HashSet<tblComponentCoreSP>();
            tblComponentJBRaws = new HashSet<tblComponentJBRaw>();
            tblComponentSelfSealingBags = new HashSet<tblComponentSelfSealingBag>();
            tblComponentTrims = new HashSet<tblComponentTrim>();
            tblComponentTrimRaws = new HashSet<tblComponentTrimRaw>();
            tblMillTTDs = new HashSet<tblMillTTD>();
            tblMillXDs = new HashSet<tblMillXD>();
            tblPackingBackCards = new HashSet<tblPackingBackCard>();
            tblComponentBags = new HashSet<tblComponentBag>();
            tblComponentBOMs = new HashSet<tblComponentBOM>();
            tblComponentBoxes = new HashSet<tblComponentBox>();
            tblComponentCartons = new HashSet<tblComponentCarton>();
            tblComponentCores = new HashSet<tblComponentCore>();
            tblComponentDMSTs = new HashSet<tblComponentDMST>();
            tblComponentHinges = new HashSet<tblComponentHinge>();
            tblComponentHingeFS = new HashSet<tblComponentHingeF>();
            tblComponentJBs = new HashSet<tblComponentJB>();
            tblComponentLens = new HashSet<tblComponentLen>();
            tblComponentLenRaws = new HashSet<tblComponentLenRaw>();
            tblComponentMillWQDs = new HashSet<tblComponentMillWQD>();
            tblComponentPins = new HashSet<tblComponentPin>();
            tblComponentPlates = new HashSet<tblComponentPlate>();
            tblComponentPPNs = new HashSet<tblComponentPPN>();
            tblComponentScrews = new HashSet<tblComponentScrew>();
            tblComponentSubs = new HashSet<tblComponentSub>();
            tblComponentTTs = new HashSet<tblComponentTT>();
            tblComponentYZs = new HashSet<tblComponentYZ>();
            tblMillNQies = new HashSet<tblMillNQY>();
            tblMillNQYKs = new HashSet<tblMillNQYK>();
            tblPartsTemples = new HashSet<tblPartsTemple>();
            tblProcessBOMs = new HashSet<tblProcessBOM>();
            tblProducts2 = new HashSet<tblProduct>();
        }

        [Key]
        public int FComponentID { get; set; }

        public int FCat3ID { get; set; }

        [Required]
        [StringLength(255)]
        public string FComponentNum { get; set; }

        [StringLength(255)]
        public string FSpec { get; set; }

        [StringLength(255)]
        public string FComponentNumSpl { get; set; }

        public int FLorRCodeID { get; set; }

        public int FSupplierID { get; set; }

        public bool FSetPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        public bool FVAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateDate { get; set; }

        public int FMOQ { get; set; }

        public int FBatchQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FProcessTemplateID { get; set; }

        public bool FCancel { get; set; }

        [Required]
        [StringLength(5)]
        public string FUnit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetate> tblAcetates { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetail> tblClientARDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentDWD> tblComponentDWDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSTN> tblComponentSTNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSpringBox> tblComponentSpringBoxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentQuality> tblComponentQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDesignFront> tblDesignFronts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMould> tblComponentMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMould> tblComponentMoulds1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMouldTemplePunchMould> tblMouldTemplePunchMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderComponent> tblOrderComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionSampleSubSub> tblProductionSampleSubSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardComponent> tblRptProductionCardComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionComponent> tblRptProductionComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardComponent> tblRptProductionCardComponents1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardMould> tblRptProductionCardMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentCoreSP> tblComponentCoreSPs { get; set; }

        public virtual tblSysLorRCode tblSysLorRCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentJBRaw> tblComponentJBRaws { get; set; }

        public virtual tblProcessTemplate tblProcessTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSelfSealingBag> tblComponentSelfSealingBags { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrim> tblComponentTrims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrimRaw> tblComponentTrimRaws { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillTTD> tblMillTTDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillXD> tblMillXDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingBackCard> tblPackingBackCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBag> tblComponentBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBOM> tblComponentBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBox> tblComponentBoxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentCarton> tblComponentCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentCore> tblComponentCores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentDMST> tblComponentDMSTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentHinge> tblComponentHinges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentHingeF> tblComponentHingeFS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentJB> tblComponentJBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLen> tblComponentLens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLenRaw> tblComponentLenRaws { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMillWQD> tblComponentMillWQDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPin> tblComponentPins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPlate> tblComponentPlates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPPN> tblComponentPPNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentScrew> tblComponentScrews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSub> tblComponentSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTT> tblComponentTTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentYZ> tblComponentYZs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillNQY> tblMillNQies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillNQYK> tblMillNQYKs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTemple> tblPartsTemples { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBOM> tblProcessBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts2 { get; set; }
    }
}
