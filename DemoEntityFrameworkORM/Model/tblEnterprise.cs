namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEnterprise")]
    public partial class tblEnterprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEnterprise()
        {
            tblEnterprise1 = new HashSet<tblEnterprise>();
            tblOrders = new HashSet<tblOrder>();
        }

        [Key]
        public int FEnterpriseID { get; set; }

        public int? FParentID { get; set; }

        public int? FPaymentTermID { get; set; }

        public int FCat2ID { get; set; }

        public int FRole { get; set; }

        [Required]
        [StringLength(10)]
        public string FEnterpriseCode { get; set; }

        [Required]
        [StringLength(50)]
        public string FEnterpriseName { get; set; }

        [Required]
        [StringLength(10)]
        public string FShortName { get; set; }

        [StringLength(50)]
        public string FMainProduct { get; set; }

        public int? FCapability { get; set; }

        [StringLength(25)]
        public string FCountry { get; set; }

        [StringLength(225)]
        public string FWebsite { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FVAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FVATPercent { get; set; }

        public int FAbandon { get; set; }

        public int? FFlag { get; set; }

        [ForeignKey("FCat2ID")]
        public virtual tblCat2 tblCat2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEnterprise> tblEnterprise1 { get; set; }

        public virtual tblEnterprise tblEnterprise2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
