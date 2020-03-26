namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMWHIni")]
    public partial class tblMWHIni
    {
        public int ID { get; set; }

        public int? FMaterialID { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? FAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public short FYearStart { get; set; }

        public byte FMonthStart { get; set; }

        public short FYearEnd { get; set; }

        public byte FMonthEnd { get; set; }
    }
}
