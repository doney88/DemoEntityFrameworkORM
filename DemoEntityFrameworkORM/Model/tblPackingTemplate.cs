namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPackingTemplate")]
    public partial class tblPackingTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPackingTemplate()
        {
            tblPackingTemplateSubs = new HashSet<tblPackingTemplateSub>();
        }

        [Key]
        public int FPackingTemplateID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        public int? FCustID { get; set; }

        [Column(TypeName = "date")]
        public DateTime FCreateDate { get; set; }

        public bool FCancel { get; set; }

        public virtual tblCust tblCust { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingTemplateSub> tblPackingTemplateSubs { get; set; }
    }
}
