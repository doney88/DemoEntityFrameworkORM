namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPara_GetFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPara_GetFile()
        {
            tblCat3 = new HashSet<tblCat3>();
            tblCat31 = new HashSet<tblCat3>();
            tblCat32 = new HashSet<tblCat3>();
        }

        [Key]
        public int FParaID { get; set; }

        [Required]
        [StringLength(50)]
        public string FParaName { get; set; }

        [Required]
        [StringLength(255)]
        public string FParaValue { get; set; }

        [StringLength(255)]
        public string FMark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat3> tblCat3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat3> tblCat31 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat3> tblCat32 { get; set; }
    }
}
