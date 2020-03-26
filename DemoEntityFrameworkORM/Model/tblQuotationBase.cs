namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuotationBase")]
    public partial class tblQuotationBase
    {
        [Key]
        public int FQuotationBaseID { get; set; }

        public int FQuotationLIstID { get; set; }

        [Required]
        [StringLength(5)]
        public string FPriceCat { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public virtual tblQuotationList tblQuotationList { get; set; }
    }
}
