using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Phone
    {
        public string PhoneSize { get; set; }
        public string PhoneBrand { get; set; }
        public string PhoneModel { get; set; }
        
        public void Call()
        {
            Console.WriteLine("Telefons zvana");
        }
        public void SMS()
        {
            Console.WriteLine("Suta SMS");
        }

    }
}
