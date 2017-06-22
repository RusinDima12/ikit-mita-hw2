using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ModelLibrary
{
    public class Car
    {        
        public  string Model { get; }
        public enum Category { B=1, C, D, E, F }
        public Category CarCategory { get; set; }
        public CarPassport CarPassport { get; }                    
        public Color Color { get; set; }
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
            CarCategory = category;          
            CarPassport = new CarPassport(this);
            Color = Color.DarkBlue;

        }
    }
}
