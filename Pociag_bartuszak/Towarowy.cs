using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    //4.Klasa dziedziczaca
    class Towarowy : Wagon
    {
        //a)dodaj prywatne pola
        private string ladunek;

        //b)konstruktor parametryczny
        public Towarowy (int MasaT, string ModelT, string LadunekT)
        {
            this.masa = MasaT;
            this.model = ModelT;            
            this.ladunek = LadunekT;
        }

        //c)implementacja metody Inforamcje z Wagon
        public override string Informacje()
        {
            return "Wagon towarowy: " + this.model + ", waga: " + this.masa + ", ładunek: " + this.ladunek;
        }
    }
    
}
