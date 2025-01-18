using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    //clas 1
    // Temp = темпратура 
    //Cel=Цселся 
    // Far =Фарвнгейт 
    public class Temp
    {
        
        public static double CelFar(double cel)
        {
            return (cel * 9 / 5) + 32;
        }

      
        public static double FarCel(double far)
        {
            return (far - 32) * 5 / 9;
        }
    }

   // class 2
    public class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

     
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

      
        public void Deconstruct(out string brand, out string model, out int year)
        {
            brand = Brand;
            model = Model;
            year = Year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            double cel = 25;
            double far = Temp.CelFar(cel);
            Console.WriteLine($"{cel}°C = {far}°F");

            far = 88;
            cel = Temp.FarCel(far);
            Console.WriteLine($"{far}°F = {cel}°C");

           
            Car car = new Car("Toyota", "Corolla", 2020);
            Console.WriteLine($"Автомобил: {car.Brand} {car.Model} {car.Year}");

           
            var (brand, model, year) = car;
            Console.WriteLine($"Марка: {brand}, Модель: {model}, Год: {year}");
            Console.ReadKey();

        }
    }
}
