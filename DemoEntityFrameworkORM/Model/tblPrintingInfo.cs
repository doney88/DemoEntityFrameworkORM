namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPrintingInfo")]
    public partial class tblPrintingInfo
    {
        [Key]
        public int FPrintingInfoID { get; set; }

        public int FOrderID { get; set; }

        public int FCustID { get; set; }

        public int FCustPrintingInfoID { get; set; }

        [StringLength(50)]
        public string FDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime FCreateDate { get; set; }

        public virtual tblCust tblCust { get; set; }

        public virtual tblCustPrintingInfo tblCustPrintingInfo { get; set; }

        public virtual tblOrder tblOrder { get; set; }
    }
}
