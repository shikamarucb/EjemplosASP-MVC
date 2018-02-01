namespace Introduccion_a_Entity_Framework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Introduccion_a_Entity_Framework.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Introduccion_a_Entity_Framework.Models.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Comentarios.AddOrUpdate(x => x.Id, new Models.Comentario()
            {
                Id = 1,
                Autor = "Pablo",
                BlogPostId = 1,
                Contenido = "Ejemplo de Contenido"
            });
        }
    }
}
