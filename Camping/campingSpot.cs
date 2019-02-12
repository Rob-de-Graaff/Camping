using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class CampingSpot
    {
        private string name;
        private double rentLow;
        private double rentLengthMin;
        private double rentLengthPlus;
        private double perPerson;
        private double dog;
        private double car;
        private int length;
        private DateTime mainStart;
        private DateTime mainEnd;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double RentMain { get; set; }

        public double RentLow
        {
            get { return rentLow; }
            set { rentLow = value; }
        }

        public double RentLengthMin
        {
            get { return rentLengthMin; }
            set { rentLengthMin = value; }
        }

        public double RentLengthPlus
        {
            get { return rentLengthPlus;}
            set { rentLengthPlus = value; }
        }

        public double PerPerson
        {
            get { return perPerson;}
            set { perPerson = value; }
        }

        public double Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        public double Car
        {
            get { return car; }
            set { car = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public DateTime MainStart
        {
            get { return mainStart; }
            set { mainStart = value; }
        }

        public DateTime MainEnd
        {
            get { return mainEnd; }
            set { mainEnd = value; }
        }

        public CampingSpot(string campingName, double campingRentMain, double campingRentLow,
            double campingRentLengthMin, double campingRentLengthPlus, double campingPerPerson, double campingDog,
            double campingCar, int campingLength, DateTime campingMainStart, DateTime campingMainEnd)
        {
            name = campingName;
            RentMain = campingRentMain;
            rentLow = campingRentLow;
            rentLengthMin = campingRentLengthMin;
            rentLengthPlus = campingRentLengthPlus;
            perPerson = campingPerPerson;
            dog = campingDog;
            car = campingCar;
            length = campingLength;
            mainStart = campingMainStart;
            mainEnd = campingMainEnd;
        }
    }
}
