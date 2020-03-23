namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClient")]
    public partial class tblClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClient()
        {
            tblAKTClientPayments = new HashSet<tblAKTClientPayment>();
            tblAktClientShipments = new HashSet<tblAktClientShipment>();
            tblClientARs = new HashSet<tblClientAR>();
            tblClientQualities = new HashSet<tblClientQuality>();
            tblComponentQualities = new HashSet<tblComponentQuality>();
            tblCusts = new HashSet<tblCust>();
            tblPDTWHBills = new HashSet<tblPDTWHBill>();
            tblQuotations = new HashSet<tblQuotation>();
            tblOrders = new HashSet<tblOrder>();
            tblClientAddresses = new HashSet<tblClientAddress>();
            tblClientContacts = new HashSet<tblClientContact>();
            tblLenColors = new HashSet<tblLenColor>();
            tblProducts = new HashSet<tblProduct>();
        }

        [Key]
        public int FClientID { get; set; }

        [Required]
        [StringLength(5)]
        public string FClientNum { get; set; }

        [StringLength(255)]
        public string FClient { get; set; }

        [StringLength(25)]
        public string FClientShortName { get; set; }

        [StringLength(2)]
        public string FPriority { get; set; }

        [StringLength(25)]
        public string FCountry { get; set; }

        public bool? VerifyAkt { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FCooperate { get; set; }

        public int? FPaymentTermID { get; set; }

        [StringLength(25)]
        public string FDeliverTerm { get; set; }

        [StringLength(15)]
        public string FCurrency { get; set; }

        [Column(TypeName = "money")]
        public decimal? FAmount { get; set; }

        public short? FYearLatest { get; set; }

        public byte? FMonthLatest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAKTClientPayment> tblAKTClientPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAktClientShipment> tblAktClientShipments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientAR> tblClientARs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientQuality> tblClientQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentQuality> tblComponentQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCust> tblCusts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHBill> tblPDTWHBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotation> tblQuotations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrder> tblOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientAddress> tblClientAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientContact> tblClientContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLenColor> tblLenColors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
