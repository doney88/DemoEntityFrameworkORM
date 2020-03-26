namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCat3Process
    {
        [Key]
        public int FCatProcessID { get; set; }

        public int FCat3ID { get; set; }

        public int FProcessID { get; set; }

        public byte FPriority { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }
    }
}
