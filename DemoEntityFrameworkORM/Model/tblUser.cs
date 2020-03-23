namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUser")]
    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            tblUserRoles = new HashSet<tblUserRole>();
        }

        [Required]
        [StringLength(5)]
        public string FUserName { get; set; }

        [Required]
        [StringLength(255)]
        public string FPassword { get; set; }

        public short FWorkNum { get; set; }

        [StringLength(255)]
        public string FEmailAccount { get; set; }

        [Key]
        public int FUserID { get; set; }

        public bool FDeveloper { get; set; }

        public int? FEmployeeID { get; set; }

        public virtual tblEmployee tblEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserRole> tblUserRoles { get; set; }
    }
}
