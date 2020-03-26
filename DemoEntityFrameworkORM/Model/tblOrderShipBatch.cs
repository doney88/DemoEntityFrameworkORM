namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOrderShipBatch")]
    public partial class tblOrderShipBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblOrderShipBatch()
        {
            tblOrderShipBatchSubs = new HashSet<tblOrderShipBatchSub>();
        }

        [Key]
        public int FOrderShipBatchID { get; set; }

        public int FOrderID { get; set; }

        [StringLength(50)]
        public string FPOCust { get; set; }

        public bool FShip { get; set; }

        [Required]
        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblOrder tblOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderShipBatchSub> tblOrderShipBatchSubs { get; set; }
    }
}
