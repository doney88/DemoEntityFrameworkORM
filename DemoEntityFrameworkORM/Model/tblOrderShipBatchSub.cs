namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderShipBatchSub")]
    public partial class tblOrderShipBatchSub
    {
        [Key]
        public int FOrderShipBatchSubID { get; set; }

        public int FOrderShipBatchID { get; set; }

        public int FSKUID { get; set; }

        public short FQty { get; set; }

        [Required]
        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblOrderShipBatch tblOrderShipBatch { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }
    }
}
