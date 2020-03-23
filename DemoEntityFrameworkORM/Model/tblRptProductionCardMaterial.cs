namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionCardMaterial")]
    public partial class tblRptProductionCardMaterial
    {
        [Key]
        public int FProductionCardMaterialID { get; set; }

        public int FProductionCardComponentID { get; set; }

        public int FProcessID { get; set; }

        [Required]
        [StringLength(50)]
        public string FScanCode { get; set; }

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
        [StringLength(5)]
        public string FUnit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblRptProductionCardComponent tblRptProductionCardComponent { get; set; }
    }
}
