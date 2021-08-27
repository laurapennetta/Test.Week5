using System;
using System.Collections.Generic;
using System.Text;

namespace Risto.Core
{
    public interface IBusinessLayer
    {
        IEnumerable<Piatto> FetchPiatti();
        Piatto GetPiattoById(int id);
        PiattoResult AddNewPiatto (Piatto newPiatto);
        PiattoResult EditPiatto(Piatto data);
        PiattoResult DeletePiatto(Piatto data);
        Account GetAccount(string username);
    }
}
