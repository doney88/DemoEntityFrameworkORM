namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentScrew")]
    public partial class tblComponentScrew
    {
        [Key]
        public int FScrewID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterCup { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameterThread { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [StringLength(2)]
        public string FCupType { get; set; }

        public bool FMill { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
