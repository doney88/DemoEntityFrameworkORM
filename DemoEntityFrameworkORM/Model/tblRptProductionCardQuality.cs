namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionCardQuality")]
    public partial class tblRptProductionCardQuality
    {
        [Key]
        public int FProductionCardQualityID { get; set; }

        public int FProductionCardComponentID { get; set; }

        public int? FProcessID { get; set; }

        [StringLength(25)]
        public string FProcessName { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblRptProductionCardComponent tblRptProductionCardComponent { get; set; }
    }
}
