using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.WEB.Models.Bills;

namespace QLCafe.WEB.Controllers
{
    
    public class BillsController : Controller
    {
        private static int tableCoffeeId = 0;
        //private static int billsId = 0;
        #region Lấy Danh sách hóa đơn( chưa dùng)
        public IActionResult Index()
        {
            var bills = new List<Bills>();
            var url = "https://localhost:44354/api/Bills/gets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                bills = JsonConvert.DeserializeObject<List<Bills>>(responseData);
            }
            return View(bills);
        }
        #endregion

        #region LẤY DANH SÁCH HÓA ĐƠN THEO ID BÀN
        public IActionResult GetByIdTable(int Id)
        {

            var bills = new Bills();
            bills.TableID = tableCoffeeId;
            var url = "https://localhost:44354/api/bills/gettable/" + Id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                bills = JsonConvert.DeserializeObject<Bills>(responseData);
            }
            ViewBag.NameTable = ListTableCoffee().Where(t => t.ID == Id).FirstOrDefault().Name;
            return View(bills);
        }

        #endregion

        #region LẤY HÓA ĐƠN THEO ID
        public IActionResult GetById(int Id)
        {

            var bills = new Bills();
            //bills.TableID = tableCoffeeId;
            var url = "https://localhost:44354/api/bills/get/" + Id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                bills = JsonConvert.DeserializeObject<Bills>(responseData);
            }
            ViewBag.NameTable = ListTableCoffee().Where(t => t.ID == tableCoffeeId).FirstOrDefault().Name;
            return View(bills);
        }
        #endregion

        #region TẠO HÓA ĐƠN
        [HttpGet]
        public IActionResult BillsAdd(BillsAdd model, int id)
        {
            tableCoffeeId = id;
            model.TableID = id;
            var result = 0;
            var url = "https://localhost:44354/api/bills/add";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resResult = streamReader.ReadToEnd();
                result = int.Parse(resResult);
            }
            if (result > 0)
            {
                return RedirectToAction("GetById", "Bills", new { Id = result });
            }
            else
                return RedirectToAction("Index", "TableCoffees");
        }
        #endregion

        #region LIST BÀN COFFEE ĐỂ DÙNG VIEW BAG
        private List<TableCoffee> ListTableCoffee()
        {
            var tableCoffees = new List<TableCoffee>();
            var url = "https://localhost:44354/api/TableCoffees/getall";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                tableCoffees = JsonConvert.DeserializeObject<List<TableCoffee>>(responseData);
            }
            return tableCoffees;
        }
        #endregion

    }
}