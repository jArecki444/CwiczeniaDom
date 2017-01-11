using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    //1.Dodaje klase lokomotywa
    class Lokomotywa
    {
        //a)Dodaje pola prywatne
        private string model;
        private int masa;

        //b)Dodaje konstruktor parametryczny
        public Lokomotywa(int MasaL,string ModelL)
        {
            this.masa = MasaL;
            this.model = ModelL;            
        }

        //c)Metoda zwaracajaca masę lokmotywy
        public int ZwrocMase()
        {
            return this.masa;
        }

        //d)Metod informacje zwracajaca string z info
        public string InformacjeL()
        {
            return "Lokomotywa: model: " + this.model + ", masa: " + this.masa;
        }
    }
}
