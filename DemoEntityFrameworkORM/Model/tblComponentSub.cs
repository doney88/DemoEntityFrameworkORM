namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSub")]
    public partial class tblComponentSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblComponentSub()
        {
            tblClientARDetails = new HashSet<tblClientARDetail>();
            tblComponentBOMs = new HashSet<tblComponentBOM>();
            tblComponentFrontSubs = new HashSet<tblComponentFrontSub>();
            tblComponentJBSubs = new HashSet<tblComponentJBSub>();
            tblComponentTrimSubs = new HashSet<tblComponentTrimSub>();
            tblComponentSubBOMs = new HashSet<tblComponentSubBOM>();
            tblComponentSubBOMs1 = new HashSet<tblComponentSubBOM>();
            tblComponentSubLRs = new HashSet<tblComponentSubLR>();
            tblPartsTempleSubs = new HashSet<tblPartsTempleSub>();
            tblProductSKUs = new HashSet<tblProductSKU>();
        }

        [Key]
        public int FComponentSubID { get; set; }

        public int FComponentID { get; set; }

        public int? FLorRCodeID { get; set; }

        [StringLength(255)]
        public string FSpecSub { get; set; }

        [StringLength(255)]
        public string FSpecSubSpl { get; set; }

        public int FSupplierID { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public bool FVAT { get; set; }

        public int FMOQ { get; set; }

        public int FBatchQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetail> tblClientARDetails { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBOM> tblComponentBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentFrontSub> tblComponentFrontSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentJBSub> tblComponentJBSubs { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrimSub> tblComponentTrimSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSubBOM> tblComponentSubBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSubBOM> tblComponentSubBOMs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSubLR> tblComponentSubLRs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTempleSub> tblPartsTempleSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }
    }
}
