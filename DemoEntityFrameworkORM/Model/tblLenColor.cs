namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLenColor")]
    public partial class tblLenColor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLenColor()
        {
            tblComponentLenRaws = new HashSet<tblComponentLenRaw>();
        }

        [Key]
        public int FLenColorID { get; set; }

        [StringLength(5)]
        public string FLenColorNum { get; set; }

        [StringLength(25)]
        public string FLenColorNumSpl { get; set; }

        [StringLength(50)]
        public string FColor { get; set; }

        public int? FClientID { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTransmittanceMin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTransmittanceMax { get; set; }

        public int? FLenCategoryID { get; set; }

        public virtual tblClient tblClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentLenRaw> tblComponentLenRaws { get; set; }

        public virtual tblEngineerLenCategory tblEngineerLenCategory { get; set; }
    }
}
