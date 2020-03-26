namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRptProductionHead")]
    public partial class tblRptProductionHead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRptProductionHead()
        {
            tblRptProductionComponents = new HashSet<tblRptProductionComponent>();
        }

        [Key]
        public int FProductionHeadID { get; set; }

        public int FOrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string FOrderNum { get; set; }

        [StringLength(255)]
        public string FOrderCust { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDateDeliver { get; set; }

        public byte FQtyModel { get; set; }

        public short FQtyTotal { get; set; }

        [StringLength(4)]
        public string FType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FCreateTime { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Required]
        [StringLength(3)]
        public string FClientNum { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRptProductionComponent> tblRptProductionComponents { get; set; }
    }
}
