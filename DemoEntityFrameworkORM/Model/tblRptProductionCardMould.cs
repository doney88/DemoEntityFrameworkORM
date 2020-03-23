namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionCardMould")]
    public partial class tblRptProductionCardMould
    {
        [Key]
        public int FProductionCardMouldID { get; set; }

        public int FProductionCardComponentID { get; set; }

        public int FComponentID { get; set; }

        [Required]
        [StringLength(25)]
        public string FCat3 { get; set; }

        [Required]
        [StringLength(255)]
        public string FComponentNumSpec { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblRptProductionCardComponent tblRptProductionCardComponent { get; set; }
    }
}
