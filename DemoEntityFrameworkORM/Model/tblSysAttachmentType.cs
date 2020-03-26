namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysAttachmentType")]
    public partial class tblSysAttachmentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSysAttachmentType()
        {
            tblSysAttachments = new HashSet<tblSysAttachment>();
        }

        [Key]
        public int FAttachmentTypeID { get; set; }

        [Required]
        [StringLength(15)]
        public string FAttachmentType { get; set; }

        [Required]
        [StringLength(50)]
        public string FTableName { get; set; }

        [StringLength(50)]
        public string FFolderColumn { get; set; }

        [Required]
        [StringLength(50)]
        public string FIndexColumn { get; set; }

        [Required]
        [StringLength(80)]
        public string FFolderPath { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FCreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSysAttachment> tblSysAttachments { get; set; }
    }
}
