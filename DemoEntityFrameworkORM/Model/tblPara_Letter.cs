namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPara_Letter
    {
        [Key]
        public int FConfitureID { get; set; }

        [Required]
        public string FSignature { get; set; }

        [Required]
        [StringLength(10)]
        public string FAccount { get; set; }
    }
}
