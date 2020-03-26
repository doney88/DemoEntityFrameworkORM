namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentJB")]
    public partial class tblComponentJB
    {
        [Key]
        public int FJBID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidthMax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThickMax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FTailWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FHingeWidth { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
