namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentDMST")]
    public partial class tblComponentDMST
    {
        [Key]
        public int FDMSTID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FHeadDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FPinDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FThreadDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FLength { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
