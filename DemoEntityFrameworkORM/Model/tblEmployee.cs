namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployee")]
    public partial class tblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployee()
        {
            tblUsers = new HashSet<tblUser>();
            tblEntryResignRecords = new HashSet<tblEntryResignRecord>();
        }

        [Key]
        public int FEmployeeID { get; set; }

        public int FEmployeeNum { get; set; }

        [Required]
        [StringLength(255)]
        public string FName { get; set; }

        public int FSectionID { get; set; }

        [StringLength(255)]
        public string FPosition { get; set; }

        [StringLength(6)]
        public string FTitle { get; set; }

        [Required]
        [StringLength(1)]
        public string FGender { get; set; }

        public bool? FMarriage { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSalary { get; set; }

        [StringLength(255)]
        public string FMobile { get; set; }

        public int? FHomeTownID { get; set; }

        [StringLength(5)]
        public string FEducation { get; set; }

        [Required]
        [StringLength(18)]
        public string FIdentity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FBirthDay { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(25)]
        public string FBankAccount { get; set; }

        public int? FBankLocalID { get; set; }

        [StringLength(2)]
        public string FStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FSTatusDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }

        public virtual tblSection tblSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEntryResignRecord> tblEntryResignRecords { get; set; }
    }
}
