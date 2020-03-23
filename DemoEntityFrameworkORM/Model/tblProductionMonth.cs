namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionMonth")]
    public partial class tblProductionMonth
    {
        [Key]
        public int FProductionMonthID { get; set; }

        [Required]
        [StringLength(6)]
        public string FMonth { get; set; }

        public int? FQty { get; set; }

        public int FProcessID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProcess tblProcess { get; set; }
    }
}
