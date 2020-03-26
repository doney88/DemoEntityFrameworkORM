namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMaterialWorkShop")]
    public partial class tblMaterialWorkShop
    {
        [Key]
        public int FMaterialWorkShopID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FStock { get; set; }

        public int? FSectionID { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblSection tblSection { get; set; }
    }
}
