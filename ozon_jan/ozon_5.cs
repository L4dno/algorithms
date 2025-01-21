using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_5
    {
        public struct Car
        {
            public Car(int st, int en, int cap)
            {
                start = st;
                end = en;
                capacity = cap;
            }
            public int start;
            public int end;
            public int capacity;
        }
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                var products = new (int,int)[n]; // time and pos

                string[] tmp = input.ReadLine().Split();
                for (int i = 0; i < n; ++i)
                {
                    products[i] = (int.Parse(tmp[i]), i);
                }

                int m = int.Parse(input.ReadLine());

                var cars = new Car[m];
                for (int i = 0;i<m; ++i)
                {
                    tmp = input.ReadLine().Split();
                    cars[i] = new Car(int.Parse(tmp[0]), 
                                    int.Parse(tmp[1]), int.Parse(tmp[2]));
                }
                cars = cars.OrderBy(car => car.start).ToArray();

                var prodToCar = new int[n];
                int indCar = 0;
                foreach (var prod in products)
                {
                    while (indCar < m && (cars[indCar].capacity == 0 ||
                                            cars[indCar].end < prod.Item1))
                    {
                        indCar++;
                    }
                    // cant deliever this product
                    if (indCar == m)
                    {
                        prodToCar[prod.Item2] = -1;
                    }
                    else
                    {
                        prodToCar[prod.Item2] = indCar;
                    }
                }
            }
        }
    }
}
