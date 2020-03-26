namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentLenRawSub")]
    public partial class tblComponentLenRawSub
    {
        [Key]
        public int FLenRawSubID { get; set; }

        public int? FComponentSubID { get; set; }

        [Required]
        [StringLength(15)]
        public string FShapSpec { get; set; }

        [Required]
        [StringLength(4)]
        public string FBase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThick { get; set; }

        public bool FStrengthen { get; set; }
    }
}
