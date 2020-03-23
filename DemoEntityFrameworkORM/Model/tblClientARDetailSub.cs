namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientARDetailSub")]
    public partial class tblClientARDetailSub
    {
        [Key]
        public int FClientARDetailSubID { get; set; }

        public int FClientARDetailID { get; set; }

        public int FPDTWHID { get; set; }

        public short FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FAmount { get; set; }

        public virtual tblClientARDetail tblClientARDetail { get; set; }

        public virtual tblPDTWH tblPDTWH { get; set; }
    }
}
