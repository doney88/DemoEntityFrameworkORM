namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionComponentSub")]
    public partial class tblRptProductionComponentSub
    {
        [Key]
        public int FProductionComponentSubID { get; set; }

        public int FProductionComponentID { get; set; }

        public int FSKUID { get; set; }

        [Required]
        [StringLength(50)]
        public string FColorCust { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSpec { get; set; }

        public short FQty { get; set; }

        public virtual tblRptProductionComponent tblRptProductionComponent { get; set; }
    }
}
