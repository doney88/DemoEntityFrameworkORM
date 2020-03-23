namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProduction")]
    public partial class tblProduction
    {
        [Key]
        public int FProductionID { get; set; }

        public int FSKUID { get; set; }

        public short FQty { get; set; }

        public int FProcessID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FSupplierID { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
