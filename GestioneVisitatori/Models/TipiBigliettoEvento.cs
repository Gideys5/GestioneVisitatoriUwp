using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneVisitatori.Models
{
    internal class TipiBigliettoEvento
    {
        public int IdTipiBigliettoEvento { get; set; }
        public List<object> Biglietti { get; set; }
        public decimal Costo { get; set; }
        public int DurataGiorni { get; set; }
        public string DescrizioneTipoBiglietto { get; set; }
        public List<object> CarrelliConBiglietto { get; set; }
    }
}
