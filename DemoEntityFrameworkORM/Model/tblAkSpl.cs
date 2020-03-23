namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAkSpl")]
    public partial class tblAkSpl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FAkSplID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FSupplierID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FYear { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte FMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal FPurchase { get; set; }

        [Column(TypeName = "money")]
        public decimal FDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal FChange { get; set; }

        [Column(TypeName = "money")]
        public decimal FAkDue { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public bool FCheck { get; set; }

        public bool FPayed { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal FAktDue { get; set; }
    }
}
