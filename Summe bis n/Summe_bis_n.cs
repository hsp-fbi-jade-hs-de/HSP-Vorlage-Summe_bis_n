using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summe_bis_n
{
    public class Summe_bis_n
    {
        public int Summe_bis_n_Methode(int input)
        {

            int summe_bis_n = 0;

            //Code hier!

            return summe_bis_n;
        }

        static void Main(string[] args)
        {
            Summe_bis_n prg = new Summe_bis_n();

            Console.WriteLine("Bis zu welcher zahl soll aufsummiert werden?");
            Console.Write("Eingabe: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int summe_bis_n = prg.Summe_bis_n_Methode(input);
            Console.WriteLine(summe_bis_n);

            Console.ReadKey();

        }
    }
}
