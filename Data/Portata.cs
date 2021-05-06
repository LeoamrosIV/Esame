using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Esame.Data
{
    /// <summary> Rappresenta la struttura dati di una portata. </summary>
    public class Portata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Inserire Descrizione")]
        public string Descrizione { get; set; }

        [Required(ErrorMessage = "Inserire Prezzo")]
        public float Prezzo { get; set; }

        [Required(ErrorMessage = "Selezionare il tipo della portata")]
        [Range(1, int.MaxValue, ErrorMessage = "Selezionare il tipo della portata")]
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "Selezionare la stagione di presentazione")]
        [Range(1, int.MaxValue, ErrorMessage = "Selezionare la stagione di presentazione")]
        public int IdStagione { get; set; }
    }
}
