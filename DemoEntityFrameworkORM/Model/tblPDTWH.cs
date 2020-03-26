namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPDTWH")]
    public partial class tblPDTWH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPDTWH()
        {
            tblClientARDetailSubs = new HashSet<tblClientARDetailSub>();
        }

        [Key]
        public int FPDTWHID { get; set; }

        public int FPDTWHBillID { get; set; }

        public int? FSKUID { get; set; }

        public int FMaterialID { get; set; }

        public short FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal FPrice { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public bool FCharge { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FAmount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCheckDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FRecieveDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClientARDetailSub> tblClientARDetailSubs { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblOrderSub tblOrderSub { get; set; }

        public virtual tblPDTWHBill tblPDTWHBill { get; set; }
    }
}
