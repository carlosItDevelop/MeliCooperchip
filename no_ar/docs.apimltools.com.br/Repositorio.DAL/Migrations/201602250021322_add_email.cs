namespace Repositorio.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_email : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "email", c => c.String(maxLength: 120, unicode: false));
            AddColumn("dbo.Clientes", "Descricao", c => c.String(maxLength: 4000));
            DropColumn("dbo.Clientes", "DescricaoServico");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "DescricaoServico", c => c.String(maxLength: 120, unicode: false));
            DropColumn("dbo.Clientes", "Descricao");
            DropColumn("dbo.Clientes", "email");
        }
    }
}
