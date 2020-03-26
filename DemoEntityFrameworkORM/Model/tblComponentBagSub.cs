namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentBagSub")]
    public partial class tblComponentBagSub
    {
        [Key]
        public int FBagSubID { get; set; }

        public int FComponentSubID { get; set; }

        public byte FThick { get; set; }
    }
}
