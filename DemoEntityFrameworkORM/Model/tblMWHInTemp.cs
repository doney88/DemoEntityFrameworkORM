namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHInTemp")]
    public partial class tblMWHInTemp
    {
        [Key]
        public int FMWHInTempID { get; set; }

        public int? FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
