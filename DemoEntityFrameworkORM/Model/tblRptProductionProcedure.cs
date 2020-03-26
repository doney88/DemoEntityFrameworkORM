namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionProcedure")]
    public partial class tblRptProductionProcedure
    {
        [Key]
        public int FProcedureID { get; set; }

        public int FProductionSectionID { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [Required]
        public string FProcedure { get; set; }

        public virtual tblRptProductionSection tblRptProductionSection { get; set; }
    }
}
