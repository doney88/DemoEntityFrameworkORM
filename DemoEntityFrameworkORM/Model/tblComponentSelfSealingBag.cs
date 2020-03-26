namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSelfSealingBag")]
    public partial class tblComponentSelfSealingBag
    {
        [Key]
        public int FBagID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLengthHead { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWidth { get; set; }

        [StringLength(25)]
        public string FDescription { get; set; }

        public int? FMaterialTypeID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMaterialType tblMaterialType { get; set; }
    }
}
