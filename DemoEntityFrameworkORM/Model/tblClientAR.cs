namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientAR")]
    public partial class tblClientAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientAR()
        {
            tblClientARDetails = new HashSet<tblClientARDetail>();
        }

        [Key]
        public int FClientARID { get; set; }

        public int FClientID { get; set; }

        public int FPaymentTermID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [Required]
        [StringLength(4)]
        public string FYear { get; set; }

        [Required]
        [StringLength(2)]
        public string FMonth { get; set; }

        public int FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal FDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal FDepositUSE { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmountAR { get; set; }

        [Required]
        [StringLength(4)]
        public string FYearAR { get; set; }

        [Required]
        [StringLength(2)]
        public string FMonthAR { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetail> tblClientARDetails { get; set; }

        public virtual tblPaymentTerm tblPaymentTerm { get; set; }
    }
}
