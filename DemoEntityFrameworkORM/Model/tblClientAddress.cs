namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientAddress")]
    public partial class tblClientAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientAddress()
        {
            tblPDTWHBills = new HashSet<tblPDTWHBill>();
        }

        [Key]
        public int FClientAddressID { get; set; }

        public int? FClientID { get; set; }

        [StringLength(255)]
        public string FAddressTitle { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(50)]
        public string FTelephone { get; set; }

        [StringLength(50)]
        public string FFax { get; set; }

        [StringLength(8)]
        public string FPostCode { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FMain { get; set; }

        public bool FDeliveryTo { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHBill> tblPDTWHBills { get; set; }
    }
}
