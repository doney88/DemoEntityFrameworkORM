namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderProcessBOM")]
    public partial class tblOrderProcessBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderProcessBOM()
        {
            tblOrderProcessBOM1 = new HashSet<tblOrderProcessBOM>();
            tblOrderSubBOMs = new HashSet<tblOrderSubBOM>();
        }

        [Key]
        public int FOrderProcessBOMID { get; set; }

        public int? FOrderProcessBOMIDPrev { get; set; }

        public int FProcessBOMSubID { get; set; }

        public int FProcessID { get; set; }

        public int FOrderBOMID { get; set; }

        public int? FSortID { get; set; }

        public int FSectionID { get; set; }

        public bool FDone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        public byte FQty { get; set; }

        public virtual tblProcessBomSub tblProcessBomSub { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblSection tblSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderProcessBOM> tblOrderProcessBOM1 { get; set; }

        public virtual tblOrderProcessBOM tblOrderProcessBOM2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOM> tblOrderSubBOMs { get; set; }
    }
}
