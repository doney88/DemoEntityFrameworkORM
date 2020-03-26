namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProcessTemplateSub")]
    public partial class tblProcessTemplateSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProcessTemplateSub()
        {
            tblProcessTemplateSub1 = new HashSet<tblProcessTemplateSub>();
        }

        [Key]
        public int FProcessTemplateSubID { get; set; }

        public int FProcessTemplateID { get; set; }

        public int? FProcessTemplateSubIDPrev { get; set; }

        public int? FSortID { get; set; }

        public int FProcessID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public virtual tblProcess tblProcess { get; set; }

        public virtual tblProcessTemplate tblProcessTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessTemplateSub> tblProcessTemplateSub1 { get; set; }

        public virtual tblProcessTemplateSub tblProcessTemplateSub2 { get; set; }
    }
}
