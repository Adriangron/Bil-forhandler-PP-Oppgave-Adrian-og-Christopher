using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_forhandler_PP_Oppgave
{
    internal class Car
    {
        public string Brand {  get; set; }
        public int ModelYear { get; set; }
        public string RegNumber { get; set; }
        public double Milage { get; set; }
        

        public Car(string brand, int modelYear, string regNumber, double milage)
        {
            Brand = brand;
            ModelYear = modelYear;
            RegNumber = regNumber;
            Milage = milage;
        }

        public override string ToString()
        {
            return $"{Brand} {ModelYear} - Reg: {RegNumber}, Milage: {Milage} Km";
        }



    }
}
