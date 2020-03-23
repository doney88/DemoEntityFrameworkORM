namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMouldTemplePunch")]
    public partial class tblMouldTemplePunch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMouldTemplePunch()
        {
            tblMouldTemplePunchMoulds = new HashSet<tblMouldTemplePunchMould>();
            tblPartsTemples = new HashSet<tblPartsTemple>();
        }

        [Key]
        public int FTemplePunchID { get; set; }

        public short FTemplePunchNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FWidthTop { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FWidthMid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FWidthTip { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FCutWidth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMouldTemplePunchMould> tblMouldTemplePunchMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPartsTemple> tblPartsTemples { get; set; }
    }
}
