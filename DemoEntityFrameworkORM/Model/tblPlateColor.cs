namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPlateColor")]
    public partial class tblPlateColor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPlateColor()
        {
            tblComponentBGSubs = new HashSet<tblComponentBGSub>();
            tblComponentCoreSubs = new HashSet<tblComponentCoreSub>();
            tblComponentEyebrowSubs = new HashSet<tblComponentEyebrowSub>();
            tblComponentHingeSubs = new HashSet<tblComponentHingeSub>();
            tblComponentJBSubs = new HashSet<tblComponentJBSub>();
            tblComponentMetalFrontSubs = new HashSet<tblComponentMetalFrontSub>();
            tblComponentMetalStickerSubs = new HashSet<tblComponentMetalStickerSub>();
            tblComponentPinSubs = new HashSet<tblComponentPinSub>();
            tblComponentPlateSubs = new HashSet<tblComponentPlateSub>();
            tblComponentScrewSubs = new HashSet<tblComponentScrewSub>();
            tblComponentTrimSubs = new HashSet<tblComponentTrimSub>();
            tblProcessPlates = new HashSet<tblProcessPlate>();
        }

        [Key]
        public int FPlateColorID { get; set; }

        [Required]
        [StringLength(6)]
        public string FPlateColorNum { get; set; }

        [Required]
        [StringLength(20)]
        public string FColor { get; set; }

        [StringLength(50)]
        public string FPlateColorNumSpl { get; set; }

        public int? FSupplierID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentBGSub> tblComponentBGSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentCoreSub> tblComponentCoreSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentEyebrowSub> tblComponentEyebrowSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentHingeSub> tblComponentHingeSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentJBSub> tblComponentJBSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMetalFrontSub> tblComponentMetalFrontSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMetalStickerSub> tblComponentMetalStickerSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPinSub> tblComponentPinSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentPlateSub> tblComponentPlateSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentScrewSub> tblComponentScrewSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentTrimSub> tblComponentTrimSubs { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessPlate> tblProcessPlates { get; set; }
    }
}
