using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_PUM
{
    class Kalkulator
    {
        private double Wynik;

        public void Dodaj(double x)
        {
            Wynik += x;
        }

        public void Odejmuj(double x)
        {
            Wynik -= x;
        }

        public void Mnozenie(double x)
        {
            Wynik *= x;
        }

        public void Dzielenie(double x)
        {
            Wynik /= x;
        }
    }
}
