namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWHInBill")]
    public partial class tblPDTWHInBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPDTWHInBill()
        {
            tblPDTWHIns = new HashSet<tblPDTWHIn>();
        }

        [Key]
        public int FPDTWHInBillID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        public int? FSupplierID { get; set; }

        [Column(TypeName = "money")]
        public decimal FAMount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHIn> tblPDTWHIns { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
