namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderComponent")]
    public partial class tblOrderComponent
    {
        [Key]
        public int FOrderComponentID { get; set; }

        public int FOrderID { get; set; }

        public int FComponentID { get; set; }

        [StringLength(255)]
        public string FModelCust { get; set; }

        public short FQty { get; set; }

        public int FYieldBalance { get; set; }

        public int FBalance { get; set; }

        [StringLength(10)]
        public string FAcetateFrontStatus { get; set; }

        [StringLength(10)]
        public string FAcetateTempleStatus { get; set; }

        [StringLength(10)]
        public string FComponent { get; set; }

        [StringLength(10)]
        public string FDateCNCStart { get; set; }

        [StringLength(10)]
        public string FDateTempleStart { get; set; }

        [StringLength(10)]
        public string FDateCNC { get; set; }

        [StringLength(10)]
        public string FDateTemple { get; set; }

        [StringLength(10)]
        public string FDateAssemble { get; set; }

        [StringLength(10)]
        public string FDatePolish { get; set; }

        [StringLength(10)]
        public string FDateFinish { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDeliverydate { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblOrder tblOrder { get; set; }
    }
}
