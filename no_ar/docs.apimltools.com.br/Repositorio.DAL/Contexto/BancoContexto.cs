using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Repositorio.Entidades;
namespace Repositorio.DAL.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("ConnDB") {}

        public DbSet<Contato> Contato { get; set; }

        public DbSet<Anotacao> Anotacao { get; set; }

        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<ProgramaDeEstudo> ProgramaDeEstudo { get; set; }

        public DbSet<HostProfile> HostProfiles { get; set; }

        public DbSet<Expert> Experts { get; set; }

        public DbSet<TaskList> TaskLists { get; set; }

        public DbSet<Favoritos> Favoritos { get; set; }

        public DbSet<Teste> Teste { get; set; }

        public DbSet<Cliente> Cientes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove(new PluralizingTableNameConvention());

            modelBuilder.Properties()
                .Where(t => t.Name == t.ReflectedType.Name + "Id")
                .Configure(t => t.IsKey());

            modelBuilder.Properties<string>()
                .Configure(t => t.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(t => t.HasMaxLength(120));

            modelBuilder.Properties()
                .Where(t => t.Name == "WebSite")
                .Configure(t => t.HasMaxLength(254));

            modelBuilder.Properties()
                .Where(t => t.Name == "Email")
                .Configure(t => t.HasMaxLength(254));            
            
            modelBuilder.Properties()
                .Where(t => t.Name == "Twitter")
                .Configure(t => t.HasMaxLength(254));            
            
            modelBuilder.Properties()
                .Where(t => t.Name == "Facebook")
                .Configure(t => t.HasMaxLength(254));            
            
            modelBuilder.Properties()
                .Where(t => t.Name == "Linkedin")
                .Configure(t => t.HasMaxLength(254));           

            modelBuilder.Properties()
                .Where(t => t.Name == "Descricao")
                .Configure(t => t.HasColumnType("nvarchar").HasMaxLength(4000));


            

        }
         
    }
}