namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAccount")]
    public partial class tblAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccount()
        {
            tblAccount1 = new HashSet<tblAccount>();
            tblAccountMonths = new HashSet<tblAccountMonth>();
        }

        [Key]
        public int FAccountID { get; set; }

        public int? FAccountMainID { get; set; }

        [Required]
        [StringLength(10)]
        public string FAccountCode { get; set; }

        [Required]
        [StringLength(10)]
        public string FAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccount> tblAccount1 { get; set; }

        public virtual tblAccount tblAccount2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountMonth> tblAccountMonths { get; set; }
    }
}
