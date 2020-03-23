namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionSample")]
    public partial class tblProductionSample
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductionSample()
        {
            tblProductionSampleSubs = new HashSet<tblProductionSampleSub>();
        }

        [Key]
        public int FProductionSampleID { get; set; }

        [Required]
        [StringLength(6)]
        public string FYearMonth { get; set; }

        public byte? FQtyCNC { get; set; }

        public byte? FQtyTemple { get; set; }

        public byte? FQtyAssemble { get; set; }

        public byte? FQtyPolish { get; set; }

        public byte? FQtyPacking { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(25)]
        public string FRegion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionSampleSub> tblProductionSampleSubs { get; set; }
    }
}
