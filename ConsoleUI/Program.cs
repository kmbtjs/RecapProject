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
            ColorManager colorManager1 = new ColorManager(new EfColorDal());
            BrandManager brandManager1 = new BrandManager(new EfBrandDal());
            //CarDetailTest(carManager1);
            //BrandAddTest(brandManager1);
            //BrandUpdateTest(brandManager1);
            //BrandDeleteTest(brandManager1);
            //ColorAddTest(colorManager1);
            //ColorUpdateTest(colorManager1);
            //ColorDeleteTest(colorManager1);
            //AddCarTest(carManager1);
            //UpdateCarTest(carManager1);
            //DeleteCarTest(carManager1);
            //GetCarsByBrandId(carManager1);

        }

        private static void CarDetailTest(CarManager carManager1)
        {
            foreach (var car in carManager1.GetCarDetails())
            {
                Console.WriteLine("Car Name = {0} -- Brand Name = {1} -- Color Name = {2} -- Daily Price = {3}", 
                    car.Description, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void BrandAddTest(BrandManager brandManager1)
        {
            brandManager1.Add(new Brand { Id = 5, BrandName = "Ford" });
            brandManager1.GetById(Id: 5);
        }

        private static void BrandUpdateTest(BrandManager brandManager1)
        {
            brandManager1.Update(new Brand { Id = 1, BrandName = "Ford" });
            foreach (var brand in brandManager1.GetAll())
            {
                Console.WriteLine("BrandId:{0} Brand name is updated to {1}", brand.Id, brand.BrandName);
            }
        }

        private static void BrandDeleteTest(BrandManager brandManager1)
        {
            brandManager1.Delete(new Brand { Id = 1, BrandName = "Audi" });
            foreach (var brand in brandManager1.GetAll())
            {
                Console.WriteLine("Brand deleted succesfully. These brands left. {0}", brand.BrandName);
            }
        }

        private static void GetCarsByBrandId(CarManager carManager1)
        {
            foreach (var car in carManager1.GetCarsByBrandId(brandId: 1))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void ColorAddTest(ColorManager colorManager1)
        {
            colorManager1.Add(new Color { Id = 2, ColorName = "Blue" });
            foreach (var color in colorManager1.GetAll())
            {
                Console.WriteLine("{0}", color.ColorName);
            }
        }

        private static void ColorUpdateTest(ColorManager colorManager1)
        {
            colorManager1.Update(new Color { Id = 1, ColorName = "Red" });
            foreach (var color in colorManager1.GetAll())
            {
                Console.WriteLine("{0}", color.ColorName);
            }
        }

        private static void ColorDeleteTest(ColorManager colorManager1)
        {
            colorManager1.Delete(new Color {Id = 1});
            foreach (var color in colorManager1.GetAll())
            {
                Console.WriteLine("Colors updated successfully. These colors left:", color.ColorName);
            }
        }

        private static void DeleteCarTest(CarManager carManager1)
        {
            carManager1.Delete(new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Lüks Araba", ModelYear = 2014 });
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void UpdateCarTest(CarManager carManager1)
        {
            carManager1.Update(new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Lüks Araba", ModelYear = 2015 });
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine("{0} {1}", car.Description, car.ModelYear);
            }
        }

        private static void AddCarTest(CarManager carManager1)
        {
            carManager1.Add(new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Lüks Araba", ModelYear = 2013 });
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
