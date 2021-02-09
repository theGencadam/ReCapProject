using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;

using System;

namespace ConsoleI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                if (car.Description.Length>1 && car.DailyPrice>0)
                {
                    Console.WriteLine(car.DailyPrice);
                   
                }
            }
            Console.WriteLine("................");

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("................");

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }
    }
}
