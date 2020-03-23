namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProductionSampleSub")]
    public partial class tblProductionSampleSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProductionSampleSub()
        {
            tblProductionSampleSubSubs = new HashSet<tblProductionSampleSubSub>();
        }

        [Key]
        public int FProductionSampleSubID { get; set; }

        public int FProductionSampleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FDate { get; set; }

        public byte? FQtyCNC { get; set; }

        public byte? FQtyTemple { get; set; }

        public byte? FQtyAssemble { get; set; }

        public byte? FQtyPolish { get; set; }

        public byte? FQtyPacking { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProductionSample tblProductionSample { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductionSampleSubSub> tblProductionSampleSubSubs { get; set; }
    }
}
