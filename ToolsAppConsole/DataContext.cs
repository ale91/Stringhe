using System.Diagnostics;
using System.Data.Entity;
using System.Collections.Generic;

namespace ToolsAppConsole
{
    class MyDBContext : DbContext
    {
        public DbSet<Turrets> Turrets { get; set; }
        public MyDBContext() : base("name=ToolsConnectionString") //collegamento database prende stringa connessione nell'app.config
        {
            Database.Log = sql => Debug.Write(sql);
        }

        //mappatura tabella
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Config");

            modelBuilder.Entity<Turrets>().ToTable("Turrets");

            modelBuilder.Entity<Turrets>().HasKey(p => new { p.TurretCode });
        }
    }
}
