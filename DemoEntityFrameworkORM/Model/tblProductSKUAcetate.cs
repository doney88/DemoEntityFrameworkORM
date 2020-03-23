namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductSKUAcetate")]
    public partial class tblProductSKUAcetate
    {
        [Key]
        public int FCutFrontID { get; set; }

        public int FProductSKUID { get; set; }

        public int? FMaterialIDF { get; set; }

        [StringLength(4)]
        public string FCutType { get; set; }

        public byte? FCutQty { get; set; }

        public byte? FQtyPer { get; set; }

        public byte? FAcetateQty { get; set; }

        [StringLength(255)]
        public string FAcetateNote { get; set; }

        public virtual tblProductSKU tblProductSKU { get; set; }
    }
}
