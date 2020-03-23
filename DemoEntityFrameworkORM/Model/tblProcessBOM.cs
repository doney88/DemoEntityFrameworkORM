namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessBOM")]
    public partial class tblProcessBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcessBOM()
        {
            tblProcessBOM1 = new HashSet<tblProcessBOM>();
            tblProcessBomSubs = new HashSet<tblProcessBomSub>();
        }

        [Key]
        public int FProcessBOMID { get; set; }

        public int? FProcessBOMIDPrev { get; set; }

        public int FComponentID { get; set; }

        public int FProcessID { get; set; }

        public int? FSortID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FSectionID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblSection tblSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBOM> tblProcessBOM1 { get; set; }

        public virtual tblProcessBOM tblProcessBOM2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBomSub> tblProcessBomSubs { get; set; }
    }
}
