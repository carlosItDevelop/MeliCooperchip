namespace Repositorio.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_cliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 120, unicode: false),
                        CpfCnpj = c.String(maxLength: 120, unicode: false),
                        Endereco = c.String(maxLength: 120, unicode: false),
                        Telefones = c.String(maxLength: 120, unicode: false),
                        DDD = c.String(maxLength: 120, unicode: false),
                        Estado = c.String(maxLength: 120, unicode: false),
                        Bairro = c.String(maxLength: 120, unicode: false),
                        DescricaoServico = c.String(maxLength: 120, unicode: false),
                        TecnologiaRequerida = c.String(maxLength: 120, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
