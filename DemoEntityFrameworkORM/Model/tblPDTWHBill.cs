namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWHBill")]
    public partial class tblPDTWHBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPDTWHBill()
        {
            tblPDTWHs = new HashSet<tblPDTWH>();
            tblPDTWHFreights = new HashSet<tblPDTWHFreight>();
        }

        [Key]
        public int FPDTWHBillID { get; set; }

        public int FClientID { get; set; }

        [Required]
        [StringLength(14)]
        public string FBillNum { get; set; }

        public byte FPDTWHBillTypeID { get; set; }

        public short FQtyTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmountMinus { get; set; }

        [Column(TypeName = "money")]
        public decimal? FFreight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        public bool FCharge { get; set; }

        public int? FClientAddressID { get; set; }

        public int? FClientContactID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FSupplierID { get; set; }

        public byte? FCtnQty { get; set; }

        public bool FVerify { get; set; }

        public bool FCollect { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FAmountActual { get; set; }

        public virtual tblClient tblClient { get; set; }

        public virtual tblClientAddress tblClientAddress { get; set; }

        public virtual tblClientContact tblClientContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWH> tblPDTWHs { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        public virtual tblPDTWHBillType tblPDTWHBillType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHFreight> tblPDTWHFreights { get; set; }
    }
}
