namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSpringBox")]
    public partial class tblComponentSpringBox
    {
        [Key]
        public int FSpringBoxID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FHeight { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
