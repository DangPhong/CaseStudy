using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLCafe.BAL.Interface;
using QLCafe.Domain.Requets;
using QLCafe.Domain.Response;

namespace QLCafe.API.Controllers
{
    
    [ApiController]
    public class TableCoffeesController : ControllerBase
    {
        ITableCoffeesService _tableCoffeesService;
        public TableCoffeesController(ITableCoffeesService tableCoffeesService)
        {
            _tableCoffeesService = tableCoffeesService;
        }

        [HttpGet]
        [Route("api/TableCoffees/getall")]
        public IList<TableCoffees> TableCoffeesGetAll()
        {
            return _tableCoffeesService.TableCoffeesGetAll();
        }

        [HttpGet]
        [Route("api/TableCoffees/get/{id}")]
        public TableCoffees TableCoffeesGetByID(int Id)
        {
            return _tableCoffeesService.TableCoffeesGetByID(Id);
        }
        [HttpGet]
        [Route("api/TableCoffees/detail/{id}")]
        public TableCoffeesDetail TableCoffeesDetail(int Id)
        {
            return _tableCoffeesService.TableCoffeesDetail(Id);
        }

        [HttpPost]
        [Route("api/TableCoffees/add")]
        public bool TableCoffeesAdd([FromBody] TableCoffeesAdd Requets)
        {
            return _tableCoffeesService.TableCoffeesAdd(Requets);
        }

        [HttpPut]
        [Route("api/TableCoffees/update")]
        public bool TableCoffeesUpdate([FromBody] TableCoffeesUpdate Requets)
        {
            return _tableCoffeesService.TableCoffeesUpdate(Requets);
        }


        [HttpPost]
        [Route("api/TableCoffees/addbyid")]
        public bool TableCoffeesAddByID(TableCoffeesAddByID Requets)                     
        {
            return _tableCoffeesService.TableCoffeesAddByID(Requets);
        }

        [HttpDelete]
        [Route("api/TableCoffees/delete/{id}")]
        public bool TableCoffeesDelete(int Id)
        {
            return _tableCoffeesService.TableCoffeesDelete(Id);
        }

        [HttpGet]
        [Route("api/TableCoffees/getbookedatable")]
        public IList<TableCoffees> TableCoffeesGetBookedATable()
        {
            return _tableCoffeesService.TableCoffeesGetBookedATable();
        }

        [HttpGet]
        [Route("api/TableCoffees/getbyidarea/{id}")]
        public IList<TableCoffees> TableCoffeesGetByIdArea(int Id)
        {
            return _tableCoffeesService.TableCoffeesGetByIdArea(Id);
        }

        [HttpGet]
        [Route("api/TableCoffees/getemptytable")]
        public IList<TableCoffees> TableCoffeesGetEmptyTable()
        {
            return _tableCoffeesService.TableCoffeesGetEmptyTable();
        }

        [HttpGet]
        [Route("api/TableCoffees/getnotemtytable")]
        public IList<TableCoffees> TableCoffeesGetNotEmptyTable()
        {
            return _tableCoffeesService.TableCoffeesGetNotEmptyTable();
        }

        [HttpPut]
        [Route("api/TableCoffees/tobook/{id}")]
        public bool TableCoffeesTobook(int Id)
        {
            return _tableCoffeesService.TableCoffeesTobook(Id);
        }

        [HttpPut]
        [Route("api/TableCoffees/tocanbook/{id}")]
        public bool TableCoffeesToCanBook(int Id)
        {
            return _tableCoffeesService.TableCoffeesToCanBook(Id);
        }
    }
}