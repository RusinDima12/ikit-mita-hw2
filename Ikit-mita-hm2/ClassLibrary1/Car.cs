using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary1
{
    public class Car
    {        
        public  string Model { get; }
        public  Category Category { get; }
        public CarPassport CarPassport { get; }

            
        public enum ColorEnum
        {
            Белый, Синий, Желтый, Баклажановый, Черный
        }

        public ColorEnum Color { get; set; } = ColorEnum.Синий;
        public string CarNumber{get; private set; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carNumber;
        }
        public Car(string model,Category category)
        {
            Model = model;
            if (category == Category.A)
            {
                Console.WriteLine("Авто нельзя присвоить категорию А ");
            }
            else { Category = category; }           
            CarPassport = new CarPassport(this);
            Color = ColorEnum.Синий;

        }
    }
}
