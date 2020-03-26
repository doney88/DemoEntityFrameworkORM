namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderPrintingInfo")]
    public partial class tblOrderPrintingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderPrintingInfo()
        {
            tblOrderPrintingInfoSubs = new HashSet<tblOrderPrintingInfoSub>();
            tblOrderPrintingInfoSpls = new HashSet<tblOrderPrintingInfoSpl>();
        }

        [Key]
        public int FOrderPrintingInfoID { get; set; }

        public int FOrderID { get; set; }

        public int? FCustPrintingInfoID { get; set; }

        public int? FCustPrintingInfoSubID { get; set; }

        public int FPrintPartID { get; set; }

        [Required]
        [StringLength(255)]
        public string FGuideInfo { get; set; }

        [StringLength(2)]
        public string FDistinguishType { get; set; }

        [StringLength(255)]
        public string FMouldInfo { get; set; }

        [StringLength(2)]
        public string FMouldType { get; set; }

        public virtual tblCustPrintingInfo tblCustPrintingInfo { get; set; }

        public virtual tblCustPrintingInfoSub tblCustPrintingInfoSub { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfoSub> tblOrderPrintingInfoSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfoSpl> tblOrderPrintingInfoSpls { get; set; }

        public virtual tblPrintingPart tblPrintingPart { get; set; }
    }
}
