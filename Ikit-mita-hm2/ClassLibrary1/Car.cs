using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary1
{
    public class Car
    {
        readonly string _model;
        internal readonly Category _category;
        public readonly CarPassport carPassport;

            
        public enum ColorEnum
        {
            Белый, Синий, Желтый, Баклажановый, Черный
        }

        public ColorEnum Color;
        public string CarNumber{get; private set; }

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            carPassport.Owner = driver;
            CarNumber = carNumber;
        }
        public Car(string model,Category category)
        {
            _model = model;
            _category = category;
            carPassport = new CarPassport(this);
            Color = ColorEnum.Синий;

        }
    }
}
