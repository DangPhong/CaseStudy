using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.WEB.Models.ProductTypes;

namespace QLCafe.WEB.Controllers
{
    public class ProductTypesController : Controller
    {      
       public IActionResult Index()
        {
            var productTypes = GetProductTypes();
            return View(productTypes);
        }

        public List<ProductTypesView> GetProductTypes()
        {
            var productTypes = new List<ProductTypesView>();
            var url = "https://localhost:44354/api/ProductTypes/gets";
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

                productTypes = JsonConvert.DeserializeObject<List<ProductTypesView>>(responseData);
            }
            return productTypes;
        }

        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductTypesCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/ProductTypes/add");
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
                TempData["Message"] = model.Name + " created successfully";
            }
            ModelState.Clear();
            return View(new ProductTypesCreate() { });
        }

        public IActionResult Delete(int id)
        {
            var model = new ProductTypesDelete()
            {
                Id = id
            };
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/ProductTypes/delete/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "ProductTypes");
        }

        public IActionResult Details(int id)
        {
            var productTypes = new ProductTypesView();
            var url = "https://localhost:44354/api/ProductTypes/get/" + id;
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

                productTypes = JsonConvert.DeserializeObject<ProductTypesView>(responseData);
            }
            return View(productTypes);
        }

        public IActionResult Edit(int id)
        {
            var productTypesEdit = new ProductTypesEdit();
            var url = "https://localhost:44354/api/ProductTypes/get/" + id;
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

                productTypesEdit = JsonConvert.DeserializeObject<ProductTypesEdit>(responseData);
            }

            return View(productTypesEdit);
        }

        [HttpPost]
        public IActionResult Edit(ProductTypesEdit model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/ProductTypes/update");
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
            return View(new ProductTypesEdit() { });
        }
    }
}