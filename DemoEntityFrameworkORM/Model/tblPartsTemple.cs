namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPartsTemple")]
    public partial class tblPartsTemple
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPartsTemple()
        {
            tblPartsTempleSubs = new HashSet<tblPartsTempleSub>();
            tblProducts = new HashSet<tblProduct>();
        }

        [Key]
        public int FTempleID { get; set; }

        [Required]
        [StringLength(25)]
        public string FTempleNum { get; set; }

        public bool FLorR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FLength { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FThick { get; set; }

        public int? FTemplePunchID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FCreateDate { get; set; }

        public int FComponentID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblComponent tblComponent { get; set; }

        public virtual tblMouldTemplePunch tblMouldTemplePunch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTempleSub> tblPartsTempleSubs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }
    }
}
