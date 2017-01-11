using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    //3.Tworze klase dziedziczącą
    class Osobowy : Wagon
    {
        //a)dodaje pola prywatne
        private string rodzaj;
        
        //b)dodaje konstruktor parametrczyny
        public Osobowy(int MasaO, string ModelO,string RodzajO)
        {
            this.masa = MasaO;            
            this.model = ModelO;
            this.rodzaj = RodzajO;
        }

        //c)Implemetuje klase abstrakcyjna
        public override string Informacje()
         {
             return "Wagon osobowy: " + this.model + ", waga: " + this.masa + ", rodzaj: " + this.rodzaj;
         }

}
}
