namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductSKU")]
    public partial class tblProductSKU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductSKU()
        {
            tblProductSKUAcetates = new HashSet<tblProductSKUAcetate>();
        }

        [Key]
        public int FProductSKUID { get; set; }

        public int FComponentSubID { get; set; }

        public int FProductID { get; set; }

        public int FMaterialID { get; set; }

        [StringLength(10)]
        public string FColorCode { get; set; }

        public int? FTempleSubID { get; set; }

        public int? FSurfaceID { get; set; }

        [StringLength(255)]
        public string FColor { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FPicture { get; set; }

        public short? FStockDef { get; set; }

        public int? FProductSampleBoxID { get; set; }

        public bool FReadyStock { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblPartsTempleSub tblPartsTempleSub { get; set; }

        public virtual tblProduct tblProduct { get; set; }

        public virtual tblProductSampleBox tblProductSampleBox { get; set; }

        public virtual tblSurface tblSurface { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKUAcetate> tblProductSKUAcetates { get; set; }
    }
}
