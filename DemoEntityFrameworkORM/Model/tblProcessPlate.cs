namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessPlate")]
    public partial class tblProcessPlate
    {
        [Key]
        public int FProcessPlateID { get; set; }

        public int FProcessSubID { get; set; }

        public int FPlateColorID { get; set; }

        [Required]
        [StringLength(255)]
        public string FPart { get; set; }

        public bool FVarnish { get; set; }

        [Required]
        [StringLength(2)]
        public string FTech { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }

        public virtual tblProcessSub tblProcessSub { get; set; }
    }
}
