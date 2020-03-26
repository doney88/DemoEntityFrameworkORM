namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSection")]
    public partial class tblSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSection()
        {
            tblEmployees = new HashSet<tblEmployee>();
            tblMaterialWorkShops = new HashSet<tblMaterialWorkShop>();
            tblMWHOutBills = new HashSet<tblMWHOutBill>();
            tblOrderProcessBOMs = new HashSet<tblOrderProcessBOM>();
            tblProcesses = new HashSet<tblProcess>();
            tblProcessBOMs = new HashSet<tblProcessBOM>();
            tblProcessBomSubs = new HashSet<tblProcessBomSub>();
            tblRptProductionCardComponents = new HashSet<tblRptProductionCardComponent>();
            tblRptProductionSections = new HashSet<tblRptProductionSection>();
            tblSectionCosts = new HashSet<tblSectionCost>();
        }

        [Key]
        public int FSectionID { get; set; }

        public int FDeptID { get; set; }

        [Required]
        [StringLength(10)]
        public string FSectionName { get; set; }

        public int? FSortID { get; set; }

        public int? FProductionQtyStandard { get; set; }

        public virtual tblDepartment tblDepartment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterialWorkShop> tblMaterialWorkShops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMWHOutBill> tblMWHOutBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderProcessBOM> tblOrderProcessBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcess> tblProcesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBOM> tblProcessBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessBomSub> tblProcessBomSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionCardComponent> tblRptProductionCardComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionSection> tblRptProductionSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSectionCost> tblSectionCosts { get; set; }
    }
}
