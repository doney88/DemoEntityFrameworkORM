namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuotation")]
    public partial class tblQuotation
    {
        [Key]
        public int FQuotationID { get; set; }

        [Required]
        [StringLength(6)]
        public string FQuotationNum { get; set; }

        public int FClientID { get; set; }

        public int FCurrencyID { get; set; }

        [Required]
        [StringLength(15)]
        public string FLanguage { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FOrderID { get; set; }

        public int? FCustID { get; set; }

        public bool FConfirm { get; set; }

        public virtual tblClient tblClient { get; set; }

        public virtual tblCurrencyType tblCurrencyType { get; set; }

        public virtual tblCust tblCust { get; set; }

        public virtual tblOrder tblOrder { get; set; }
    }
}
