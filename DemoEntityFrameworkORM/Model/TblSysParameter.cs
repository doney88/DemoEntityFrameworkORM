namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblSysParameter")]
    public partial class TblSysParameter
    {
        [Key]
        public int FParameterID { get; set; }

        [Required]
        [StringLength(50)]
        public string FParameterName { get; set; }

        [StringLength(255)]
        public string FParameterValue { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }
    }
}
