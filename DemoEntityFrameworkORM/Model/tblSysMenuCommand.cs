namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysMenuCommand")]
    public partial class tblSysMenuCommand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSysMenuCommand()
        {
            tblSysMenus = new HashSet<tblSysMenu>();
        }

        [Key]
        public int FMenuCommandID { get; set; }

        [Required]
        [StringLength(25)]
        public string FMenuCommandName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSysMenu> tblSysMenus { get; set; }
    }
}
