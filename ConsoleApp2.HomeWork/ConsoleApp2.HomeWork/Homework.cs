using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.HomeWork
{
    public class Homework
    {
        private int[] sirNumere;

        public void SeteazaLunigmeSir()
        {
            Console.WriteLine("Introduceti lungime sir:");
            int lungime = Convert.ToInt32(Console.ReadLine());

            sirNumere = new int[lungime];

            Console.WriteLine("Populare sir");
            for (int i = 0; i < lungime; i++)
            {
                Console.WriteLine($"Introduceti valoare pentru pozitia {i}:");
                sirNumere[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void MediaAritmetica()
        {
            Console.WriteLine("*** Calculare medie aritmetica ***");

            int sumaNumereDinSir = 0;
            int lungimeSir = sirNumere.Length;

            for (int i = 0; i < lungimeSir; i++)
            {
                sumaNumereDinSir += sirNumere[i];
            }

            Console.WriteLine($"Media aritmetica: { sumaNumereDinSir / lungimeSir }");
        }

        public void MediaGeometrica()
        {
            Console.WriteLine("*** Calculare medie geometrica ***");

            int produsulNumerelorDinSir = 1;
            int lungimeSir = 0;

            for (int i = 0; i < lungimeSir; i++)
            {
                produsulNumerelorDinSir *= sirNumere[i];
            }

            var mediaGeometrica = Math.Pow(produsulNumerelorDinSir, (1.0) / lungimeSir);
            Console.WriteLine($"Media geometrica: {mediaGeometrica}");
        }

        public void MediaPonderata()
        {
            Console.WriteLine("*** Calculare medie ponderata ***");

            int max = sirNumere[0];

            for (int i = 0; i < sirNumere.Length; i++)
            {
                if (max < sirNumere[i])
                {
                    max = sirNumere[i];
                }
            }

            int[] valorilePonderate = new int[max + 1];

            for (int i = 0; i < sirNumere.Length; i++)
            {
                valorilePonderate[sirNumere[i]] += 1;
            }

            int sumaPonderata = 0;
            int sumaValoriPonderate = 0;
            for(int i = 0; i < valorilePonderate.Length; i++)
            {
                sumaPonderata += valorilePonderate[i] * i;
                sumaValoriPonderate += valorilePonderate[i];
            }

            var mediaPonderata = Decimal.Divide(sumaPonderata, sumaValoriPonderate);
            Console.WriteLine($"Media ponderata {mediaPonderata}");
        }

        public void CelMaiMicNumarDinSir()
        {
            Console.WriteLine("*** Cel mai mic numar din sir");

            int min = sirNumere[0];

            for (int i = 0; i < sirNumere.Length; i++)
            {
                if (min > sirNumere[i])
                {
                    min = sirNumere[i];
                }
            }

            Console.WriteLine($"Cel mai mic numar este: {min}");
        }

        public void CelMaiMareNumarDinSir()
        {
            Console.WriteLine("*** Cel mai mare numar din sir ***");

            int max = sirNumere[0];

            for (int i = 0; i < sirNumere.Length; i++)
            {
                if (max < sirNumere[i])
                {
                    max = sirNumere[i];
                }
            }

            Console.WriteLine($"Cel mai mare numar este: {max}");
        }

        public void AfisareNumere()
        {
            Console.WriteLine("*** Afisare numere ***");

            for (int i = 0; i < sirNumere.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Elementul {sirNumere[i]} de pe pozitia {i} este par");
                }
                else
                {
                    Console.WriteLine($"Elementul {sirNumere[i]} de pe pozitia {i} este impar");
                }

                var estePrim = NumarEstePrim(sirNumere[i]);

                if (estePrim)
                {
                    Console.WriteLine($"Elementul {sirNumere[i]} de pe pozitia {i} este prim");
                }
                else
                {
                    Console.WriteLine($"Elementul {sirNumere[i]} de pe pozitia {i} este nu este prim");
                }
            }
        }

        public void SumaNumerelor()
        {
            Console.WriteLine("*** Calculare suma numerelor pana la valoarea data ***");
            Console.WriteLine("Introduceti numar");
            var numar = Convert.ToInt32(Console.ReadLine());

            var sumaNumerelor = (numar * (numar + 1)) / 2;

            Console.WriteLine($"Suma numerelor este: {sumaNumerelor}");
        }

        public void AfisareSirInOrdine()
        {
            Console.WriteLine("*** Afisare in ordine descrescatoare****");

            int lungimeSir = sirNumere.Length;
            int schimb = 0;
            int[] sirCrescator = sirNumere;
            int[] sirDescrescator = sirNumere;

            for (int i = 0; i <= lungimeSir - 2; i++)
            {
                for (int j = i + 1; j <= lungimeSir - 1; j++)
                {
                    if (sirCrescator[i] < sirCrescator[j])
                    {
                        schimb = sirCrescator[i];
                        sirCrescator[i] = sirCrescator[j];
                        sirCrescator[j] = schimb;
                    }
                }
            }

            Console.WriteLine("Numere in ordine descrescatoare");
            for (int i = 0; i < lungimeSir; i++)
            {
                Console.WriteLine(sirCrescator[i]);
            }

            Console.WriteLine("*** Afisare in ordine crescatoare****");

            schimb = 0;

            for (int i = 0; i <= lungimeSir - 2; i++)
            {
                for (int j = i + 1; j <= lungimeSir - 1; j++)
                {
                    if (sirDescrescator[i] > sirDescrescator[j])
                    {
                        schimb = sirDescrescator[i];
                        sirDescrescator[i] = sirDescrescator[j];
                        sirDescrescator[j] = schimb;
                    }
                }
            }

            Console.WriteLine("Numere in ordine crescatoare");
            for (int i = 0; i < lungimeSir; i++)
            {
                Console.WriteLine(sirDescrescator[i]);
            }
        }

        private bool NumarEstePrim(int numar)
        {
            int i = 2;
            bool prime = true;

            while (i <= numar / 2)
            {
                if (numar % i == 0)
                {
                    prime = false;
                }
                i += 1;
            }

            return prime;
        }
    }
}
