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
            CustomerManager customerManager1 = new CustomerManager(new EfCustomerDal());
            UserManager userManager1 = new UserManager(new EfUserDal());
            DateTime date1 = new DateTime(2021, 04, 01);
            RentalManager rentalManager1 = new RentalManager(new EfRentalDal());



            //CarRental(rentalManager1, date1);
            //CustomerAddTest(customerManager1);
            //CarDetailTest(carManager1);
            //BrandAddTest(brandManager1);
            //BrandUpdateTest(brandManager1);
            //BrandDeleteTest(brandManager1);
            ColorAddTest(colorManager1);
            //ColorUpdateTest(colorManager1);
            //ColorDeleteTest(colorManager1);
            //AddCarTest(carManager1);
            //UpdateCarTest(carManager1);
            //DeleteCarTest(carManager1);
            //GetCarsByBrandId(carManager1);

        }

        private static void CarRental(RentalManager rentalManager1, DateTime date1)
        {
            rentalManager1.Add(new Rental {CarId = 1, CustomerId = 1, RentDate = date1, ReturnDate = null });
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.Delete(new Car { Id = 1});
        }

        private static void CustomerAddTest(CustomerManager customerManager1)
        {
            customerManager1.Add(new Customer {CompanyName = "Delta Investments" });
            customerManager1.Add(new Customer {CompanyName = "Grayscale Investments" });
            customerManager1.Add(new Customer {CompanyName = "CostCo Group" });
        }

        private static void CarDetailTest(CarManager carManager1)
        {
            var result = carManager1.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine("Car Name = {0} -- Brand Name = {1} -- Color Name = {2} -- Daily Price = {3}", 
                    car.Name, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void BrandAddTest(BrandManager brandManager1)
        {
            brandManager1.Add(new Brand {BrandName = "Ford" });
            brandManager1.GetById(Id: 1);
        }

        private static void BrandUpdateTest(BrandManager brandManager1)
        {
            var result = brandManager1.GetAll();
            brandManager1.Update(new Brand { Id = 1, BrandName = "Ford" });
            foreach (var brand in result.Data)
            {
                Console.WriteLine("BrandId:{0} Brand name is updated to {1}", brand.Id, brand.BrandName);
            }
        }

        private static void BrandDeleteTest(BrandManager brandManager1)
        {
            var result = brandManager1.GetAll();
            brandManager1.Delete(new Brand { Id = 1, BrandName = "Audi" });
            foreach (var brand in result.Data)
            {
                Console.WriteLine("Brand deleted succesfully. These brands left. {0}", brand.BrandName);
            }
        }

        private static void GetCarsByBrandId(CarManager carManager1)
        {
            var result = carManager1.GetCarsByBrandId(brandId: 1);
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void ColorAddTest(ColorManager colorManager1)
        {
            colorManager1.Add(new Color { ColorName = "Purple" });
            var result = colorManager1.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine("{0}", color.ColorName);
            }
        }

        private static void ColorUpdateTest(ColorManager colorManager1)
        {
            var result = colorManager1.GetAll();
            colorManager1.Update(new Color { Id = 1, ColorName = "Red" });
            foreach (var color in result.Data)
            {
                Console.WriteLine("{0}", color.ColorName);
            }
        }

        private static void ColorDeleteTest(ColorManager colorManager1)
        {
            var result = colorManager1.GetAll();
            colorManager1.Delete(new Color {Id = 1});
            foreach (var color in result.Data)
            {
                Console.WriteLine("Colors updated successfully. These colors left:", color.ColorName);
            }
        }

        private static void DeleteCarTest(CarManager carManager1)
        {
            var result = carManager1.GetAll();
            carManager1.Delete(new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Lüks Araba", ModelYear = 2014 });
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void UpdateCarTest(CarManager carManager1)
        {
            var result = carManager1.GetAll();
            carManager1.Update(new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Lüks Araba", ModelYear = 2015 });
            foreach (var car in result.Data)
            {
                Console.WriteLine("{0} {1}", car.Description, car.ModelYear);
            }
        }

        private static void AddCarTest(CarManager carManager1)
        {
            carManager1.Add(new Car {BrandId = 1, ColorId = 1, DailyPrice = 350, Description = "Baya baya Lüks Araba", ModelYear = 2019, Name = "Q7" });
        }
    }
}
