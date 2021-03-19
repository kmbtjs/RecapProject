using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Add(new Car { 
                Id = 1, 
                BrandId = 1, 
                ColorId = 2, 
                DailyPrice = 150, 
                Description = "Aile Arabası", 
                ModelYear= 2009, 
                Name="Audi" 
            });
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
