namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcetateDensity")]
    public partial class tblAcetateDensity
    {
        [Key]
        public int FAcetateDensityID { get; set; }

        public short FLength { get; set; }

        public byte FWidth { get; set; }

        public decimal FThick { get; set; }

        public decimal FWeight { get; set; }
    }
}
