namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPartsTempleSub")]
    public partial class tblPartsTempleSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPartsTempleSub()
        {
            tblProductSKUs = new HashSet<tblProductSKU>();
        }

        [Key]
        public int FTempleSubID { get; set; }

        public int FTempleID { get; set; }

        public int FComponentSubID { get; set; }

        public short FCode { get; set; }

        [StringLength(50)]
        public string FColor { get; set; }

        public int? FMaterialIDT { get; set; }

        public byte? FCutQtyT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FQtyPerT { get; set; }

        [StringLength(4)]
        public string FCutTypeT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FAcetateQtyT { get; set; }

        [StringLength(255)]
        public string FNoteT { get; set; }

        public int FMaterialID { get; set; }

        public int? FSurfaceID { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblPartsTemple tblPartsTemple { get; set; }

        public virtual tblSurface tblSurface { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }
    }
}
