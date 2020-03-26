namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCust")]
    public partial class tblCust
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCust()
        {
            tblCustPrintingInfoes = new HashSet<tblCustPrintingInfo>();
            tblPackingTemplates = new HashSet<tblPackingTemplate>();
            tblPrintingInfoes = new HashSet<tblPrintingInfo>();
            tblOrders = new HashSet<tblOrder>();
            tblCustQualities = new HashSet<tblCustQuality>();
            tblQuotations = new HashSet<tblQuotation>();
        }

        [Key]
        public int FCustID { get; set; }

        public int FClientID { get; set; }

        [Required]
        [StringLength(10)]
        public string FCustName_Short { get; set; }

        [StringLength(25)]
        public string FCustName { get; set; }

        [StringLength(2)]
        public string FPriority { get; set; }

        [StringLength(255)]
        public string FWebsite { get; set; }

        public bool FBoxLabelDouble { get; set; }

        public byte? FQtyPerBox { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustPrintingInfo> tblCustPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingTemplate> tblPackingTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrintingInfo> tblPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrder> tblOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustQuality> tblCustQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotation> tblQuotations { get; set; }
    }
}
