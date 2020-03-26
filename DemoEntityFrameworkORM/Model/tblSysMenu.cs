namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysMenu")]
    public partial class tblSysMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSysMenu()
        {
            tblSysMenu1 = new HashSet<tblSysMenu>();
            tblSysRoleRights = new HashSet<tblSysRoleRight>();
        }

        [Key]
        public int FSysMenuID { get; set; }

        public int FSortID { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [StringLength(50)]
        public string FIcon { get; set; }

        public bool FDeveloperOnly { get; set; }

        public bool FExpandDefault { get; set; }

        public int? FFontColor { get; set; }

        public int? FBackColor { get; set; }

        public bool FBold { get; set; }

        public int? FSysMenuParentID { get; set; }

        public int? FMenuCommandID { get; set; }

        [StringLength(100)]
        public string FDllPath { get; set; }

        public int? FWindowTypeID { get; set; }

        [StringLength(50)]
        public string FOpenParameter { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        public virtual tblSysMenuCommand tblSysMenuCommand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSysMenu> tblSysMenu1 { get; set; }

        public virtual tblSysMenu tblSysMenu2 { get; set; }

        public virtual tblSysWindowType tblSysWindowType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSysRoleRight> tblSysRoleRights { get; set; }
    }
}
