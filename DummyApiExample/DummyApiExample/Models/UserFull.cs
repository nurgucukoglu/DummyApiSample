using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyApiExample.Models
{
    public class UserFull
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string RegisterDate { get; set; }
        public string Phone { get; set; }
        public Location Location { get; set; }
        public string Picture { get; set; }
        
    }
}