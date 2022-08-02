using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyApiExample.Models
{
    public class UserList
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public ICollection<UserPreview> Data { get; set; }


        /*data: Array(Model)
        total: number(total items in DB)
        page: number(current page)
        limit: number(number of items on page)*/
    }
}