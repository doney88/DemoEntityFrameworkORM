namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCat2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCat2()
        {
            tblCat3 = new HashSet<tblCat3>();
            tblSuppliers = new HashSet<tblSupplier>();
        }

        [Key]
        public int FCat2ID { get; set; }

        public int? FCat1ID { get; set; }

        [Required]
        [StringLength(1)]
        public string FCat2Code { get; set; }

        [Required]
        [StringLength(5)]
        public string FCat2 { get; set; }

        public byte? FOrderBy { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblCat1 tblCat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat3> tblCat3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplier> tblSuppliers { get; set; }
    }
}
