using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Esame.Data
{
    /// <summary> 
    /// Rappresenta il databese delle portate.
    /// Interfacciandosi al database, recupera le liste di oggetti Portata, Allergene, Tipo, Stagione e PortataAllergene.
    /// </summary>
    public class DbPortate : DbContext
    {
        public DbSet<Portata> Portate { get; set; }

        public DbSet<Allergene> Allergeni { get; set; }

        public DbSet<Tipo> Tipi { get; set; }

        public DbSet<Stagione> Stagioni { get; set; }

        public DbSet<PortataAllergene> PortateAllergeni { get; set; }

        public DbPortate(DbContextOptions options) : base(options) { }

    }
}
