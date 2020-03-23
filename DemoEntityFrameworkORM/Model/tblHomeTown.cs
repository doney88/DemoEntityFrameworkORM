namespace DemoEntityFrameworkORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHomeTown")]
    public partial class tblHomeTown
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FHomeTownID { get; set; }

        [Required]
        [StringLength(50)]
        public string FHomeTown { get; set; }
    }
}
