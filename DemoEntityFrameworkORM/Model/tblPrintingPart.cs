namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPrintingPart")]
    public partial class tblPrintingPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPrintingPart()
        {
            tblCustPrintingInfoSubs = new HashSet<tblCustPrintingInfoSub>();
            tblOrderPrintingInfoes = new HashSet<tblOrderPrintingInfo>();
        }

        [Key]
        public int FPrintingPartID { get; set; }

        [Required]
        [StringLength(25)]
        public string FPrintingPart { get; set; }

        [StringLength(2)]
        public string FMouldType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustPrintingInfoSub> tblCustPrintingInfoSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfo> tblOrderPrintingInfoes { get; set; }
    }
}
