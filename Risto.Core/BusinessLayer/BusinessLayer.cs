using System;
using System.Collections.Generic;
using System.Text;

namespace Risto.Core
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IRistoRepository ristoRepository;
        private readonly IAccountRepository accRepository;

        public BusinessLayer(IRistoRepository ristoRepo, IAccountRepository accRepository)
        {
            this.ristoRepository = ristoRepo;
            this.accRepository = accRepository;
        }

        public PiattoResult AddNewPiatto(Piatto newPiatto)
        {
            if (newPiatto == null)
            {
                throw new ArgumentNullException("Invalid item");
            }

            var result = ristoRepository.AddItem(newPiatto);

            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = "Ok"
                };
            }
            return new PiattoResult
            {
                Success = false,
                Message = $"Il piatto {newPiatto.Nome} cannot be saved"
            };
        }

        public PiattoResult DeletePiatto(Piatto data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Invalid data");
            }
            var result = ristoRepository.Delete(data.ID);
            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = ""
                };
            }
            return new PiattoResult
            {
                Success = false,
                Message = "Cannot delete"
            };
        }

        public PiattoResult EditPiatto(Piatto data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Invalid info");
            }

            var result = ristoRepository.EditItem(data);
            if (result)
            {
                return new PiattoResult
                {
                    Success = true,
                    Message = ""
                };
            }

            return new PiattoResult
            {
                Success = false,
                Message = "Cannot to edit"
            };
        }

        public IEnumerable<Piatto> FetchPiatti()
        {
            return ristoRepository.FetchAll();
        }

        public Account GetAccount(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            return accRepository.GetByUsername(username);
        }

        public Piatto GetPiattoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return ristoRepository.GetById(id);
        }
    }
}
