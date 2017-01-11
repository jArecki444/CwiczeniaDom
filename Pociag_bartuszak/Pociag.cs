using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    //6. dodaj klase
    class Pociag : IPoprawnyPociag, IUzupelnijSklad
    {
        //a)prywatne pola typu list //b)inicjalizacja list
        private List<Wagon> wagony = new List<Wagon>();
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();

        //MOZE JECHAC
        public bool MozeJechac()
        {
            int masaLokomotyw = 0;
            int masaWagonow = 0;

            foreach(var e in lokomotywy)
            {
                masaLokomotyw += e.ZwrocMase();
            }

            foreach (var e in wagony)
            {
                masaWagonow += e.ZwrocMaseWagonu();
            }

            if (masaLokomotyw >= masaWagonow)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //DODAJ OSOBOWY
        public void DodajOsobowy(int Masa, string Model, string Rodzaj)
        {
            wagony.Add(new Osobowy(Masa, Model, Rodzaj));
        }

        //DODAJ TOWAROWY
        public void DodajTowarowy(int Masa, string Model, string Ladunek)
        {
            wagony.Add(new Towarowy(Masa,Model,Ladunek));
        }

        //DODAJ LOKOMOTYWE
        public void DodajLokomotywe(int Masa, string Model)
        {
            lokomotywy.Add(new Lokomotywa(Masa, Model));
        }

        //d)informacje
        public  string Informacje()
        {
            string info = "Skład pociągu: ";

            foreach(var e in lokomotywy)
            {
                info += Environment.NewLine + e.InformacjeL();
            }

            foreach(var e in wagony)
            {
                info += Environment.NewLine + e.Informacje();
            }

            return info;
        }


    }
}
