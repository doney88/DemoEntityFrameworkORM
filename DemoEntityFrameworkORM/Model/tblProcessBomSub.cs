namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessBomSub")]
    public partial class tblProcessBomSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcessBomSub()
        {
            tblBOMs = new HashSet<tblBOM>();
            tblOrderProcessBOMs = new HashSet<tblOrderProcessBOM>();
            tblQuotationBOMs = new HashSet<tblQuotationBOM>();
            tblProcessBomSub1 = new HashSet<tblProcessBomSub>();
        }

        [Key]
        public int FProcessBOMSubID { get; set; }

        public int? FProcessBomSubIDPrev { get; set; }

        public int? FProcessBOMID { get; set; }

        public int FMaterialID { get; set; }

        public int FProcessID { get; set; }

        public int? FSortID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int FSectionID { get; set; }

        public byte FQty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderProcessBOM> tblOrderProcessBOMs { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblProcessBOM tblProcessBOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationBOM> tblQuotationBOMs { get; set; }

        public virtual tblSection tblSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBomSub> tblProcessBomSub1 { get; set; }

        public virtual tblProcessBomSub tblProcessBomSub2 { get; set; }
    }
}
