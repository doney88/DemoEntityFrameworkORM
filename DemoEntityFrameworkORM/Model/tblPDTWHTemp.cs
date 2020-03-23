namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWHTemp")]
    public partial class tblPDTWHTemp
    {
        [Key]
        public int FPDTWHTempID { get; set; }

        public int? FSKUID { get; set; }

        public short FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal FAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FCharge { get; set; }

        public int? FSupplierID { get; set; }

        public int FMaterialID { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
