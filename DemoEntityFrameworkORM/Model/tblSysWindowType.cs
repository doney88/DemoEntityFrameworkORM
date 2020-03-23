namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysWindowType")]
    public partial class tblSysWindowType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSysWindowType()
        {
            tblSysMenus = new HashSet<tblSysMenu>();
        }

        [Key]
        public int FWindowTypeID { get; set; }

        [Required]
        [StringLength(25)]
        public string FWindowType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSysMenu> tblSysMenus { get; set; }
    }
}
