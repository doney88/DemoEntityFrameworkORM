namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDesignFront")]
    public partial class tblDesignFront
    {
        [Key]
        public int FFrontID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FSizeA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FSizeB { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FSizeC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FSizeDBL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FSizeED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBase { get; set; }

        [StringLength(2)]
        public string FGroove { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLengthMargin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidthMargin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FCutThick { get; set; }

        public byte FCutQtyBase { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
