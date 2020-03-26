namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPackingMixType")]
    public partial class tblPackingMixType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPackingMixType()
        {
            tblOrderSubBOMPackings = new HashSet<tblOrderSubBOMPacking>();
            tblPackingTemplateSubs = new HashSet<tblPackingTemplateSub>();
        }

        [Key]
        public int FPackingMixTypeID { get; set; }

        [Required]
        [StringLength(10)]
        public string FMixType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingTemplateSub> tblPackingTemplateSubs { get; set; }
    }
}
