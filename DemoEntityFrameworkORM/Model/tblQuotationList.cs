namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuotationList")]
    public partial class tblQuotationList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblQuotationList()
        {
            tblQuotationBases = new HashSet<tblQuotationBase>();
            tblQuotationBOMs = new HashSet<tblQuotationBOM>();
            tblQuotationProcesses = new HashSet<tblQuotationProcess>();
        }

        [Key]
        public int FQuotationListID { get; set; }

        public int FQuotationID { get; set; }

        public int? FMaterialID { get; set; }

        [StringLength(50)]
        public string FModelCust { get; set; }

        [StringLength(50)]
        public string FColorCust { get; set; }

        public int FQty { get; set; }

        [Column(TypeName = "money")]
        public decimal FMaterialCost { get; set; }

        [Column(TypeName = "money")]
        public decimal FMaterialCostVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? FProcessCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? FOverHeadCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? FMargin { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPriceConfirm { get; set; }

        public bool FVAT { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FCostSum { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FPriceRef { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FTax { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? FPriceVATRef { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationBase> tblQuotationBases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationBOM> tblQuotationBOMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQuotationProcess> tblQuotationProcesses { get; set; }
    }
}
