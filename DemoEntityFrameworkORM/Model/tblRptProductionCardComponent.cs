namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionCardComponent")]
    public partial class tblRptProductionCardComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRptProductionCardComponent()
        {
            tblRptProductionCardComponentSubs = new HashSet<tblRptProductionCardComponentSub>();
            tblRptProductionCardQualities = new HashSet<tblRptProductionCardQuality>();
            tblRptProductionCardMaterials = new HashSet<tblRptProductionCardMaterial>();
            tblRptProductionCardMoulds = new HashSet<tblRptProductionCardMould>();
        }

        [Key]
        public int FProductionCardComponentID { get; set; }

        public int FProductionComponentID { get; set; }

        public int? FComponentID { get; set; }

        public int? FChildComponentID { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [StringLength(255)]
        public string FComponentNum { get; set; }

        [StringLength(255)]
        public string FSpec { get; set; }

        [Required]
        [StringLength(10)]
        public string FSectionName { get; set; }

        public string FProcedure { get; set; }

        public int FSectionID { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblComponent tblComponent1 { get; set; }

        public virtual tblRptProductionComponent tblRptProductionComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardComponentSub> tblRptProductionCardComponentSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardQuality> tblRptProductionCardQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardMaterial> tblRptProductionCardMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardMould> tblRptProductionCardMoulds { get; set; }

        public virtual tblSection tblSection { get; set; }
    }
}
