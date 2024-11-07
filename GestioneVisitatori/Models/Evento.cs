using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVisitatori.Models
{
    internal class Evento
    {
        public int IdEvento { get; set; }
        public List<TipiBigliettoEvento> BigliettiEvento { get; set; }
        public string TitoloEvento { get; set; }
        public int IdTipo { get; set; }
        public string DescrizioneEvento { get; set; }
        public string OrganizzatoreEvento { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public int IdStanza { get; set; }
        public string ImmagineEvento { get; set; }
    }
}
