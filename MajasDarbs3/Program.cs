using System;

namespace MajasDarbs3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            phone1.PhoneBrand = "Nokia";
            phone1.PhoneModel = "NK 8000";
            phone1.PhoneSize = "45 * 80 * 200";

            Console.WriteLine($"Mans pirmais telefons bija {phone1.PhoneBrand}, izmērs tam bija {phone1.PhoneSize}");
            phone1.Call();
            phone1.SMS();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            Car car1 = new Car();
            car1.CarBrand = "Audi";
            car1.CarPlate = "FE-8798";
            car1.CarSpeed = 50;

            Console.WriteLine($"Mana jaua masina ir {car1.CarBrand}, ar numura zimi {car1.CarPlate}");
            car1.CarStart();
            car1.CarSpeedUp();
            car1.CarSlowDown();
            car1.CarStops();
            car1.CarBeeps();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            Product product1 = new Product(1.2, 34.3, 120);
            Product product2 = new Product(.9, 21.9, 98);

            Console.WriteLine($"Preces 1 garums ir {product1.Length}mm, platums ir {product1.Width}mm un prece sver {product1.Weight}g");
            Console.WriteLine($"Preces 2 garums ir {product2.Length}mm, platums ir {product2.Width}mm un prece sver {product2.Weight}g");

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            Person person1 = new Person();
            Console.WriteLine("Ievadiet savu vardu: ");
            person1.FirstName = Console.ReadLine();
            Console.WriteLine("Ievadiet savu uzvardu: ");
            person1.LastName = Console.ReadLine();
            Console.WriteLine("Ievadiet savu dzimsanas datumu dd.mm.yyyy: ");
            person1.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Noradiet savu hobiju: ");
            person1.Hobby = Console.ReadLine();
            Console.WriteLine("Jūs esat virietis? y/n");
            //person1.IsMale = Convert.ToChar(Console.ReadLine());
            //string pGender;
            //switch (person1.IsMale)
            //{
            //    case 'y': pGender = "virietis";
            //        break;
            //    case 'n': pGender = "sieviete";
            //        break;
            //    default: pGender = "robots";
            //        break;
            //}
            var pGender = Console.ReadLine();
            switch (pGender)
            {
                case "y":
                    person1.IsMale = true;
                    break;
                case "n":
                    person1.IsMale = false;
                    break;
                default:
                    Console.WriteLine("Kļūda!");
                    return;
            }
            Console.WriteLine($"Sveiki, mani sauc {person1.FirstName} {person1.LastName}, man ir {person1.Age()} gadi. Mans hobijs ir {person1.Hobby} un es esmu {(person1.IsMale ? "vīrietis" : "sieviete")}.");
        }

    }
}