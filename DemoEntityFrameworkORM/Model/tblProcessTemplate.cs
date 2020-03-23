namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessTemplate")]
    public partial class tblProcessTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcessTemplate()
        {
            tblComponents = new HashSet<tblComponent>();
            tblProcessTemplateSubs = new HashSet<tblProcessTemplateSub>();
        }

        [Key]
        public int FProcessTemplateID { get; set; }

        [Required]
        [StringLength(255)]
        public string FDescription { get; set; }

        public int FCat3ID { get; set; }

        public virtual tblCat3 tblCat3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponent> tblComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessTemplateSub> tblProcessTemplateSubs { get; set; }
    }
}
