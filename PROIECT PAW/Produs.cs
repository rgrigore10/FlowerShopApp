using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROIECT_PAW
{
    public class Produs
    {
        public string Denumire;
        public double Pret;
        public int Stoc;
       
        Produs()
        {

        }
       public Produs(string _den, double _pret, int _stoc)
        {
            Denumire = _den;
            Pret = _pret;
            Stoc = _stoc;
         
        }
    }
}
