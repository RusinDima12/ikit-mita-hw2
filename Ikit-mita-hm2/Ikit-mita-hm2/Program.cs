using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace Ikit_mita_hm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lada = new Car("Lada", Car.Category.D);
           
            lada.Color = Color.DarkMagenta;              
            try
            {                
                 Console.WriteLine(lada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                
                Console.WriteLine("Водитель не назначен!");
            }                      
            Driver driver1 = new Driver("Вольдемарт",DateTime.Now);
            driver1.Categories.Add(Driver.Category.B);
            driver1.Categories.Add(Driver.Category.C);
            Console.WriteLine(driver1.Experience());
            try
            {
                lada.ChangeOwner(driver1, "o777oo");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
                      
            driver1.Categories.Add(Driver.Category.D);

            try
            {
                lada.ChangeOwner(driver1,"o777oo");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(driver1.Car.CarNumber);
            Console.WriteLine(lada.CarPassport.Owner.Name);
            Console.ReadKey();


        }
    }
}
