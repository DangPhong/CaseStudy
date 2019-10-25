using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.Web.Models.Account;

namespace QLCafe.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult AccountIndex()
        {
            var accounts = new List<AccountView>();
            var url = "https://localhost:44354/api/account/gets";
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

                accounts = JsonConvert.DeserializeObject<List<AccountView>>(responseData);
            }

            return View(accounts);
        }
        [HttpGet]
        public IActionResult AccountAdd()
        {
            TempData["Success"] = null;
            return View();
        }
        [HttpPost]
        public IActionResult AccountAdd(AccountAdd model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/account/create");
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
                TempData["Success"] = "Account has been created successfully";
            }
            ModelState.Clear();
            return View(new AccountAdd() { });
        }

        public IActionResult AccountEdit(int id)
        {
            TempData["Success"] = null;
            var updateaccount = new AccountUpdate();
            var url = "https://localhost:44354/api/account/get/" + id;
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

                updateaccount = JsonConvert.DeserializeObject<AccountUpdate>(responseData);

            }
            return View(updateaccount);
        }

        [HttpPost]
        public IActionResult AccountEdit(AccountUpdate model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/account/update");
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
            return RedirectToAction("AccountIndex", "Account");
        }

        public IActionResult AccountDelete(int id)
        {
            var deleteResult = false;
            var url = "https://localhost:44354/api/account/delete/" + id;
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
            return RedirectToAction("AccountIndex", "Account");
        }
        public IActionResult AccountDetails(int id)
        {
            var account = new AccountView();
            var url = "https://localhost:44354/api/account/get/" + id;
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

                account = JsonConvert.DeserializeObject<AccountView>(responseData);
            }
            return View(account);
        }

    }
}