namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionMaterial")]
    public partial class tblRptProductionMaterial
    {
        [Key]
        public int FProductionMaterialID { get; set; }

        public int FProductionSectionID { get; set; }

        public int FProcessID { get; set; }

        [Required]
        [StringLength(15)]
        public string FProcessName { get; set; }

        [StringLength(50)]
        public string FColorCust { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [Required]
        [StringLength(255)]
        public string FItemSpec { get; set; }

        [Required]
        [StringLength(2)]
        public string FUnit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblRptProductionSection tblRptProductionSection { get; set; }
    }
}
