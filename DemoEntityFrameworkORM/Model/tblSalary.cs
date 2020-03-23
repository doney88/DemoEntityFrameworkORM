namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSalary")]
    public partial class tblSalary
    {
        public int ID { get; set; }

        public int? FEmployeeID { get; set; }

        public int? FSalarySumID { get; set; }

        public int? FWorkDay { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSalaryBase { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal? FBorrow { get; set; }

        [Column(TypeName = "money")]
        public decimal? FFine { get; set; }

        [Column(TypeName = "money")]
        public decimal? FInsurance { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblSalarySum tblSalarySum { get; set; }
    }
}
