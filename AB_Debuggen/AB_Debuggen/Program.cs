using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_Debuggen
{
    class Program
    {
        // Lösung
        static void Main(string[] args)
        {
            Console.Write("Wieviele Etagen soll Ihr Turm haben? ");
            int etagen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //äussere Schleife: zeichnet die einzelnen Etagen
            for (int k = 1; k <= etagen; k++)
            {
                //mittlere Schleife: zeichnet die Zeilen pro Etage
                for (int j = 1; j <= 2 * (k - 1) + 1; j++)
                {
                    //innere Schleife: zeichnet die Leezeichen am Anfang der Zeilen
                    for (int i = 1; i <= etagen - k; i++)
                    {
                        Console.Write(" ");
                    }
                    //innere Schleife: zeichnet die Sterne pro Zeile
                    for (int y = 1; y <= 2 * (k - 1) + 1; y++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }


        // Mit den Fehlern
        static void Main(string[] args)
        {
            Console.Write("Wieviele Etagen soll Ihr Turm haben? ");
            int etagen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //äussere Schleife: zeichnet die einzelnen Etagen
            for (int k = 1; k <= 3; k++)
            {
                //mittlere Schleife: zeichnet die Zeilen pro Etage
                for (int j = 1; j <= 2 * (k - 1) + 1; j++)
                {
                    //innere Schleife: zeichnet die Leezeichen am Anfang der Zeilen
                    for (int i = 1; i <= etagen; i++)
                    {
                        Console.WriteLine(" ");
                    }
                    //innere Schleife: zeichnet die Sterne pro Zeile
                    for (int i = 1; i <= 2 * (k - 1) + 1; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
        
    }
}
