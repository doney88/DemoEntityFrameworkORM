namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAKTClientPayment")]
    public partial class tblAKTClientPayment
    {
        [Key]
        public int FClientPaymentID { get; set; }

        public int FClientID { get; set; }

        [Column(TypeName = "money")]
        public decimal FPayment { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblClient tblClient { get; set; }
    }
}
