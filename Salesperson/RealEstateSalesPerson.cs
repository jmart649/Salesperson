using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesperson
{
    class RealEstateSalesPerson : Salesperson, ISellable
    {

        private int valueSold = 0;
        private int totalComm = 0;
        private double commRate = .05;

        public int ValueSold
        {
            get
            {
                return valueSold;
            }
            set
            {
                valueSold = value;
            }
        }

        public int TotalComm
        {
            get
            {
                return totalComm;
            }
            set
            {
                totalComm = value;
            }
        }

        public double CommRate
        {
            get
            {
                return commRate;
            }
            set
            {
                commRate = value;
            }
        }

        public RealEstateSalesPerson(string Fname, string Lname) : base(Fname, Lname)
        {

        }
        public void SalesSpeech()
        {
            Console.WriteLine("Hello, my name is {0}, and I am an Real Estate Sales person.", Name());
        }

        public void MakeSale(int houseValue)
        {
            valueSold += houseValue;
            totalComm = (int)(valueSold * commRate);
        }
    }
}
