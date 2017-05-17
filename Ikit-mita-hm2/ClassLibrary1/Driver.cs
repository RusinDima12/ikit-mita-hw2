using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Driver
    {        
        private readonly DateTime _licenceData;
        public readonly string name;        
        public List<Category> Categories;
        public Driver(string Name,DateTime LicenceTime)
        {
            Categories = new List<Category>();
            name = Name;
            _licenceData = LicenceTime;
            
        }
        DateTime dateNow=DateTime.Now;

        public int Experience
        {
            get {return dateNow.Year-_licenceData.Year;}
        }

        public void OwnCar(Car car)
        {
            int i = 0;
            foreach (var t in Categories)
            {
                 if (car._category == t)
                    {
                        Car = car;
                        i++;
                    }                             
            }
            if (i == 0)
            {
                Console.WriteLine("В правах нет категории под эту машину!Машина не назначена");
            }
        }
        public Car Car { get; private set; }
    }
    public enum Category
        {
            A, B, C ,D
        }
}
