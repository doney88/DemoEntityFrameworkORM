namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentYZ")]
    public partial class tblComponentYZ
    {
        [Key]
        public int FYZID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
