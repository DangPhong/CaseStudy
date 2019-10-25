using QLCafe.BAL.Interface;
using QLCafe.DAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.BAL
{
    public class TableCoffeesService : ITableCoffeesService
    {
        ITableCoffeesRepository _tableCoffeesRepository;
        public TableCoffeesService(ITableCoffeesRepository tableCoffeesRepository)
        {
            _tableCoffeesRepository = tableCoffeesRepository;
        }

        public bool TableCoffeesAdd(TableCoffeesAdd Requets)
        {
            return _tableCoffeesRepository.TableCoffeesAdd(Requets);
        }

        public bool TableCoffeesAddByID(TableCoffeesAddByID Requets)
        {
            return _tableCoffeesRepository.TableCoffeesAddByID(Requets);
        }

        public bool TableCoffeesDelete(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesDelete(Id);
        }

        public TableCoffeesDetail TableCoffeesDetail(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesDetail(Id);
        }

        public IList<TableCoffees> TableCoffeesGetAll()
        {
            return _tableCoffeesRepository.TableCoffeesGetAll();
        }

        public IList<TableCoffees> TableCoffeesGetBookedATable()
        {
            return _tableCoffeesRepository.TableCoffeesGetBookedATable();
        }

        public TableCoffees TableCoffeesGetByID(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesGetByID(Id);
        }

        public IList<TableCoffees> TableCoffeesGetByIdArea(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesGetByIdArea(Id);
        }

        public IList<TableCoffees> TableCoffeesGetEmptyTable()
        {
            return _tableCoffeesRepository.TableCoffeesGetEmptyTable();
        }

        public IList<TableCoffees> TableCoffeesGetNotEmptyTable()
        {
            return _tableCoffeesRepository.TableCoffeesGetNotEmptyTable();
        }

        public bool TableCoffeesTobook(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesTobook(Id);
        }

        public bool TableCoffeesToCanBook(int Id)
        {
            return _tableCoffeesRepository.TableCoffeesToCanBook(Id);
        }

        public bool TableCoffeesUpdate(TableCoffeesUpdate Requets)
        {
            return _tableCoffeesRepository.TableCoffeesUpdate(Requets);
        }
    }
}
