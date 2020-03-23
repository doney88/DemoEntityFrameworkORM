namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuotationProcess")]
    public partial class tblQuotationProcess
    {
        [Key]
        public int FQPBOMID { get; set; }

        public int? FQuotationListID { get; set; }

        public int? FProcessSubID { get; set; }

        public double? FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        public float? FScrapRate { get; set; }

        public double? FCost { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblQuotationList tblQuotationList { get; set; }
    }
}
