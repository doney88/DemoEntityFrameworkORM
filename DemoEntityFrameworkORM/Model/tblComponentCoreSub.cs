namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentCoreSub")]
    public partial class tblComponentCoreSub
    {
        [Key]
        public int FCoreSubID { get; set; }

        public int FComponentSubID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLengthCore { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FLengthCut { get; set; }

        public int? FPlateColorID { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }
    }
}
