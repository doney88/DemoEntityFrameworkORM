namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCustQuality")]
    public partial class tblCustQuality
    {
        [Key]
        public int FQualityID { get; set; }

        public int FCustID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        public virtual tblCust tblCust { get; set; }
    }
}
