namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPackingTemplateSub")]
    public partial class tblPackingTemplateSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPackingTemplateSub()
        {
            tblOrderSubBOMPackings = new HashSet<tblOrderSubBOMPacking>();
            tblPackingTemplateSub1 = new HashSet<tblPackingTemplateSub>();
        }

        [Key]
        public int FPackingTemplateSubID { get; set; }

        public int FPackingTemplateID { get; set; }

        public byte FSortID { get; set; }

        public int FMaterialID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQtyPer { get; set; }

        public int? FPackingMixTypeID { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        public int? FPackingTempalteSubIDLink { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderSubBOMPacking> tblOrderSubBOMPackings { get; set; }

        public virtual tblPackingMixType tblPackingMixType { get; set; }

        public virtual tblPackingTemplate tblPackingTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackingTemplateSub> tblPackingTemplateSub1 { get; set; }

        public virtual tblPackingTemplateSub tblPackingTemplateSub2 { get; set; }
    }
}
