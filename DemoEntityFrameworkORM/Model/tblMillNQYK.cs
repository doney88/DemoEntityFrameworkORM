namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMillNQYK")]
    public partial class tblMillNQYK
    {
        [Key]
        public int FNQYID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FShankDiameter { get; set; }

        [Required]
        [StringLength(2)]
        public string FGroove { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FGrooveWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FGrooveDepth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FNoseHeight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FGrooveRadius { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHoleDiameter { get; set; }

        public int FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
