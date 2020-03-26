namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccountMonth")]
    public partial class tblAccountMonth
    {
        [Key]
        public int FAccountMonthID { get; set; }

        public int FAccountID { get; set; }

        [Required]
        [StringLength(6)]
        public string FYearMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public virtual tblAccount tblAccount { get; set; }
    }
}
