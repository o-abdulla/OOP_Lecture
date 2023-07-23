using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture
{
    internal class Cars
    {
        //properties
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }

        //constructor
        public Cars(string  _color, string _brand, string _size)
        {
            Color = _color;
            Brand = _brand;
            Size = _size;
        }

        //method
        public void DriveFast()
        {
            Console.WriteLine($"A very fast {Color} {Brand} wizzed by me");
        }

        public void SpeedLimit()
        {
            Console.WriteLine("The other cars were going the speed limit");
        }
    }
}
