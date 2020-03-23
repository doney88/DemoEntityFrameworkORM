namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessSub")]
    public partial class tblProcessSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcessSub()
        {
            tblProcessPlates = new HashSet<tblProcessPlate>();
        }

        [Key]
        public int FProcessSubID { get; set; }

        public int FProcessID { get; set; }

        public int FSupplierID { get; set; }

        [StringLength(50)]
        public string FSpec { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public bool FVAT { get; set; }

        [Required]
        [StringLength(5)]
        public string FUnit { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessPlate> tblProcessPlates { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
