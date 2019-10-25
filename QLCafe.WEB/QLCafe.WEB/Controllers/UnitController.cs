using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.Web.Models.Unit;

namespace QLCafe.Web.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult UnitIndex()
        {
            var units = GetUnits();
            return View(units);
        }

        public List<UnitView> GetUnits()
        {
            var units = new List<UnitView>();
            var url = "https://localhost:44354/api/unit/gets";
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

                units = JsonConvert.DeserializeObject<List<UnitView>>(responseData);
            }
            return units;
        }
        [HttpGet]
        public IActionResult UnitAdd()
        {
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult UnitAdd(UnitAdd model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/unit/create");
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
                TempData["Success"] = "Unit has been created successfully";
            }
            ModelState.Clear();
            return View(new UnitAdd() { });
        }
        public IActionResult UnitUpdate(int id)
        {
            TempData["Success"] = null;
            var updateunit = new UnitUpdate();
            var url = "https://localhost:44354/api/unit/get/" + id;
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

                updateunit = JsonConvert.DeserializeObject<UnitUpdate>(responseData);
            }
            return View(updateunit);
        }

        [HttpPost]
        public IActionResult UnitUpdate(UnitUpdate model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/unit/update");
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
                TempData["Success"] = "Unit has been update successfully";
            }
            return RedirectToAction("UnitIndex", "Unit");
        }

        public IActionResult UnitDelete(int id)
        {
            var deleteResult = false;
            var url = "https://localhost:44354/api/unit/delete/" + id;
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

                deleteResult = JsonConvert.DeserializeObject<bool>(responseData);
            }
            return RedirectToAction("UnitIndex", "Unit");
        }
        public IActionResult UnitDetails(int id)
        {
            var unit = new UnitView();
            var url = "https://localhost:44354/api/unit/get/" + id;
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

                unit = JsonConvert.DeserializeObject<UnitView>(responseData);
            }
            return View(unit);
        }
       
    }
}