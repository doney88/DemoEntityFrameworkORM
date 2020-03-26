namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentCoreSP")]
    public partial class tblComponentCoreSP
    {
        [Key]
        public int FCoreID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHingeWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FBoxWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FCoreDiameter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FBottomWidth { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
