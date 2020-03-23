namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderMould")]
    public partial class tblOrderMould
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderMould()
        {
            tblProcurementSubBOMs = new HashSet<tblProcurementSubBOM>();
        }

        [Key]
        public int FOrderMouldID { get; set; }

        public int FOrderID { get; set; }

        public bool FPurchased { get; set; }

        public int FSupplierID { get; set; }

        public int FMaterialID { get; set; }

        public bool FArrived { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcurementSubBOM> tblProcurementSubBOMs { get; set; }
    }
}
