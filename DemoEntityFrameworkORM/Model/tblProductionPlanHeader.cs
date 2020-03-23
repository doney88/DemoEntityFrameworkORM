namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionPlanHeader")]
    public partial class tblProductionPlanHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductionPlanHeader()
        {
            tblProductionPlans = new HashSet<tblProductionPlan>();
        }

        [Key]
        public int FProductionPlanHeaderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FPlanHeaderDate { get; set; }

        [StringLength(255)]
        public string FHeaderNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionPlan> tblProductionPlans { get; set; }
    }
}
