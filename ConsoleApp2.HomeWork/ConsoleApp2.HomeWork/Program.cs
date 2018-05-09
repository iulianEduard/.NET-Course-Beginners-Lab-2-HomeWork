using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var homework = new Homework();

            homework.SeteazaLunigmeSir();

            homework.MediaAritmetica();
            homework.MediaGeometrica();
            homework.MediaPonderata();
            homework.CelMaiMicNumarDinSir();
            homework.CelMaiMareNumarDinSir();
            homework.AfisareNumere();
            homework.SumaNumerelor();
            homework.AfisareSirInOrdine();

            Console.ReadKey();
        }
    }
}
