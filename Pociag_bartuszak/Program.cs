using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag_bartuszak
{
    class Program
    {
        static public ConsoleKey key;

        static void Main(string[] args)
        {

            Pociag ciapag = new Pociag();

            while (key != ConsoleKey.E)
            {
                Console.Clear();
                Console.WriteLine(@"Aplikacja do składania pociągow
Co chcesz zrobic?
L - dodaj lokomotywę
W - dodaj wagon
Z - wypisz zawartosc
S - sprawdz czy moze jechac
E - Wyjście");
                key = Console.ReadKey().Key;
                

                switch (key)
                {
                    case ConsoleKey.L:
                        {
                            Console.WriteLine("Dodaje lokomotywe...");
                            Console.WriteLine("Podaj model:");
                            string modelP = Console.ReadLine();

                            Console.WriteLine("Podaj masę w kg:");
                            int masaP = int.Parse(Console.ReadLine());

                            ciapag.DodajLokomotywe(masaP, modelP);
                          
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            Console.WriteLine("Jaki wagon dodać? \nT - Towarowy\nO - Osobowy");
                            ConsoleKey jakiWagon = Console.ReadKey().Key;

                            switch (jakiWagon)
                            {
                                case ConsoleKey.T:
                                    {
                                        Console.WriteLine("Dodaje Wagon Towarowy...");
                                        Console.WriteLine("Podaj model:");
                                        string modelW = Console.ReadLine();
                                        
                                        Console.WriteLine("Podaj masę:");
                                        int masaW = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Podaj ładunek:");
                                        string ladunekW = Console.ReadLine();

                                        ciapag.DodajTowarowy(masaW, modelW, ladunekW);
                                        break;
                                    }
                                case ConsoleKey.O:
                                    {
                                        Console.WriteLine("Dodaje Wagon Osobowy...");
                                        Console.WriteLine("Podaj model:");
                                        string modelW = Console.ReadLine();

                                        Console.WriteLine("Podaj masę:");
                                        int masaW = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Podaj rodzaj:");
                                        string rodzajW = Console.ReadLine();

                                        ciapag.DodajOsobowy(masaW, modelW, rodzajW);
                                        
                                        break;
                                    }
                                default:
                                    {                                       
                                        Console.WriteLine("Błąd!");
                                        Console.ReadLine();
                                        break;
                                    }
                            }
                            

                            break;
                        }
                    case ConsoleKey.Z:
                        {
                            Console.WriteLine(ciapag.Informacje());
                            Console.ReadLine();
                            break;
                        }
                    case ConsoleKey.S:
                        {
                            if (ciapag.MozeJechac())
                            {
                                Console.WriteLine("Ciapąg może jechać!");
                            }
                            else
                            {
                                Console.WriteLine("Ciapąg NIE może jechać!");
                            }
                            Console.ReadLine();
                            break;
                        }
                }
            }

        }
        
    }
}
