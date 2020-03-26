namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRightValue")]
    public partial class tblRightValue
    {
        [Key]
        public int FRightValueId { get; set; }

        public int? FRightItemId { get; set; }

        [StringLength(5)]
        public string FUserName { get; set; }

        public bool FRightValue { get; set; }
    }
}
