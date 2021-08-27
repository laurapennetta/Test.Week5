using System;
using System.Collections.Generic;
using System.Text;

namespace Risto.Core
{
    public enum Ruolo
    {
        Ristoratore,
        Cliente
    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Ruolo Ruolo { get; set; }
    }
}
