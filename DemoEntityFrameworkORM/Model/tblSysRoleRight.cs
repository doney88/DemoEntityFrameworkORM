namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysRoleRight")]
    public partial class tblSysRoleRight
    {
        [Key]
        public int FRoleRightID { get; set; }

        public int FRoleID { get; set; }

        public int FSysMenuID { get; set; }

        [Required]
        [StringLength(50)]
        public string FRightName { get; set; }

        public bool FRightValue { get; set; }

        public virtual tblSysMenu tblSysMenu { get; set; }

        public virtual tblSysRole tblSysRole { get; set; }
    }
}
