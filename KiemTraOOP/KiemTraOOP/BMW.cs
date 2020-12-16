using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraOOP
{
    class BMW : Car
    {
        public BMW(double _price, int _year):base(_price,_year)
        { }

        public override void Show()
        {
            Console.WriteLine("Xe BMW");
        }

        public override double Discount()
        {
            if (Year < 2005)
                return Price - Price / 100 * 5; 
            else
                return Price;
        }
    }
}
