namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionSection")]
    public partial class tblRptProductionSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRptProductionSection()
        {
            tblRptProductionMaterials = new HashSet<tblRptProductionMaterial>();
            tblRptProductionProcedures = new HashSet<tblRptProductionProcedure>();
            tblRptProductionQualities = new HashSet<tblRptProductionQuality>();
            tblRptProductionSemis = new HashSet<tblRptProductionSemi>();
        }

        [Key]
        public int FProductionSectionID { get; set; }

        public int FProductionComponentID { get; set; }

        public int FSectionID { get; set; }

        [Required]
        [StringLength(10)]
        public string FSectionName { get; set; }

        public virtual tblRptProductionComponent tblRptProductionComponent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionMaterial> tblRptProductionMaterials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionProcedure> tblRptProductionProcedures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionQuality> tblRptProductionQualities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionSemi> tblRptProductionSemis { get; set; }

        public virtual tblSection tblSection { get; set; }
    }
}
