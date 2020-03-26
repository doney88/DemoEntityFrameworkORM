namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentPin")]
    public partial class tblComponentPin
    {
        [Key]
        public int FPinID { get; set; }

        public int FComponentID { get; set; }

        [Required]
        [StringLength(15)]
        public string FHeadSize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FHeadThick { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FThreadDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTotalLength { get; set; }

        public int FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
