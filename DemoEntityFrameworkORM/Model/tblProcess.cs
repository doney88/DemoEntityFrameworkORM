namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcess")]
    public partial class tblProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcess()
        {
            tblClientQualities = new HashSet<tblClientQuality>();
            tblComponentQualities = new HashSet<tblComponentQuality>();
            tblOrderProcessBOMs = new HashSet<tblOrderProcessBOM>();
            tblProductionSampleSubSubs = new HashSet<tblProductionSampleSubSub>();
            tblProductionMonths = new HashSet<tblProductionMonth>();
            tblProductionPlans = new HashSet<tblProductionPlan>();
            tblRptProductionMaterials = new HashSet<tblRptProductionMaterial>();
            tblRptProductionQualities = new HashSet<tblRptProductionQuality>();
            tblRptProductionCardQualities = new HashSet<tblRptProductionCardQuality>();
            tblRptProductionCardMaterials = new HashSet<tblRptProductionCardMaterial>();
            tblProcessTemplateSubs = new HashSet<tblProcessTemplateSub>();
            tblProcessBOMs = new HashSet<tblProcessBOM>();
            tblProcessBomSubs = new HashSet<tblProcessBomSub>();
            tblProcessSubs = new HashSet<tblProcessSub>();
            tblProductions = new HashSet<tblProduction>();
        }

        [Key]
        public int FProcessID { get; set; }

        [Required]
        [StringLength(15)]
        public string FProcessName { get; set; }

        public int FSectionID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientQuality> tblClientQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentQuality> tblComponentQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderProcessBOM> tblOrderProcessBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionSampleSubSub> tblProductionSampleSubSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionMonth> tblProductionMonths { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionPlan> tblProductionPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionMaterial> tblRptProductionMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionQuality> tblRptProductionQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardQuality> tblRptProductionCardQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardMaterial> tblRptProductionCardMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessTemplateSub> tblProcessTemplateSubs { get; set; }

        public virtual tblSection tblSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBOM> tblProcessBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBomSub> tblProcessBomSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessSub> tblProcessSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduction> tblProductions { get; set; }
    }
}
