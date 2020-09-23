using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();

        static void Main(string[] args)
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                for (int i = 0; i < termekek.Count; i++)
                {
                    
                }
            }
            raktar.Close();

            Console.ReadKey();
        }
    }
}
