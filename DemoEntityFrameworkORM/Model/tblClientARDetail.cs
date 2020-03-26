namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClientARDetail")]
    public partial class tblClientARDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClientARDetail()
        {
            tblClientARDetailSubs = new HashSet<tblClientARDetailSub>();
        }

        [Key]
        public int FClientARDetailID { get; set; }

        public int FClientARID { get; set; }

        public int? FOrderID { get; set; }

        public int? FComponentID { get; set; }

        public int? FComponentSubID { get; set; }

        [Required]
        [StringLength(255)]
        public string FOrderCust { get; set; }

        public short? FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblClientAR tblClientAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetailSub> tblClientARDetailSubs { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblComponentSub tblComponentSub { get; set; }

        public virtual tblOrder tblOrder { get; set; }
    }
}
