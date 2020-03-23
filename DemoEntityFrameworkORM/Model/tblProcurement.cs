namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurement")]
    public partial class tblProcurement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcurement()
        {
            tblProcurementSubs = new HashSet<tblProcurementSub>();
        }

        [Key]
        public int FPOID { get; set; }

        [StringLength(11)]
        public string FPONum { get; set; }

        public int? FSupplierID { get; set; }

        [StringLength(2)]
        public string FPmtTerm { get; set; }

        public byte FItemQty { get; set; }

        public byte FItemQtyDone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDemandDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FReplyDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FConfirmDateFirst { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FQConfirmDateMin { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Required]
        [StringLength(3)]
        public string FStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSub> tblProcurementSubs { get; set; }
    }
}
