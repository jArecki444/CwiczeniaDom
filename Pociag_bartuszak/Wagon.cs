using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    //2.Tworze klasę abstrakcyjna
    abstract class Wagon
    {
        //a)Dodaje pola
        protected string model;
        protected int masa;

        //b)Deklaracja metory absktakcyjnej
        public abstract string Informacje();
     
        //c)Deklaracja i implementacja metody zwrac. mase
        public int ZwrocMaseWagonu()
        {
            return this.masa;
        }

    }
}
