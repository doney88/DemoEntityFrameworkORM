namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEngineerLenCategory")]
    public partial class tblEngineerLenCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEngineerLenCategory()
        {
            tblLenColors = new HashSet<tblLenColor>();
        }

        [Key]
        public int FLenCategoryID { get; set; }

        [Required]
        [StringLength(4)]
        public string FLenCateGory { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FTransmittanceMin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FTransmittanceMax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLenColor> tblLenColors { get; set; }
    }
}
