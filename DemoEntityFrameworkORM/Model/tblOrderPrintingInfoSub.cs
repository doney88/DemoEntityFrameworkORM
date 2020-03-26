namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderPrintingInfoSub")]
    public partial class tblOrderPrintingInfoSub
    {
        [Key]
        public int FOrderPrintingInfoSubID { get; set; }

        public int FOrderPrintingInfoID { get; set; }

        public int? FSKUID { get; set; }

        [StringLength(255)]
        public string FModelCust { get; set; }

        [StringLength(50)]
        public string FColorCust { get; set; }

        [Required]
        [StringLength(255)]
        public string FPrintingInfo { get; set; }

        public int? FOrderPrintingInfoMouldID { get; set; }

        [StringLength(255)]
        public string FProductCode { get; set; }

        public int? FOrderPrintingInfoSplID { get; set; }

        public virtual tblOrderPrintingInfo tblOrderPrintingInfo { get; set; }

        public virtual tblOrderPrintingInfoSpl tblOrderPrintingInfoSpl { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }
    }
}
