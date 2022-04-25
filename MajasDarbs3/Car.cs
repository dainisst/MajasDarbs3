using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Car
    {
        public string CarBrand { get; set; }
        public string CarPlate { get; set; }
        public int CarSpeed { get; set; }

        public void CarStart()
        {
            CarSpeed = 10;
            Console.WriteLine("Auto sak braukt");
        }
        public int CarSpeedUp()
        {
            CarSpeed += 20;
            Console.WriteLine($"Auto uzņem atrumu {CarSpeed}");
            return CarSpeed;
        }
        public int CarSlowDown()
        {
            CarSpeed -= 20;
            Console.WriteLine($"Auto samazina atrumu {CarSpeed}");
            return CarSpeed;
        }
        public void CarStops()
        {
            CarSpeed = 0;
            Console.WriteLine("Auto ir apstajies");
        }
        public void CarBeeps()
        {
            Console.WriteLine("Beep Beep");
        }

    }
}
