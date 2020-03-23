namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionSemi")]
    public partial class tblRptProductionSemi
    {
        [Key]
        public int FProductionSemiID { get; set; }

        public int FProductionSectionID { get; set; }

        [Required]
        [StringLength(50)]
        public string FColorCust { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSpec { get; set; }

        [Required]
        [StringLength(5)]
        public string FUnit { get; set; }

        public short FQty { get; set; }

        public virtual tblRptProductionSection tblRptProductionSection { get; set; }
    }
}
