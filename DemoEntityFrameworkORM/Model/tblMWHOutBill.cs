namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHOutBill")]
    public partial class tblMWHOutBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMWHOutBill()
        {
            tblMWHOuts = new HashSet<tblMWHOut>();
        }

        [Key]
        public int FMWHOutBillID { get; set; }

        [Required]
        [StringLength(20)]
        public string FBillNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        public int FSectionID { get; set; }

        [Required]
        [StringLength(2)]
        public string FBillType { get; set; }

        [Column(TypeName = "money")]
        public decimal? FAmount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOut> tblMWHOuts { get; set; }

        public virtual tblSection tblSection { get; set; }
    }
}
