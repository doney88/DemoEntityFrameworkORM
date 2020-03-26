namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPaymentTerm")]
    public partial class tblPaymentTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPaymentTerm()
        {
            tblClientARs = new HashSet<tblClientAR>();
        }

        [Key]
        public int FPaymentTermID { get; set; }

        [Required]
        [StringLength(10)]
        public string FPaymentTerm_CN { get; set; }

        [Required]
        [StringLength(50)]
        public string FPaymentTerm_En { get; set; }

        public byte FPaymentTime { get; set; }

        [Required]
        [StringLength(1)]
        public string FTimeUnit_CN { get; set; }

        [Required]
        [StringLength(10)]
        public string FTimeUnit_EN { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientAR> tblClientARs { get; set; }
    }
}
