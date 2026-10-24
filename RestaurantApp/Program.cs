using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
        }
    }class Restaurast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurast (int id, string name, string type, double rating)
        {
            id = id;
            name = name;
            Type = Type;
            Rating = rating;
        }
    }
}
