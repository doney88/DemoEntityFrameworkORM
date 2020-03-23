namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentPlate")]
    public partial class tblComponentPlate
    {
        [Key]
        public int FPlateID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThick { get; set; }

        [StringLength(25)]
        public string FPlateSpec { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
