namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentTT")]
    public partial class tblComponentTT
    {
        [Key]
        public int FTTID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterOuter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterInside { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
