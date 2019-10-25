using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
    public class BillsService : IBillsService
    {
        IBillsRepository _billsRepository;
        public BillsService(IBillsRepository billsRepository)
        {
            _billsRepository = billsRepository;
        }

        public IList<Bills> BillGetAll()
        {
            return _billsRepository.BillGetAll();
        }

        public IList<Bills> BillIsNotPayment()
        {
            return _billsRepository.BillIsNotPayment();
        }

        public IList<Bills> BillIsPayment()
        {
            return _billsRepository.BillIsPayment();
        }

        public int BillsAdd(BillsAdd billsAdd)
        {
            return _billsRepository.BillsAdd(billsAdd);
        }

        public Bills BillsGetByID(int Id)
        {
            return _billsRepository.BillsGetByID(Id);
        }

        public Bills BillsGetByIdTable(int Id)
        {
            return _billsRepository.BillsGetByIdTable(Id);
        }
    }
}
