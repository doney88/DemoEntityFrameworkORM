namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClaim")]
    public partial class tblClaim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClaim()
        {
            tblClaimSubs = new HashSet<tblClaimSub>();
        }

        [Key]
        public int FClaimID { get; set; }

        [Required]
        [StringLength(10)]
        public string FClaimNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        public int FSupplierID { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClaimSub> tblClaimSubs { get; set; }
    }
}
