namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSTN")]
    public partial class tblComponentSTN
    {
        [Key]
        public int FSTNID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterEX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterIN { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
