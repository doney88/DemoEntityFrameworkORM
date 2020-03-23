namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSubLR")]
    public partial class tblComponentSubLR
    {
        [Key]
        public int FComponentSubLRID { get; set; }

        public int FComponentSubID { get; set; }

        [Required]
        [StringLength(1)]
        public string FLorR { get; set; }

        public int FMaterialID { get; set; }

        public byte? FQty { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
