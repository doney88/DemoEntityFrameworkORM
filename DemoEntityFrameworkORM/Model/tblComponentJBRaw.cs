namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentJBRaw")]
    public partial class tblComponentJBRaw
    {
        [Key]
        public int FJBID { get; set; }

        public int FComponentID { get; set; }

        [StringLength(50)]
        public string FSpec { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
