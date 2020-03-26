namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSurface")]
    public partial class tblSurface
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSurface()
        {
            tblPartsTempleSubs = new HashSet<tblPartsTempleSub>();
            tblProductSKUs = new HashSet<tblProductSKU>();
        }

        [Key]
        public int FSurfaceID { get; set; }

        [Required]
        [StringLength(15)]
        public string FSurface { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTempleSub> tblPartsTempleSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }
    }
}
