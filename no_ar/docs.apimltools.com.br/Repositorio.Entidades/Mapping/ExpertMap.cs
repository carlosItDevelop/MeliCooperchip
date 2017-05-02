using System.Data.Entity.ModelConfiguration;

namespace Repositorio.Entidades.Mapping {
    class ExpertMap : EntityTypeConfiguration<Expert>
    {
        public ExpertMap()
        {
            // Primary Key
            this.HasKey(t => t.ExpertId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100)
                .IsRequired();

            //Table & Column Mapping
            ToTable("Experts");
            Property(t => t.ExpertId).HasColumnName("ExpertId");
            Property(t => t.Nome).HasColumnName("Nome");
            Property(t => t.Certificacao).HasColumnName("Certificacao");
            Property(t => t.Datacadastro).HasColumnName("Datacadastro");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Facebook).HasColumnName("Facebook");
            Property(t => t.HoraConsultoria).HasColumnName("HoraConsultoria");
            Property(t => t.Linkedin).HasColumnName("Linkedin");
            Property(t => t.WebSite).HasColumnName("WebSite");
            Property(t => t.Twitter).HasColumnName("Twitter");

        }
    }
}
