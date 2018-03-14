namespace PaseandoAp.Backend.Models
{
    using PaseandoAp.Domain;

    public class DataContextLocal : DataContext
    {
        public System.Data.Entity.DbSet<PaseandoAp.Domain.Category> Categories { get; set; }
    }
}