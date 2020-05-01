namespace DemoEntityFrameworkORM.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tblCat2> tblCat2 { get; set; }
        public virtual DbSet<tblEnterprise> tblEnterprises { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCat2>()
                .Property(e => e.FCat2Code)
                .IsFixedLength();

            modelBuilder.Entity<tblCat2>()
                .HasMany(e => e.tblEnterprises)
                .WithRequired(e => e.tblCat2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEnterprise>()
                .Property(e => e.FWebsite)
                .IsUnicode(false);

            modelBuilder.Entity<tblEnterprise>()
                .Property(e => e.FVATPercent)
                .HasPrecision(5, 4);

            modelBuilder.Entity<tblEnterprise>()
                .HasMany(e => e.tblEnterprise1)
                .WithOptional(e => e.tblEnterprise2)
                .HasForeignKey(e => e.FParentID);

            modelBuilder.Entity<tblEnterprise>()
                .HasMany(e => e.tblOrders)
                .WithRequired(e => e.tblEnterprise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FShipAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FCostAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrder>()
                .Property(e => e.FAmountBalance)
                .HasPrecision(19, 4);
        }
    }
}
