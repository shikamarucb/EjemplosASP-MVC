using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Introduccion_a_Entity_Framework.Models
{
    //Una clase heredada de "DbContext"Es una clase que se encarga de indicarle a Entity 
    //Framework cuales son los modelos con los cuales queremos hacer queries
    public class BlogContext: DbContext
    {
        //Al constructor base se le envia como parametro el connectionString
        public BlogContext()
            :base("DefaultConnection")
        {

        }
        //Lo que se ponga aca se le puede hacer queries
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }


    }
}