namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentBOM")]
    public partial class tblComponentBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblComponentBOM()
        {
            tblBOMs = new HashSet<tblBOM>();
        }

        [Key]
        public int FComponentBOMID { get; set; }

        public int? FProcessBOMID { get; set; }

        public int FComponentID { get; set; }

        public int FComponentSubID { get; set; }

        public int FSupplierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBOM> tblBOMs { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }
    }
}
