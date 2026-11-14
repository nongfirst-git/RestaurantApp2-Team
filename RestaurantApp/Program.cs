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
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 5.0),
                new Restaurant(5, "Haidilao Hot Pot", "hot pot", 4.7)
            };

            // กรองเฉพาะร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป
            var filteredRestaurants = restaurants.Where(x => x.Rating >= 4.5).ToList();

            foreach (var item in filteredRestaurants)
            {
                Console.WriteLine(
                    $"{item.Id} {item.Name}. ({item.Type}) - Rating: {item.Rating}");
            }

            var amount = filteredRestaurants.Count();
            var avg = filteredRestaurants.Average(x => x.Rating);

            Console.WriteLine($"Total is {amount}");
            Console.WriteLine($"Score Average is {avg}");
            Console.WriteLine("End");
        }
    }

    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
        }
    }
}