namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentHingeSub")]
    public partial class tblComponentHingeSub
    {
        [Key]
        public int FHingeSubID { get; set; }

        public int FComponentSubID { get; set; }

        public byte FPantscopic { get; set; }

        public int? FPlateColorID { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }
    }
}
