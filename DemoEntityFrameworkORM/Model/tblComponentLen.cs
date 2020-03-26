namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentLen")]
    public partial class tblComponentLen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblComponentLen()
        {
            tblComponentLenLRs = new HashSet<tblComponentLenLR>();
        }

        [Key]
        public int FLenID { get; set; }

        public int? FProductID { get; set; }

        public int? FComponentID { get; set; }

        [Required]
        [StringLength(3)]
        public string FLenType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThick { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FASize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FBSize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCSize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FEDSize { get; set; }

        [StringLength(4)]
        public string FBase { get; set; }

        [StringLength(2)]
        public string FGroove { get; set; }

        [Required]
        [StringLength(4)]
        public string FMaterial { get; set; }

        [Required]
        [StringLength(10)]
        public string FColor { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        public int? FSupplierID { get; set; }

        public bool FVAT { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLenLR> tblComponentLenLRs { get; set; }

        public virtual tblProduct tblProduct { get; set; }
    }
}
