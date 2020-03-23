namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHIn")]
    public partial class tblMWHIn
    {
        [Key]
        public int FMWHInID { get; set; }

        public int FMWHInBillID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public decimal FQty { get; set; }

        public decimal FWeight { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblMWHInBill tblMWHInBill { get; set; }
    }
}
