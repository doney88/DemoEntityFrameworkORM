namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentScrewSub")]
    public partial class tblComponentScrewSub
    {
        [Key]
        public int FScrewSubID { get; set; }

        public int FComponentSubID { get; set; }

        [StringLength(2)]
        public string FGlue { get; set; }

        [StringLength(2)]
        public string FGlueColor { get; set; }

        [Required]
        [StringLength(4)]
        public string FPorM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThickCup { get; set; }

        [StringLength(2)]
        public string FThreadType { get; set; }

        public int? FMaterialTypeID { get; set; }

        public int? FPlateColorID { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
