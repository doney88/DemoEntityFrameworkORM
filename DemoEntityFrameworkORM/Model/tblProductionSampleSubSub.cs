namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionSampleSubSub")]
    public partial class tblProductionSampleSubSub
    {
        [Key]
        public int FProductionSampleSubSubID { get; set; }

        public int? FProductionSampleSubID { get; set; }

        public int? FOrderID { get; set; }

        public int? FComponentID { get; set; }

        public short FQty { get; set; }

        public int FProcessID { get; set; }

        public bool FCount { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblProductionSampleSub tblProductionSampleSub { get; set; }
    }
}
