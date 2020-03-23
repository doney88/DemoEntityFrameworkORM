namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcetate")]
    public partial class tblAcetate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAcetate()
        {
            tblAcetateSubs = new HashSet<tblAcetateSub>();
        }

        [Key]
        public int FAcetateID { get; set; }

        public int? FComponentID { get; set; }

        [Required]
        [StringLength(25)]
        public string FAcetateCode { get; set; }

        [StringLength(30)]
        public string FColor { get; set; }

        public int FAcetateCatID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetateSub> tblAcetateSubs { get; set; }

        public virtual tblAcetateCat tblAcetateCat { get; set; }

        public virtual tblComponent tblComponent { get; set; }
    }
}
