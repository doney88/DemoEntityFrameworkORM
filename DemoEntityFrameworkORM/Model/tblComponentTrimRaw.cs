namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentTrimRaw")]
    public partial class tblComponentTrimRaw
    {
        [Key]
        public int FTrimRawID { get; set; }

        public int? FComponentID { get; set; }

        [StringLength(25)]
        public string FSize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FThick { get; set; }

        public int? FMaterialTypeID { get; set; }

        [StringLength(25)]
        public string FDescription { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
