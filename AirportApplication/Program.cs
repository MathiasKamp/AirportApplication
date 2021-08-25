using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AirportDbEntities ctx = new AirportDbEntities();


            // test example, prints out the route and its properties
            var routes = (from route in ctx.Routes
                select route).ToList();

            foreach (var route in routes)
            {
                Console.WriteLine(route.ToString());
            }

            Console.Read();
        }
    }
}
