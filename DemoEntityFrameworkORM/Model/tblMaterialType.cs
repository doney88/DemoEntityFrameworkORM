namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMaterialType")]
    public partial class tblMaterialType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMaterialType()
        {
            tblComponentBags = new HashSet<tblComponentBag>();
            tblComponentBoxes = new HashSet<tblComponentBox>();
            tblComponentCartonSubs = new HashSet<tblComponentCartonSub>();
            tblComponentJBRaws = new HashSet<tblComponentJBRaw>();
            tblComponentLenRaws = new HashSet<tblComponentLenRaw>();
            tblComponentMillWQDs = new HashSet<tblComponentMillWQD>();
            tblComponentPins = new HashSet<tblComponentPin>();
            tblComponentPPNs = new HashSet<tblComponentPPN>();
            tblComponentScrewSubs = new HashSet<tblComponentScrewSub>();
            tblComponentSelfSealingBags = new HashSet<tblComponentSelfSealingBag>();
            tblComponentTrims = new HashSet<tblComponentTrim>();
            tblComponentTrimRaws = new HashSet<tblComponentTrimRaw>();
            tblComponentYZs = new HashSet<tblComponentYZ>();
            tblMillNQYKs = new HashSet<tblMillNQYK>();
            tblMillNQies = new HashSet<tblMillNQY>();
            tblMillXDs = new HashSet<tblMillXD>();
            tblPackingBackCards = new HashSet<tblPackingBackCard>();
        }

        [Key]
        public int FMaterialTypeID { get; set; }

        [StringLength(25)]
        public string FMaterial { get; set; }

        [StringLength(3)]
        public string FMaterialType { get; set; }

        public bool FMill { get; set; }

        public bool FComponent { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBag> tblComponentBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBox> tblComponentBoxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentCartonSub> tblComponentCartonSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentJBRaw> tblComponentJBRaws { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLenRaw> tblComponentLenRaws { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMillWQD> tblComponentMillWQDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPin> tblComponentPins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPPN> tblComponentPPNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentScrewSub> tblComponentScrewSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentSelfSealingBag> tblComponentSelfSealingBags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrim> tblComponentTrims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrimRaw> tblComponentTrimRaws { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentYZ> tblComponentYZs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillNQYK> tblMillNQYKs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillNQY> tblMillNQies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMillXD> tblMillXDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingBackCard> tblPackingBackCards { get; set; }
    }
}
