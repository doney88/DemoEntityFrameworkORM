namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentMould")]
    public partial class tblComponentMould
    {
        [Key]
        public int FComponentMouldID { get; set; }

        public int FComponentID { get; set; }

        public int FCat3ID { get; set; }

        public int FMouldID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblComponent tblComponent1 { get; set; }
    }
}
