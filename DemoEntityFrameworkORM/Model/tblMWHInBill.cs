namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHInBill")]
    public partial class tblMWHInBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMWHInBill()
        {
            tblMWHIns = new HashSet<tblMWHIn>();
        }

        [Key]
        public int FMWHInBillID { get; set; }

        [Required]
        [StringLength(20)]
        public string FBillNum { get; set; }

        public int FMWHInBillTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [Required]
        [StringLength(2)]
        public string FPmtTerm { get; set; }

        public int FSupplierID { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public bool FInvoice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHIn> tblMWHIns { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        public virtual tblMWHInBillType tblMWHInBillType { get; set; }
    }
}
