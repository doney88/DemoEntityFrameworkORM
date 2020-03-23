namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWHTempFreight")]
    public partial class tblPDTWHTempFreight
    {
        [Key]
        public int FFreigntTempID { get; set; }

        public int? FSupplierID { get; set; }

        [StringLength(15)]
        public string FTrackingNum { get; set; }

        [StringLength(255)]
        public string FDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public bool FCharge { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
