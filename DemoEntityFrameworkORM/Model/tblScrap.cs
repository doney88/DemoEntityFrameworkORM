namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblScrap")]
    public partial class tblScrap
    {
        [Key]
        public int FScrapID { get; set; }

        [StringLength(3)]
        public string FScrapCode { get; set; }

        [StringLength(50)]
        public string FScrapName { get; set; }

        public int? FPart { get; set; }

        public string FExplain { get; set; }
    }
}
