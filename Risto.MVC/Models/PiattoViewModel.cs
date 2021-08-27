using Risto.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Risto.MVC.Models
{
    public class PiattoViewModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Nome"), StringLength(50, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required, DisplayName("Descrizione"), StringLength(500)]
        public string Descrizione { get; set; }
        [Required, DisplayName("Tipologia")]
        public Tipologia Tipologia { get; set; }
        [Required, DisplayName("Prezzo"), DataType(DataType.Date)]
        public double Prezzo { get; set; }
    }
}
