using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesperson
{
    class GirlScout : Salesperson, ISellable
    {
        private int boxesSold = 0;

        public int BoxesSold
        {
            get
            {
                return boxesSold;
            }
            set
            {
                boxesSold = value;
            }
        }

        public GirlScout(string Fname, string Lname) : base(Fname, Lname)
        {

        }

        public void SalesSpeech()
        {
            Console.WriteLine("Hello, I am {0}, and I am a girl scout.  Would you like to buy some box of cookies?", Name());
        }

        public void MakeSale(int boxSold)
        {
            boxesSold += boxSold;
        }
    }
}
