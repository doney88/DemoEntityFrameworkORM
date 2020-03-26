namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentDWD")]
    public partial class tblComponentDWD
    {
        [Key]
        public int FDWDID { get; set; }

        public int FComponentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FDiameter { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
