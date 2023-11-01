using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Gallery
    {
        public string Name { get; set; }
        public Car[] Cars { get; set; }


        public Car this[int index]
        {
            get
            {
                  return Cars[index];
            }
            set
            {
                if (index < Cars.Length)
                    Cars[index] = value;
            }
            
             
        }

        public bool this[string carName]
        {
            get
            {
                foreach (Car car in Cars)
                {
                    if (car.Name == carName)
                    {
                        return true;
                    }
                }
                return false;
            }

        }


        public void ShowInfo()
        {
            Console.WriteLine($"Cars in {Name}\n");

            foreach (Car car in Cars)
            {
                Console.WriteLine($"Name: {car.Name}\nColour : {car.Colour}\nProducedYear: {car.ProducedYear}");
            }
        }
    }
}
