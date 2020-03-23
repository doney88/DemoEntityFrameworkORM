namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentCartonSub")]
    public partial class tblComponentCartonSub
    {
        [Key]
        public int FCartonSubID { get; set; }

        public int? FComponentSubID { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
