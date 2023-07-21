using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    public class Comanda
    {
       
       
        public List<Produs> produse;
        public Client client;
        public DateTime data_comenzii;
        public Comanda()
        {
           
        }
        public Comanda(DateTime _data,List<Produs> _produse, Client _client)
        {
            
            client = _client;
            produse = _produse;
            data_comenzii = _data;
        }
    }
}
