namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHOutTemp")]
    public partial class tblMWHOutTemp
    {
        [Key]
        public int FMWHOutTempID { get; set; }

        public int? FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FOrderBOMID { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderSubBOM tblOrderSubBOM { get; set; }
    }
}
