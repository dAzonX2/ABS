using System;
using System.Collections.Generic;
using System.Text;

namespace abs
{
    public class User
    {
        public string Family { get; set; }
        public string F_Name { get; set; }
        public string S_Name { get; set; }
        
    }

    class Librarian : User 
    {
        public string Password { get; set; }
        public void CheckLibrarian()
        {

        }
    }
    class Reader : User
    {
        public int Id { get; set; }
        public string LibCardDate { get; set; }
        public string LibCardLim { get; set; }

        public void CheckReader()
        {

        }
        public void AddReader()
        {

        }
    }
}
