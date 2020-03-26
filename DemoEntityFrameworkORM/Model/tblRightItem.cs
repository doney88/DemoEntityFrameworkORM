namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRightItem")]
    public partial class tblRightItem
    {
        [Key]
        public int FRightItemId { get; set; }

        [Required]
        [StringLength(5)]
        public string FRightGroup { get; set; }

        [Required]
        [StringLength(10)]
        public string FRightClass { get; set; }

        [Required]
        [StringLength(10)]
        public string FRightItem { get; set; }
    }
}
