using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenVlodgi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin = "0 0 0";
            double[] originParts = origin.Split(' ').Select(s => double.Parse(s)).ToArray();
            List<string> origins = new List<string> { origin };
            for (int i = 0; i < 3; i++)
                
                for (int j = -1; j <= 1; j += 2)
                    origins.Add(string.Format("{0} {1} {2}",
                        originParts[0] + (i == 0 ? j : 0),
                        originParts[1] + (i == 1 ? j : 0),
                        originParts[2] + (i == 2 ? j : 0)));

            foreach (string point in origins)
            {
                Console.WriteLine(point);
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("The End");
            Console.ReadLine();
        }
    }
}
