namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentTrimSub")]
    public partial class tblComponentTrimSub
    {
        [Key]
        public int FTrimSubID { get; set; }

        public int FComponentSubID { get; set; }

        public int FPlateColorID { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblPlateColor tblPlateColor { get; set; }
    }
}
