using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.WEB.Models;
namespace QLCafe.WEB.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
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
            return View(areas);
        }

        public IActionResult AreaAdd()
        {
            TempData["ThanhCong"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult AreaAdd(AreaAdd model)
        {
            var result = false;
            var url = "https://localhost:44354/api/area/add";
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
                result = bool.Parse(resResult);
            }
            if (result)
            {
                TempData["ThanhCong"] = "Đã tạo phòng ban thành công";
            }
            // ModelState.Clear();
            return View(new AreaAdd() { });
        }

        public IActionResult AreaDelete(int id)
        {
            var result = false;
            var url = "https://localhost:44354/api/area/delete/" + id;
            // gọi qua đường dẫn tạo 1 request với đường dẫn
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "DELETE";
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
                result = JsonConvert.DeserializeObject<bool>(responseData);
            }
            return RedirectToAction("Index", "Area");
        }

        public IActionResult AreaUpdate(int id)
        {
            var area = new AreaUpdate();
            var url = "https://localhost:44354/api/area/get/" + id;
            // gọi qua đường dẫn tạo 1 request với đường dẫn
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
                area = JsonConvert.DeserializeObject<AreaUpdate>(responseData);
            }
            TempData["ThanhCong"] = null;
            TempData["Loi"] = null;
            return View(area);
        }

        [HttpPost]
        public IActionResult AreaUpdate(AreaUpdate model)
        {
            var result = false;
            var url = "https://localhost:44354/api/area/update";
            // gọi qua đường dẫn tạo 1 request với đường dẫn
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
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
                var resKetQua = streamReader.ReadToEnd();
                result = bool.Parse(resKetQua);
            }
            if (result)
            {
                TempData["ThanhCong"] = "Đã cập nhật phòng ban thành công";
            }
            else
            {
                TempData["Loi"] = "Không thể cập nhật phòng ban";
            }
            return View(new AreaUpdate() { });
        }

    }
}