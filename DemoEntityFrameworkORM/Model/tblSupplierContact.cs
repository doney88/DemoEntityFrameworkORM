namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSupplierContact")]
    public partial class tblSupplierContact
    {
        [Key]
        public int FContactID { get; set; }

        public int FSupplierID { get; set; }

        [StringLength(15)]
        public string FPerson { get; set; }

        [StringLength(5)]
        public string FPrefix { get; set; }

        [StringLength(15)]
        public string FTitle { get; set; }

        [StringLength(25)]
        public string FDepartment { get; set; }

        [StringLength(25)]
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

        public bool FResign { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }
    }
}
