namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurementConfirmDate")]
    public partial class tblProcurementConfirmDate
    {
        [Key]
        public int FConfirmDateID { get; set; }

        public int FPListID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FConfirmDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDateReply { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }
    }
}
