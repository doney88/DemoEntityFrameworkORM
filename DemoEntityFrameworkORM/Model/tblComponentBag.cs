namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentBag")]
    public partial class tblComponentBag
    {
        [Key]
        public int FBagID { get; set; }

        public int FComponentID { get; set; }

        public decimal FLength { get; set; }

        public decimal FWidth { get; set; }

        [StringLength(255)]
        public string FDescription { get; set; }

        public bool FTwoOpen { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
