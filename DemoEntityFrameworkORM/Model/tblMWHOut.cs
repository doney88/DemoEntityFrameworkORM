namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHOut")]
    public partial class tblMWHOut
    {
        public int ID { get; set; }

        public int? FOrderBOMID { get; set; }

        public int FMWHOutBIllID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public decimal FQty { get; set; }

        public decimal? FWeight { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderSubBOM tblOrderSubBOM { get; set; }

        public virtual tblMWHOutBill tblMWHOutBill { get; set; }
    }
}
