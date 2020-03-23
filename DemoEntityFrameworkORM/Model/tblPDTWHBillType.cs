namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWHBillType")]
    public partial class tblPDTWHBillType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPDTWHBillType()
        {
            tblPDTWHBills = new HashSet<tblPDTWHBill>();
        }

        [Key]
        public byte FPDTWHBillTypeID { get; set; }

        [Required]
        [StringLength(4)]
        public string FBillTypeName { get; set; }

        [Required]
        [StringLength(3)]
        public string FTypeCode { get; set; }

        [StringLength(10)]
        public string FSender { get; set; }

        [StringLength(10)]
        public string FReceiver { get; set; }

        public bool FMinus { get; set; }

        public bool FCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHBill> tblPDTWHBills { get; set; }
    }
}
