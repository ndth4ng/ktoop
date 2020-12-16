using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraOOP
{
    abstract class Car
    {
        private double price;
        private int year;    

        public Car(double _price, int _year)
        {
            price = _price;
            year = _year;
        }

        public double Price { get => price; set => price = value; }
        public int Year { get => year; set => year = value; }

        public abstract void Show();

        public abstract double Discount();
    }

}
