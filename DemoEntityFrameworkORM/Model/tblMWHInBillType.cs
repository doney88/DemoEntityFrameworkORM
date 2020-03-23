namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHInBillType")]
    public partial class tblMWHInBillType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMWHInBillType()
        {
            tblMWHInBills = new HashSet<tblMWHInBill>();
            tblMWHInPBills = new HashSet<tblMWHInPBill>();
        }

        [Key]
        public int FMWHInBillTypeID { get; set; }

        [Required]
        [StringLength(4)]
        public string FBillType { get; set; }

        [StringLength(15)]
        public string FFrmName { get; set; }

        [Required]
        [StringLength(2)]
        public string FType { get; set; }

        [StringLength(2)]
        public string FIni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInBill> tblMWHInBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInPBill> tblMWHInPBills { get; set; }
    }
}
