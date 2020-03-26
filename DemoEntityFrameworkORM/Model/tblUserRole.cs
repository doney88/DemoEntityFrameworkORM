namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserRole")]
    public partial class tblUserRole
    {
        [Key]
        public int FUserRoleID { get; set; }

        public int? FUserID { get; set; }

        public int? FRoleID { get; set; }

        public virtual tblSysRole tblSysRole { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
