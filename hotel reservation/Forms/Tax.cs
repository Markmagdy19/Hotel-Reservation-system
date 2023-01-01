using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_reservation.Forms
{
    class Tax
    {
        public double item1;
        public double item2;
        public double mcTax_Rate = 0.65;
            

            public double GetAmount()
        {
            return item1*item2;

        }
        public double CFindTax(double CAmount)
        {
            double Findtax = CAmount - (CAmount * mcTax_Rate);
            return Findtax;
        }
    }
}
