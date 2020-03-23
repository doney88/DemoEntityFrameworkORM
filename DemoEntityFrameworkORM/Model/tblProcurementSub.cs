namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcurementSub")]
    public partial class tblProcurementSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcurementSub()
        {
            tblMWHInPs = new HashSet<tblMWHInP>();
            tblMWHInPTemps = new HashSet<tblMWHInPTemp>();
            tblProcurementSubBOMs = new HashSet<tblProcurementSubBOM>();
        }

        [Key]
        public int FPListID { get; set; }

        public int FPOID { get; set; }

        public int? FOrderID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FStock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FQtyRequire { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FConfirmDate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FMWHInPQty { get; set; }

        public bool FPrintPic { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? FDone { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInP> tblMWHInPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHInPTemp> tblMWHInPTemps { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblProcurement tblProcurement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }
    }
}
