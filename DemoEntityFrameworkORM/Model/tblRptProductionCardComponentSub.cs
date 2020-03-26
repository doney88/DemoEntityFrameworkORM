namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionCardComponentSub")]
    public partial class tblRptProductionCardComponentSub
    {
        [Key]
        public int FProductionCardComponentSubID { get; set; }

        public int FProductionCardComponentID { get; set; }

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

        public virtual tblRptProductionCardComponent tblRptProductionCardComponent { get; set; }
    }
}
