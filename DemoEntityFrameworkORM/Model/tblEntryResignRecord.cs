namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEntryResignRecord")]
    public partial class tblEntryResignRecord
    {
        [Key]
        public int FRecordID { get; set; }

        public int FEmployeeID { get; set; }

        [Required]
        [StringLength(2)]
        public string FStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime FStatusDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }
    }
}
