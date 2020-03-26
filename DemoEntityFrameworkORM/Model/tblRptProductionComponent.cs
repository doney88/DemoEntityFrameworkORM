namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionComponent")]
    public partial class tblRptProductionComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRptProductionComponent()
        {
            tblRptProductionCardComponents = new HashSet<tblRptProductionCardComponent>();
            tblRptProductionProcesses = new HashSet<tblRptProductionProcess>();
            tblRptProductionSections = new HashSet<tblRptProductionSection>();
            tblRptProductionComponentSubs = new HashSet<tblRptProductionComponentSub>();
        }

        [Key]
        public int FProductionComponentID { get; set; }

        public int FProductionHeadID { get; set; }

        public int FComponentID { get; set; }

        [StringLength(15)]
        public string FComponentNum { get; set; }

        [Required]
        [StringLength(50)]
        public string FModelCust { get; set; }

        [StringLength(15)]
        public string FSize { get; set; }

        [StringLength(10)]
        public string FFrontComponentNum { get; set; }

        [StringLength(5)]
        public string FTemplePunchNum { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public byte FSortID { get; set; }

        public short FQtyComponent { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardComponent> tblRptProductionCardComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionProcess> tblRptProductionProcesses { get; set; }

        public virtual tblRptProductionHead tblRptProductionHead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionSection> tblRptProductionSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionComponentSub> tblRptProductionComponentSubs { get; set; }
    }
}
