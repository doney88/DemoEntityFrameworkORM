namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionProcess")]
    public partial class tblRptProductionProcess
    {
        [Key]
        public int FProductionProcessID { get; set; }

        public int FProductionComponentID { get; set; }

        public int FOrderBOMID { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [Required]
        [StringLength(50)]
        public string FColorCust { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSpec { get; set; }

        [Required]
        [StringLength(5)]
        public string FUnit { get; set; }

        public short FQty { get; set; }

        public virtual tblRptProductionComponent tblRptProductionComponent { get; set; }
    }
}
