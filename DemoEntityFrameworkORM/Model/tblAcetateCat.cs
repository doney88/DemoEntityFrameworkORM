namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcetateCat")]
    public partial class tblAcetateCat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAcetateCat()
        {
            tblAcetates = new HashSet<tblAcetate>();
        }

        [Key]
        public int FAcetateCatID { get; set; }

        public int FSupplierID { get; set; }

        [Required]
        [StringLength(25)]
        public string FSerieCode { get; set; }

        [Required]
        [StringLength(2)]
        public string FTechType { get; set; }

        [Required]
        [StringLength(3)]
        public string FAcetateType { get; set; }

        public int FAcetateSizeID { get; set; }

        [StringLength(50)]
        public string FSctructure { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        public bool FVAT { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public double? FDensity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetate> tblAcetates { get; set; }

        public virtual tblAcetateSize tblAcetateSize { get; set; }
    }
}
