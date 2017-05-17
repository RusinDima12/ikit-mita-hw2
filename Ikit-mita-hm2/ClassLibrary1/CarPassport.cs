using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CarPassport
    {
        public Driver Owner;
        private readonly Car _car;

        public CarPassport(Car car)
        {
            _car = car;
        }

    }
}
