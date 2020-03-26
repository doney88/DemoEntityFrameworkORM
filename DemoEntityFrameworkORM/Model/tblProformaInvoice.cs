namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProformaInvoice")]
    public partial class tblProformaInvoice
    {
        [Key]
        public int FPIID { get; set; }

        public int? FOrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string FPINum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FDeliveryDate { get; set; }

        public virtual tblOrder tblOrder { get; set; }
    }
}
