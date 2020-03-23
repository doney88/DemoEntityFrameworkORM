namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblClaimSub")]
    public partial class tblClaimSub
    {
        [Key]
        public int FClaimItemID { get; set; }

        public int FClaimID { get; set; }

        [Required]
        [StringLength(255)]
        public string FItem { get; set; }

        [Column(TypeName = "money")]
        public decimal FAmount { get; set; }

        public virtual tblClaim tblClaim { get; set; }
    }
}
