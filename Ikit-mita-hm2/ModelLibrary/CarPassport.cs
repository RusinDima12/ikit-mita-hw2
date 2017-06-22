using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class CarPassport
    {
        public Driver Owner { get; set; }
        private  Car _car { get; }

        public CarPassport(Car car)
        {
            _car = car;
        }

    }
}
