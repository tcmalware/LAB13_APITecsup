namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class tablaProductos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Descripcion = c.String(),
                    PrecioVenta = c.Double(nullable: false),
                    FechaCreacion = c.DateTime(nullable: false),
                    FechaVencimiento = c.DateTime(nullable: false),
                    EstaActivo = c.Boolean(nullable: false),
                    IGV = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.Productoes");
        }
    }
}
