namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBOM")]
    public partial class tblBOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBOM()
        {
            tblOrderSubBOMs = new HashSet<tblOrderSubBOM>();
        }

        [Key]
        public int FBOMID { get; set; }

        public int? FComponentBOMID { get; set; }

        public int? FComponentSubBOMID { get; set; }

        public int? FProcessBOMSubID { get; set; }

        public int FMainID { get; set; }

        public int FChildID { get; set; }

        public int FSupplierID { get; set; }

        public decimal FQty { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FIsLorR { get; set; }

        public virtual tblProcessBomSub tblProcessBomSub { get; set; }

        public virtual tblComponentBOM tblComponentBOM { get; set; }

        public virtual tblComponentSubBOM tblComponentSubBOM { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblMaterial tblMaterial1 { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOM> tblOrderSubBOMs { get; set; }
    }
}
