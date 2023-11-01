using ConsoleApp3.Models;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery()
            {
                Name = "My Gallery",

                Cars = new Car[]
                {
                   new Car
                   {
                       Name = "Car1",
                       Colour = "Red",
                       ProducedYear = 2020
                   },
                   new Car
                   {
                       Name = "Car2",
                       Colour = "Blue",
                       ProducedYear = 2021
                   }
                }
               
            };
            gallery.ShowInfo();


            string searchName = Console.ReadLine();

            bool carFound = gallery[searchName];

            if (carFound)
            {
                Console.WriteLine(true); ;
            }
            else
            {
                Console.WriteLine(false);
            }


            //Problem Part
            int index = 0;

            Car carAtIndex = gallery[index];

            if(carAtIndex == null)
            {
                Console.WriteLine($"Car at index {index} ->  Name: {carAtIndex.Name}, Colour: {carAtIndex.Colour}, Produced Year: {carAtIndex.ProducedYear} ");
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
    }
}