using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Product
    {
        public Product(double lenght, double width, double weight)
        {
            Length = lenght;
            Width = width;
            Weight = weight;
        }
        public double Length { get; }
        public double Width { get; }
        public double Weight { get; }
    }
}
