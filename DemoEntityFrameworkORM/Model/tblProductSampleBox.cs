namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductSampleBox")]
    public partial class tblProductSampleBox
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductSampleBox()
        {
            tblProductSKUs = new HashSet<tblProductSKU>();
        }

        [Key]
        public int FProductSampleBoxID { get; set; }

        [Required]
        [StringLength(10)]
        public string FBoxID { get; set; }

        public int FProductStyleID { get; set; }

        public byte? FQty { get; set; }

        public int FCat3ID { get; set; }

        [Required]
        [StringLength(25)]
        public string FRegion { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDateFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDateEnd { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        public virtual tblProductStyle tblProductStyle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }
    }
}
