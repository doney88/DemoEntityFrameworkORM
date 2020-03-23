namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysLorR")]
    public partial class tblSysLorR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FLorRID { get; set; }

        [Key]
        [StringLength(1)]
        public string FLorR { get; set; }

        public bool FIs { get; set; }

        public byte FQty { get; set; }
    }
}
