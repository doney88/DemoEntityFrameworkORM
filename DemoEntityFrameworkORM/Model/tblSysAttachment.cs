namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysAttachment")]
    public partial class tblSysAttachment
    {
        [Key]
        public int FAttachmentID { get; set; }

        public int? FAttachmentTypeID { get; set; }

        public int FIndexID { get; set; }

        [StringLength(50)]
        public string FFolder { get; set; }

        [Required]
        [StringLength(80)]
        public string FPath { get; set; }

        [Required]
        [StringLength(100)]
        public string FFileName { get; set; }

        [StringLength(50)]
        public string FNote { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FCreateDate { get; set; }

        public virtual tblSysAttachmentType tblSysAttachmentType { get; set; }
    }
}
