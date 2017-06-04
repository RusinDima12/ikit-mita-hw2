using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Driver
    {        
        public DateTime LicenceData { get; }
        public  string Name { get; }        
        public List<Category> Categories { get; set; }
        public Driver(string Name,DateTime LicenceTime)
        {
            Categories = new List<Category>();
            this.Name = Name;
            LicenceData = LicenceTime;
            
        }
        DateTime dateNow= DateTime.Now;
        public int Experience()
        {
            if (dateNow.Year <= LicenceData.Year)
            {
                return 0;
            }
            else
            {                            
                int n = dateNow.Year - LicenceData.Year;
                if (LicenceData.DayOfYear > dateNow.DayOfYear)
                {
                    --n;                   
                }               
                return n;  
                
             }
        }


        public void OwnCar(Car car)
        {
            int i = 0;
            foreach (var t  in Categories)
            {
                 if (t== car.Category)
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

    public enum Category { A, B, C ,D }
   
}
