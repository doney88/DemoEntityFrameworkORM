namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionPlan")]
    public partial class tblProductionPlan
    {
        [Key]
        public int FProductionPlanID { get; set; }

        public int FProductionPlanHeaderID { get; set; }

        public int FProcessID { get; set; }

        public int FSKUID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FPlanDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblProductionPlanHeader tblProductionPlanHeader { get; set; }
    }
}
