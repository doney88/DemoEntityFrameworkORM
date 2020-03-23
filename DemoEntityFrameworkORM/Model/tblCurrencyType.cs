namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCurrencyType")]
    public partial class tblCurrencyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCurrencyType()
        {
            tblQuotations = new HashSet<tblQuotation>();
        }

        [Key]
        public int FCurrencyID { get; set; }

        [Required]
        [StringLength(5)]
        public string FCurrencyCode { get; set; }

        [Required]
        [StringLength(10)]
        public string FCurrencyName { get; set; }

        [Required]
        [StringLength(25)]
        public string FEnglishName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FRaleToRMB { get; set; }

        [Column(TypeName = "date")]
        public DateTime FUpdateData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotation> tblQuotations { get; set; }
    }
}
