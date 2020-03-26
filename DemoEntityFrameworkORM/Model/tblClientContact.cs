namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientContact")]
    public partial class tblClientContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientContact()
        {
            tblPDTWHBills = new HashSet<tblPDTWHBill>();
        }

        [Key]
        public int FClientContactID { get; set; }

        public int? FClientID { get; set; }

        [StringLength(15)]
        public string FPerson { get; set; }

        [StringLength(50)]
        public string FName_En { get; set; }

        [StringLength(5)]
        public string FPrefix { get; set; }

        [StringLength(5)]
        public string FTitle { get; set; }

        [StringLength(25)]
        public string FDepartment { get; set; }

        [StringLength(50)]
        public string FMobile { get; set; }

        [StringLength(25)]
        public string FTelephone { get; set; }

        [StringLength(25)]
        public string FFax { get; set; }

        [StringLength(100)]
        public string FEmail { get; set; }

        [StringLength(12)]
        public string FQQ { get; set; }

        public bool FMain { get; set; }

        public bool FConsignee { get; set; }

        public bool FAKTCheck { get; set; }

        public bool FResign { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPDTWHBill> tblPDTWHBills { get; set; }
    }
}
