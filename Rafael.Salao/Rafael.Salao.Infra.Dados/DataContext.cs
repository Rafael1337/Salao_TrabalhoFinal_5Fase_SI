using System.Data.Entity;
using Rafael.Salao.Dominio;

namespace Rafael.Salao.Infra.Dados
{
    public class DataContext : DbContext
    {
        public DataContext() : base("SALAO_DATABASE")
        {
            if (!Database.Exists("SALAO_DATABASE"))
                Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
        }
        public DbSet<Agenda> _agenda { get; set; }
    }
}
