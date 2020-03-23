namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSectionCost")]
    public partial class tblSectionCost
    {
        [Key]
        public int FSectionCostID { get; set; }

        public int FSectionID { get; set; }

        [Required]
        [StringLength(6)]
        public string FYearMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal FSectionSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal FAuxiliaryCost { get; set; }

        [Column(TypeName = "money")]
        public decimal FMouldCost { get; set; }

        public virtual tblSection tblSection { get; set; }
    }
}
