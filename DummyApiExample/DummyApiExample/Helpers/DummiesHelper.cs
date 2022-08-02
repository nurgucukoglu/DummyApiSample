using DummyApiExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DummyApiExample.Helpers
    //UserList.i okumak için. user, appId... bağlanır.
{
    public static class DummiesHelper
    {
        private static string base_URL = "https://dummyapi.io/data/v1/";
        private static string user_url = "user";
        private static string appId = "62837d4bda4d6f2483d54a34";
    
        public static UserList GetUserList(int current_limit=12, int current_page=1)
        {
            UserList list= new UserList();
            HttpResponseMessage response = GetResponse(user_url);
            if(response.IsSuccessStatusCode)
            {
                string responseTxt = response.Content.ReadAsStringAsync().Result;
                //JsonConvert: NewtonSoft kütüphanesinden gelir.
                list = JsonConvert.DeserializeObject<UserList>(responseTxt);


            }
            return list;
        }

        public static UserFull GetUserFull(string id)
        {
            UserFull user= new UserFull();
            HttpResponseMessage response = GetResponse(user_url + "/" + id);
            if(response.IsSuccessStatusCode)
            {
                string responseTxt = response.Content.ReadAsStringAsync().Result;
                //JsonConvert : NewtonSoft kütüphanesinden geliyor.
                user= JsonConvert.DeserializeObject<UserFull>(responseTxt);
            }
            return user;
        }

        private static HttpResponseMessage GetResponse(string endPoint)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("app-id", appId);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri(base_URL);
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + endPoint).Result;
            return response;
           

        }

       
    }
}