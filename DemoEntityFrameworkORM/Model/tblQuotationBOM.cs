namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblQuotationBOM")]
    public partial class tblQuotationBOM
    {
        [Key]
        public int FQBOMID { get; set; }

        public int? FQuotationListID { get; set; }

        public int? FMaterialID { get; set; }

        public int? FSupplierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FWeight { get; set; }

        public float? FScrapRate { get; set; }

        [StringLength(255)]
        public string FNote { get; set; }

        [StringLength(255)]
        public string FCostName { get; set; }

        public bool FVAT { get; set; }

        public int? FProcessBOMSubID { get; set; }

        [Column(TypeName = "money")]
        public decimal? FPrice { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public float? FCost { get; set; }

        [StringLength(10)]
        public string FCat3 { get; set; }

        [StringLength(5)]
        public string FUnit { get; set; }

        public virtual tblMaterial tblMaterial { get; set; }

        public virtual tblProcessBomSub tblProcessBomSub { get; set; }

        public virtual tblSupplier tblSupplier { get; set; }

        public virtual tblQuotationList tblQuotationList { get; set; }
    }
}
