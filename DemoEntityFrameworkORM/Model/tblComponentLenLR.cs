namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentLenLR")]
    public partial class tblComponentLenLR
    {
        [Key]
        public int FLenLRID { get; set; }

        public int? FLenID { get; set; }

        [Required]
        [StringLength(10)]
        public string FLorR { get; set; }

        public int FMaterialID { get; set; }

        public virtual tblComponentLen tblComponentLen { get; set; }
    }
}
