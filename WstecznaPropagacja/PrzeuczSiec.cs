using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    static class PrzeuczSiec
    {
        public static void przeuczSiec(List<double[]> listaProbek, Siec siec, Propagacja propagacja,int iloscWejsc)
        {
            for (int j = 0; j < 20000; j++)
            {
                for (int i = 0; i < listaProbek.Count; i++)
                {
                    // siec.wyswietlListeNeuronowZWagami();
                    siec.wyliczWartoscWyjsciowaSieci(siec.warstwy, listaProbek[i]);
                    propagacja.wyliczBlad(listaProbek[i].Skip(iloscWejsc).ToArray());
                    propagacja.wyliczKoretke(listaProbek[i], iloscWejsc);
                }
                randomizujListe(listaProbek);
                if (j % 1000 == 0)
                {
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("Epoka: " + j);
                    propagacja.wyswietlKOrektyWszystkichWag(propagacja.korektyWagCalejSieci);
                }
                //nadpisanie wag po propagacji wszystkich probek
                propagacja.nadpiszWagi(siec, propagacja.korektyWagCalejSieci);
                propagacja.korektyWagCalejSieci.Clear();
            }
        }

        private static void randomizujListe(List<double[]> lista)
        {
            Random random = new Random();
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                double[] tmp = lista[k];
                lista[k] = lista[n];
                lista[n] = tmp;
            }
        }
    }
}
