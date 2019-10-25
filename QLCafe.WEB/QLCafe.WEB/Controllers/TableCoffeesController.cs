using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.WEB.Models;
using QLCafe.WEB.Models.Bills;
using QLCafe.WEB.Models.TableCoffees;

namespace QLCafe.WEB.Controllers
{
    public class TableCoffeesController : Controller
    {
        private static int tableCoffeeId = 0;

        #region Hiển Thị Tất Cả bàn
        public IActionResult Index()
        {
            var tableCoffees = new List<TableCoffeesView>();
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

                tableCoffees = JsonConvert.DeserializeObject<List<TableCoffeesView>>(responseData);
            }
            return View(tableCoffees);
        }
        #endregion

        #region Tạo Bàn Mới
        public IActionResult Create()
        {
            TempData["Success"] = null;
            ViewBag.Areas = ListArea();
            return View();
        }

        [HttpPost]
        public IActionResult Create(TableCoffeesCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/add");
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
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["messenger"] = "Đã tạo bàn thành công";
            }
            ViewBag.Areas = ListArea();
            ModelState.Clear();
            return RedirectToAction("Index");
        }
        #endregion

        #region XÓa Bàn
        public IActionResult Delete(int id)
        {
            //var model = new TableCoffeesDelete()
            //{
            //    ID = id
            //};
            //id = tableCoffeeId;
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/delete/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(id);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "TableCoffees");
        }
        #endregion

        #region Chi tiết bàn
        public IActionResult Details(int id)
        {
            tableCoffeeId = id;
            var tableCoffees = new TableCoffeesDetail();
            var url = "https://localhost:44354/api/TableCoffees/detail/" + id;
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

                tableCoffees = JsonConvert.DeserializeObject<TableCoffeesDetail>(responseData);
            }
            ViewBag.NameTable = ListTableCoffee().Where(t => t.ID == id).FirstOrDefault().Name;
            return View(tableCoffees);
        }
        #endregion

        #region Update Bàn(Chưa sử dụng)
        public IActionResult Edit(int id)
        {
            var tableCoffeesEdit = new TableCoffeesEdit();
            var url = "https://localhost:44354/api/TableCoffees/get/" + id;
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

                tableCoffeesEdit = JsonConvert.DeserializeObject<TableCoffeesEdit>(responseData);
            }

            return View(tableCoffeesEdit);
        }

        [HttpPost]
        public IActionResult Edit(TableCoffeesEdit model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Message"] = "User has been update successfully";
            }
            return View(new TableCoffeesEdit() { });
        }
        #endregion

        #region Lấy Danh Sách Bàn Trống
        public IActionResult GetEmptyTable()
        {
            var getEmptyTable = new List<TableCoffeesGetEmptyTable>();
            var url = "https://localhost:44354/api/TableCoffees/getemptytable";
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

                getEmptyTable = JsonConvert.DeserializeObject<List<TableCoffeesGetEmptyTable>>(responseData);
            }
            return View(getEmptyTable);
        }
        #endregion

        #region Lấy Danh sách Bàn Có Khách
        public IActionResult GetNotEmptyTable()
        {
            var getNotEmptyTable = new List<TableCoffeesGetNotEmptyTable>();
            var url = "https://localhost:44354/api/TableCoffees/getnotemtytable";
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

                getNotEmptyTable = JsonConvert.DeserializeObject<List<TableCoffeesGetNotEmptyTable>>(responseData);
            }
            return View(getNotEmptyTable);
        }
        #endregion

        #region List Area cho viewbag
        private List<AreaView> ListArea()
        {
            var areas = new List<AreaView>();
            var url = "https://localhost:44354/api/area/gets";
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
                    ((IDisposable)responseStream).Dispose();
                }
                areas = JsonConvert.DeserializeObject<List<AreaView>>(responseData);
            }
            return areas;
        }
        #endregion

        #region Đặt Bàn
        [HttpGet]
        public IActionResult TableCoffeesToBook(int Id)
        {
            Id = tableCoffeeId;
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/tobook/" + Id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(Id);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Message"] = "User has been update successfully";
            }
            return RedirectToAction("Index", "TableCoffees");
        }
        #endregion

        #region Hủy Đặt Bàn
        [HttpGet]
        public IActionResult TableCoffeesToCanBook(int Id)
        {
            Id = tableCoffeeId;
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/ToCanBook/" + Id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(Id);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Message"] = "User has been update successfully";
            }
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