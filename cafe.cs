using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_cafeManagementSystem
{
    class cafe
    {
        //default constructor
        public cafe()
        {
            ncf1 = 0.0;
            ncf2 = 0.0;
            ncf3 = 0.0;
            ncf4 = 0.0;
            ncf5 = 0.0;
            ncf6 = 0.0;
            ncf7 = 0.0;
            ncf8 = 0.0;

            nck1 = 0.0;
            nck2 = 0.0;
            nck3 = 0.0;
            nck4 = 0.0;
            nck5 = 0.0;
            nck6 = 0.0;
            nck7 = 0.0;
            nck8 = 0.0;

        }
        //overload constructor
        public cafe(double tck1, double tck2, double tck3, double tck4, double tck5, double tck6, double tck7,
            double tck8, double tcf1, double tcf2, double tcf3, double tcf4, double tcf5, double tcf6,
            double tcf7, double tcf8)
        {
            nck1 = tck1;
            nck2 = tck2;
            nck3 = tck3;
            nck4 = tck4;
            nck5 = tck5;
            nck6 = tck6;
            nck7 = tck7;
            nck8 = tck8;

            ncf1 = tcf1;
            ncf2 = tcf2;
            ncf3 = tcf3;
            ncf4 = tcf4;
            ncf5 = tcf5;
            ncf6 = tcf6;
            ncf7 = tcf7;
            ncf8 = tcf8;
        }
        //get functions
        public double getcf1()
        {
            return ncf1;
        }
        public double getcf2()
        {
            return ncf2;
        }
        public double getcf3()
        {
            return ncf3;
        }
        public double getcf4()
        {
            return ncf4;
        }
        public double getcf5()
        {
            return ncf5;
        }
        public double getcf6()
        {
            return ncf6;
        }
        public double getcf7()
        {
            return ncf7;
        }
        public double getcf8()
        {
            return ncf8;
        }
        public double getck1()
        {
            return nck1;
        }
        public double getck2()
        {
            return nck2;
        }
        public double getck3()
        {
            return nck3;
        }
        public double getck4()
        {
            return nck4;
        }
        public double getck5()
        {
            return nck5;
        }
        public double getck6()
        {
            return nck6;
        }
        public double getck7()
        {
            return nck7;
        }
        public double getck8()
        {
            return nck8;
        }

        //member variables for coffee
        private double ncf1, ncf2, ncf3, ncf4, ncf5, ncf6, ncf7, ncf8;
        //member variables for cakes
        private double nck1, nck2, nck3, nck4, nck5, nck6, nck7, nck8;

    }
   






}
