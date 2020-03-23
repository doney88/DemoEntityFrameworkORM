namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProduct")]
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            tblComponentLens = new HashSet<tblComponentLen>();
            tblProductSKUs = new HashSet<tblProductSKU>();
        }

        [Key]
        public int FProductID { get; set; }

        public int FComponentID { get; set; }

        [Required]
        [StringLength(15)]
        public string FProductCode { get; set; }

        [Required]
        [StringLength(15)]
        public string FSize { get; set; }

        public int FCat3ID { get; set; }

        [StringLength(2)]
        public string FGender { get; set; }

        public int? FTempleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        public int FClientID { get; set; }

        public int? FStock { get; set; }

        public bool FKill { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FPicture { get; set; }

        public int? FFrontID { get; set; }

        public int? FLenID { get; set; }

        public bool? FReadyStocks { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        public virtual tblClient tblClient { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblComponent tblComponent1 { get; set; }

        public virtual tblComponent tblComponent2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLen> tblComponentLens { get; set; }

        public virtual tblPartsTemple tblPartsTemple { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSKU> tblProductSKUs { get; set; }
    }
}
