namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSalarySum")]
    public partial class tblSalarySum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSalarySum()
        {
            tblSalaries = new HashSet<tblSalary>();
        }

        [Key]
        public int FSalarySumID { get; set; }

        public short? FYear { get; set; }

        public byte? FMonth { get; set; }

        [Column(TypeName = "money")]
        public decimal? FSalarySum { get; set; }

        public int? FWorkDaySum { get; set; }

        public int? FWorkDayBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSalary> tblSalaries { get; set; }
    }
}
