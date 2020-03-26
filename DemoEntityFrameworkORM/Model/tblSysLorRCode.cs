namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSysLorRCode")]
    public partial class tblSysLorRCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSysLorRCode()
        {
            tblComponents = new HashSet<tblComponent>();
        }

        [Key]
        public int FLorRCodeID { get; set; }

        public bool FIsLorR { get; set; }

        [Required]
        [StringLength(10)]
        public string FLeftCode { get; set; }

        [Required]
        [StringLength(10)]
        public string FRightCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponent> tblComponents { get; set; }
    }
}
