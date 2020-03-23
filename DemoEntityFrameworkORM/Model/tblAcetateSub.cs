namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcetateSub")]
    public partial class tblAcetateSub
    {
        [Key]
        public int FAcetateSubID { get; set; }

        public int FComponentSubID { get; set; }

        public int FAcetateID { get; set; }

        public int FAcetateSizeID { get; set; }

        public decimal FThick { get; set; }

        [StringLength(25)]
        public string FSpecSpecial { get; set; }

        public int FMaterialID { get; set; }

        public virtual tblAcetate tblAcetate { get; set; }

        public virtual tblAcetateSize tblAcetateSize { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }
    }
}
