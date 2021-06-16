using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesperson
{
    abstract class Salesperson
    {

        private string fName { get; set; }
        private string lName { get; set; }

        public Salesperson(string Fname, string Lname)
        {
            fName = Fname;
            lName = Lname;
        }

        public string Name()
        {
            return fName + "" + lName;
        }


    }
}
