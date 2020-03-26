namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHInPBill")]
    public partial class tblMWHInPBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMWHInPBill()
        {
            tblMWHInPs = new HashSet<tblMWHInP>();
        }

        [Key]
        public int FMWHInPBillID { get; set; }

        [Required]
        [StringLength(10)]
        public string FBillNum { get; set; }

        public int FSupplierID { get; set; }

        [Required]
        [StringLength(2)]
        public string FPmtTerm { get; set; }

        public int FMWHInBillTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public bool FInvoice { get; set; }

        public virtual tblMWHInBillType tblMWHInBillType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInP> tblMWHInPs { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
