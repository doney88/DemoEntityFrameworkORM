namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblScrappage")]
    public partial class tblScrappage
    {
        [Key]
        public int FRateID { get; set; }

        public int FFrom { get; set; }

        public int FTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FScrappage { get; set; }

        [Required]
        [StringLength(2)]
        public string FScrapType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FScrappageQuote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FScrappageMetal { get; set; }
    }
}
