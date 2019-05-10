using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Teacher
    {
        private double _salary;

        public double salary
        {
            get
            {
                return this._salary;
            }
            set
            {
                this._salary = value;
            }


        }
           
           
    }
    class Car
    {
        private double _currentFuel;
        private double _fuelCapacity;
        private double _fuelUsage;
        private double _globalkm;
        private double _localkm;

        public Car(double fuelUsage, double FuelCapacity)
        {
            // Console.WriteLine("Usage: {0}, Capacity {1}", fuelUsage, FuelCapacity;
            //  Console.ReadLine();
            this._fuelCapacity = fuelUsage;
            this._fuelCapacity = FuelCapacity;
            this.CalcBeginFuel();

        }

        private void CalcBeginFuel()
        {
            this._currentFuel = this._fuelCapacity * 0.1;
        }

        public bool Drive(double km)
        {
            if (this._currentFuel / this._fuelCapacity * 100 < km)
            {
                return false;
            }
            this._globalkm += km;
            this._localkm += km;

            this._currentFuel -= this._fuelUsage * km / 100;
            return true;


            Console.WriteLine(this._currentFuel);
            Console.ReadLine();
        }

        public double globalkm
        {
            get
            {
                return this._globalkm;
            }
        }
         public double localkm
        {
            get
            {
                return this._localkm;
            }
        }
        
        public double currentFuel
        {
            get
            {
                return this._currentFuel;
            }
        }
        public bool AddFuel(double litr)
        {
           if(this._currentFuel+litr > this._fuelCapacity)
            {
                return false;
            }
            this._currentFuel += litr;
            return true;
        }
        public void Resetkm()
        {
            this._localkm = 0;
        }

        

    }
 

}
