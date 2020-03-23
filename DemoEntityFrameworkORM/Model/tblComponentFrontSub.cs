namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentFrontSub")]
    public partial class tblComponentFrontSub
    {
        [Key]
        public int FFrontSubID { get; set; }

        public int FComponentSubID { get; set; }

        public int FMaterialID { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
