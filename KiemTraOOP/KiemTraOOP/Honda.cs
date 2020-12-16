using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraOOP
{
    class Honda : Car
    {
        public Honda(double _price, int _year) : base(_price, _year)
        { }

        public override void Show()
        {
            Console.WriteLine("Xe Honda");
        }

        public override double Discount()
        {
            if (Year < 2010)
                return Price - Price / 100 * 20;
            else
                return Price;
        }
    }
}
