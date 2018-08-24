namespace Funcionarios.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contato",
                c => new
                    {
                        con_id = c.Int(nullable: false, identity: true),
                        celular = c.String(maxLength: 15),
                        telefone = c.String(maxLength: 15),
                        per_dataFim = c.DateTime(),
                        per_dataInicio = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.con_id);
            
            CreateTable(
                "dbo.pessoa",
                c => new
                    {
                        pes_id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 200),
                        enderecos = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.pes_id);
            
            CreateTable(
                "dbo.pessoa_contatos",
                c => new
                    {
                        Pessoa_Id = c.Int(nullable: false),
                        Contato_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pessoa_Id, t.Contato_Id })
                .ForeignKey("dbo.pessoa", t => t.Pessoa_Id, cascadeDelete: true)
                .ForeignKey("dbo.contato", t => t.Contato_Id, cascadeDelete: true)
                .Index(t => t.Pessoa_Id)
                .Index(t => t.Contato_Id);
            
            CreateTable(
                "dbo.pessoafisica",
                c => new
                    {
                        pes_id = c.Int(nullable: false),
                        cpf = c.String(maxLength: 11),
                        dataNascimento = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        idade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.pes_id)
                .ForeignKey("dbo.pessoa", t => t.pes_id)
                .Index(t => t.pes_id);
            
            CreateTable(
                "dbo.funcionario",
                c => new
                    {
                        pes_id = c.Int(nullable: false),
                        dataContratacao = c.DateTime(nullable: false),
                        salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.pes_id)
                .ForeignKey("dbo.pessoafisica", t => t.pes_id)
                .Index(t => t.pes_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.funcionario", "pes_id", "dbo.pessoafisica");
            DropForeignKey("dbo.pessoafisica", "pes_id", "dbo.pessoa");
            DropForeignKey("dbo.pessoa_contatos", "Contato_Id", "dbo.contato");
            DropForeignKey("dbo.pessoa_contatos", "Pessoa_Id", "dbo.pessoa");
            DropIndex("dbo.funcionario", new[] { "pes_id" });
            DropIndex("dbo.pessoafisica", new[] { "pes_id" });
            DropIndex("dbo.pessoa_contatos", new[] { "Contato_Id" });
            DropIndex("dbo.pessoa_contatos", new[] { "Pessoa_Id" });
            DropTable("dbo.funcionario");
            DropTable("dbo.pessoafisica");
            DropTable("dbo.pessoa_contatos");
            DropTable("dbo.pessoa");
            DropTable("dbo.contato");
        }
    }
}
