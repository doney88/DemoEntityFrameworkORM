namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderPrintingInfoSpl")]
    public partial class tblOrderPrintingInfoSpl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderPrintingInfoSpl()
        {
            tblOrderPrintingInfoSubs = new HashSet<tblOrderPrintingInfoSub>();
        }

        [Key]
        public int FOrderPrintingInfoSplID { get; set; }

        [Required]
        [StringLength(255)]
        public string FPrintingInfo { get; set; }

        public int? FMaterialID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FOrderPrintingInfoID { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderPrintingInfo tblOrderPrintingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderPrintingInfoSub> tblOrderPrintingInfoSubs { get; set; }
    }
}
