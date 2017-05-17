using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ikit_mita_hm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lada = new Car("Lada", Category.D);
            lada.Color = Car.ColorEnum.Баклажановый;
            try
            {
                Console.WriteLine(lada.carPassport.Owner.name);
            }
            catch (NullReferenceException)
            {
                
                Console.WriteLine("Водитель не назначен!");
            }
            
            
            Driver driver1 = new Driver("Вольдемарт", DateTime.Now);
            driver1.Categories.Add(Category.B);
            driver1.Categories.Add(Category.D);
            lada.ChangeOwner(driver1,"o777oo");            
            driver1.Categories.Add(Category.D);
            lada.ChangeOwner(driver1,"o777oo");
            Console.WriteLine(driver1.Car.CarNumber);
            Console.WriteLine(lada.carPassport.Owner.name);
            Console.ReadKey();


        }
    }
}
