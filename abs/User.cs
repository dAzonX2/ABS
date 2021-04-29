using System;
using System.Collections.Generic;
using System.Text;

namespace abs
{
    class User
    {
        public string Family { get; set; }
        public string F_Name { get; set; }
        public string S_Name { get; set; }
        public int ID { get; set; }
    }

    class Librarian : User 
    {
        public string Password { get; set; }
    }
    class Reader : User
    {
        public string LibCardDate { get; set; }
        public string LibCardLim { get; set; }
    }
}
