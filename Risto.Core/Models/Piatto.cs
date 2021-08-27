using System;

namespace Risto.Core
{
    public enum Tipologia
    {
        Primo,
        Secondo,
        Contorno,
        Dolce
    }
    public class Piatto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Tipologia Tipologia { get; set; }
        //public string Tipologia { get; set; }
        public double Prezzo { get; set; }
    }
}
