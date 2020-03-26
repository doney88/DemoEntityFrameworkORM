namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComponentSelfSealingBagSub")]
    public partial class tblComponentSelfSealingBagSub
    {
        [Key]
        public int FBagSubID { get; set; }

        public int FComponentSubID { get; set; }

        public byte FThick { get; set; }
    }
}
