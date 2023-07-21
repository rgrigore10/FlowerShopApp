using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class Client
    {
        public string Nume;
        public string Prenume;
        public string Email;
        public string Nr_telefon;
        public string Parola;
        
        public Client()
        {

        }
        public Client(string _nume, string _prenume, string _email, string _nrtelefon,string _parola)
        {
            Nume = _nume;
            Prenume = _prenume;
            Email = _email;
            Nr_telefon = _nrtelefon;
            Parola = _parola;
        }
    }
}
