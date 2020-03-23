namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductStyle")]
    public partial class tblProductStyle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductStyle()
        {
            tblProductSampleBoxes = new HashSet<tblProductSampleBox>();
        }

        [Key]
        public int FProductStyleID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSampleBox> tblProductSampleBoxes { get; set; }
    }
}
