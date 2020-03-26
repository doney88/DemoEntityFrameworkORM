namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCompany")]
    public partial class tblCompany
    {
        [Key]
        public int FCompanyID { get; set; }

        [StringLength(50)]
        public string FCompanyName { get; set; }

        [StringLength(255)]
        public string FCompanyNameEn { get; set; }

        [StringLength(20)]
        public string FTelephone { get; set; }

        [StringLength(20)]
        public string FFax { get; set; }

        [StringLength(255)]
        public string FAddress { get; set; }

        [StringLength(255)]
        public string FAddressEn { get; set; }

        [StringLength(50)]
        public string FEmail { get; set; }

        public byte[] FLogo { get; set; }

        [StringLength(50)]
        public string FPrinter { get; set; }

        [StringLength(50)]
        public string FPrinterBill { get; set; }

        [StringLength(255)]
        public string FPort { get; set; }

        [StringLength(255)]
        public string FBankName_EN { get; set; }

        [StringLength(255)]
        public string FBeneficiaryAccount_EN { get; set; }

        [StringLength(255)]
        public string FBeneficiaryAddress_EN { get; set; }

        [StringLength(255)]
        public string FBankAddress_EN { get; set; }

        [StringLength(255)]
        public string FSWIFT_EN { get; set; }

        [StringLength(255)]
        public string FBankCode_EN { get; set; }

        [StringLength(255)]
        public string FBranchCode_EN { get; set; }
    }
}
