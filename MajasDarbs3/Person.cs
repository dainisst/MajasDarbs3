using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool IsMale { get; set; }
        public int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

       


    }
}
