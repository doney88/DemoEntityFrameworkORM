namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentLenRaw")]
    public partial class tblComponentLenRaw
    {
        [Key]
        public int FLenRawID { get; set; }

        public int? FMaterialTypeID { get; set; }

        public int FLenColorID { get; set; }

        [StringLength(3)]
        public string FLevel { get; set; }

        [StringLength(5)]
        public string FUV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FRefractive { get; set; }

        public int? FComponentID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }

        public virtual tblLenColor tblLenColor { get; set; }
    }
}
