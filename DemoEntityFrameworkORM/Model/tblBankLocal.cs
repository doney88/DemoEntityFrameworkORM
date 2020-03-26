namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBankLocal")]
    public partial class tblBankLocal
    {
        [Key]
        public int FBankLocalID { get; set; }

        public int FBankID { get; set; }

        [Required]
        [StringLength(50)]
        public string FBankLocalName { get; set; }

        [StringLength(12)]
        public string FUnionPayCode { get; set; }

        public virtual tblBank tblBank { get; set; }
    }
}
