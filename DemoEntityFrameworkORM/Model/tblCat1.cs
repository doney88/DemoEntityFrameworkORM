namespace DemoEntityFrameworkORM
{
    using MyMiniOrm.Commons;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCat1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCat1()
        {
            tblCat2 = new HashSet<tblCat2>();
        }
        //[MyKey(FieldName ="FCat1ID",IsIncrement =true)]
        //public int Id { get; set; }

        [Key]
        public int FCat1ID { get; set; }

        [Required]
        [StringLength(1)]
        public string FCat1Code { get; set; }

        [Required]
        [StringLength(5)]
        public string FCat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat2> tblCat2 { get; set; }
    }
}
