using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esame.Data
{
    /// <summary> Rappresenta il rapporto tra un oggetto Portata e un oggetto Allergene. </summary>
    public class PortataAllergene
    {
        public int Id { get; set; }

        public int IdPortata { get; set; }

        public int IdAllergene { get; set; }
    }
}
