namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentJBSub")]
    public partial class tblComponentJBSub
    {
        [Key]
        public int FJBSubID { get; set; }

        public int? FComponentSubID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FLengthCore { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FLength { get; set; }

        public int? FPlateColorID { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }
    }
}
