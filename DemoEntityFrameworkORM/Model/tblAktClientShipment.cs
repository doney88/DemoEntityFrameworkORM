namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAktClientShipment")]
    public partial class tblAktClientShipment
    {
        [Key]
        public int FAktClientID { get; set; }

        public int FClientID { get; set; }

        public short FYear { get; set; }

        public byte FMonth { get; set; }

        public bool FCheck { get; set; }

        public int? FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? FAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FReceived { get; set; }

        public bool? FDone { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCommition { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCommitionPayed { get; set; }

        public bool? FCommitionDone { get; set; }

        [Column(TypeName = "money")]
        public decimal? FOtherAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? FAmountTotal { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        public virtual tblClient tblClient { get; set; }
    }
}
