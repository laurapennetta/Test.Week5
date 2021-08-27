using Microsoft.EntityFrameworkCore;
using Risto.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Risto.EF
{
    public class RistoEF : IRistoRepository
    {
        private readonly RistoContext ctx;

        public RistoEF(RistoContext context)
        {
            this.ctx = context;
        }
        public bool AddItem(Piatto newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentNullException("Invalid item");
            }
            try
            {
                ctx.Piatti.Add(newItem);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid Id");
            }
            try
            {
                var itemToDelete = GetById(id);
                if (itemToDelete != null)
                {
                    ctx.Piatti.Remove(itemToDelete);
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditItem(Piatto itemToEdit)
        {
            if (itemToEdit == null)
            {
                throw new ArgumentNullException("Invalid item");
            }
            try
            {
                ctx.Entry(itemToEdit).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Piatto> FetchAll()
        {
            try
            {
                return ctx.Piatti.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Piatto GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("invalid id");
            }
            try
            {
                return ctx.Piatti.FirstOrDefault(x => x.ID == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
