namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCustPrintingInfo")]
    public partial class tblCustPrintingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustPrintingInfo()
        {
            tblOrderPrintingInfoes = new HashSet<tblOrderPrintingInfo>();
            tblPrintingInfoes = new HashSet<tblPrintingInfo>();
            tblCustPrintingInfoSubs = new HashSet<tblCustPrintingInfoSub>();
        }

        [Key]
        public int FCustPrintingInfoID { get; set; }

        public int FCustID { get; set; }

        [StringLength(255)]
        public string FDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        public virtual tblCust tblCust { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfo> tblOrderPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPrintingInfo> tblPrintingInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustPrintingInfoSub> tblCustPrintingInfoSubs { get; set; }
    }
}
