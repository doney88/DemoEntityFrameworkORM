namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSubBOM")]
    public partial class tblComponentSubBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblComponentSubBOM()
        {
            tblBOMs = new HashSet<tblBOM>();
        }

        [Key]
        public int FComponentSubBOMID { get; set; }

        public int? FProcessBOMID { get; set; }

        public int FMainID { get; set; }

        public int FChildID { get; set; }

        public int FSupplierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblComponentSub tblComponentSub1 { get; set; }
    }
}
