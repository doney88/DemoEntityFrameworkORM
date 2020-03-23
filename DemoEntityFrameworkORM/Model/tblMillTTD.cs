namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMillTTD")]
    public partial class tblMillTTD
    {
        [Key]
        public int FTTDID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FShankDiameter { get; set; }

        [StringLength(2)]
        public string FGroove { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FGrooveWidth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FGrooveDepth { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FGrooveRadius { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
