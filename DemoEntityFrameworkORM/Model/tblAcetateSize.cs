namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcetateSize")]
    public partial class tblAcetateSize
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAcetateSize()
        {
            tblAcetateCats = new HashSet<tblAcetateCat>();
            tblAcetateSubs = new HashSet<tblAcetateSub>();
        }

        [Key]
        public int FAcetateSizeID { get; set; }

        public short FLength { get; set; }

        public short FWidth { get; set; }

        public byte FRim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetateCat> tblAcetateCats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAcetateSub> tblAcetateSubs { get; set; }
    }
}
