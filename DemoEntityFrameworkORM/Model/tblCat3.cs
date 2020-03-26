namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCat3
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCat3()
        {
            tblComponentMoulds = new HashSet<tblComponentMould>();
            tblMouldTemplePunchMoulds = new HashSet<tblMouldTemplePunchMould>();
            tblProductSampleBoxes = new HashSet<tblProductSampleBox>();
            tblProcessTemplates = new HashSet<tblProcessTemplate>();
            tblProducts = new HashSet<tblProduct>();
            tblCat3Process = new HashSet<tblCat3Process>();
            tblComponents = new HashSet<tblComponent>();
            tblMaterials = new HashSet<tblMaterial>();
        }

        [Key]
        public int FCat3ID { get; set; }

        public int FCat2ID { get; set; }

        [Required]
        [StringLength(1)]
        public string FCat3Code { get; set; }

        [Required]
        [StringLength(10)]
        public string FCat3 { get; set; }

        [StringLength(50)]
        public string FCat3_EN { get; set; }

        [StringLength(50)]
        public string FFormName { get; set; }

        [StringLength(50)]
        public string FFormSubName { get; set; }

        [StringLength(50)]
        public string FTableName { get; set; }

        [StringLength(50)]
        public string FTableSubName { get; set; }

        [StringLength(25)]
        public string FNumberField { get; set; }

        public byte? FNumberLen { get; set; }

        [StringLength(5)]
        public string FCodeIni { get; set; }

        [StringLength(50)]
        public string FSpecEX { get; set; }

        [StringLength(50)]
        public string FSpecSubEX { get; set; }

        public bool FCancel { get; set; }

        [Required]
        [StringLength(3)]
        public string FUnit { get; set; }

        public int? FDWGParaID { get; set; }

        public int? FFileParaID { get; set; }

        public int? FPicParaID { get; set; }

        public byte? FOrderBy { get; set; }

        public int FMOQ { get; set; }

        public int FBatchQty { get; set; }

        public bool FSet { get; set; }

        public bool FStartingMaterial { get; set; }
        [ForeignKey("FCat2ID")]
        public virtual tblCat2 tblCat2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponentMould> tblComponentMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMouldTemplePunchMould> tblMouldTemplePunchMoulds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProductSampleBox> tblProductSampleBoxes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProcessTemplate> tblProcessTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }

        public virtual tblPara_GetFile tblPara_GetFile { get; set; }

        public virtual tblPara_GetFile tblPara_GetFile1 { get; set; }

        public virtual tblPara_GetFile tblPara_GetFile2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCat3Process> tblCat3Process { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblComponent> tblComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaterial> tblMaterials { get; set; }
    }
}
