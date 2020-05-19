using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    class Propagacja
    {
        public Propagacja(Siec siec, double[] wejscia,int iloscWejsc)
        {
            this.siec = siec;
            this.wejscia = wejscia.Take(iloscWejsc).ToArray();
        }
        private Siec siec;
        // public List<double> bladWyjscia = new List<double>();
        public double wspolczynnik = 0.1;
        public double parametrBeta = 1;
        double[] wejscia;
        public List<List<double>> korektyWagCalejSieci = new List<List<double>>(); // korekty wag całej sieci w odwrotnej kolejnosci
        public List<double> korektySum = new List<double>();
        public List<double> korektyWag = new List<double>();
        public List<double> korektyWejsc = new List<double>();

        public void wyliczBlad(double[] oczekiwaneWyjscie)
        {
            korektyWejsc.Clear();
            for (int i = 0; i < oczekiwaneWyjscie.Length; i++)
            {
                
                Console.WriteLine("wyjscie: " + siec.warstwy[siec.warstwy.Count - 1][i].wyjscie_);
                Console.WriteLine("oczekiwane: " + oczekiwaneWyjscie[i]);
                korektyWejsc.Add((oczekiwaneWyjscie[i] - siec.warstwy[siec.warstwy.Count - 1][i].wyjscie_) * wspolczynnik);
                Console.WriteLine("blad wyjscia neuronu " + i + " : " + korektyWejsc[i]);
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }

        public void wyliczKoretke()
        {   
            //iteracja po warstwach sieci od konca
            for (int l = siec.warstwy.Count - 1; l >= 0; l--)
            {
                List<double> pom = new List<double>(korektyWejsc);
                if (l < siec.warstwy.Count - 1)
                    pom.RemoveAt(0);    //usuniecie z listy korekty dodatkowego wjescia neruonu
                Console.WriteLine("\n------------------------------------------------------------------------\n");
                Console.WriteLine("-----Warstwa----- " + l);
                //iteracja po poszczególnych neuronach
                for (int n = 0; n < siec.warstwy[l].Count; n++)
                {
                    Console.WriteLine("\n-----Neuron----- " + (n + 1));
                    //korekty sum
                    korektySum.Add(pom[n] * parametrBeta * siec.warstwy[l][n].wyjscie_ * (1 - siec.warstwy[l][n].wyjscie_));

                    Console.WriteLine("korekta sumy:  " + korektySum[n]);

                    korektyWejsc.Clear();

                    //korekty na wag i wejsc
                    //korekta wagi dodatkowego wejscia neuronu
                    korektyWag.Add(korektySum[n] * 1);
                    //korekta wejscia dodatkowego wejscia neuronu
                    korektyWejsc.Add(korektySum[n] * 1);

                    //dla pierwszej warstwy
                    if (l == 0)
                    {
                        Console.WriteLine("korekta wagi 0: " + korektyWag[0]);
                        for (int i = 1; i < siec.warstwy[l][n].listaWag.Count; i++)
                        {
                            korektyWag.Add(korektySum[n] * wejscia[i - 1]);
                            Console.WriteLine("korekta wagi: " + korektySum[n] * wejscia[i - 1]);
                        }
                    }

                    else
                    {
                        for (int i = 1; i < siec.warstwy[l][n].listaWag.Count; i++)
                        {
                            korektyWag.Add(korektySum[n] * siec.warstwy[l - 1][i - 1].wyjscie_);
                            Console.WriteLine("korekta wagi: " + korektySum[n] * siec.warstwy[l - 1][i - 1].wyjscie_);

                            //korekta wejść
                            korektyWejsc.Add(korektySum[n] * siec.warstwy[l][n].listaWag[i].waga);
                            Console.WriteLine("korekta wejscia: " + korektySum[n] * siec.warstwy[l][n].listaWag[i].waga);
                        }
                    }
                }
                korektySum.Clear();
                if(korektyWagCalejSieci.Count != siec.warstwy.Count)
                    korektyWagCalejSieci.Add(new List<double>(korektyWag));
                else
                {
                    korektyWagCalejSieci.Reverse();
                    for (int i = 0; i < korektyWag.Count; i++)
                        korektyWagCalejSieci[l][i] += korektyWag[i];
                    korektyWagCalejSieci.Reverse();
                }
                korektyWag.Clear();
            }
            Console.WriteLine("\n------------------------------------------------------------------------\n Korekty wag");
            wyswietlKOrektyWszystkichWag(korektyWagCalejSieci);
        }

        public void nadpiszWagi(Siec siec, List<List<double>> korektyWagCalejSieci)
        {
            korektyWagCalejSieci.Reverse();
            Console.WriteLine("\n------------------------------------------------------------------------\n");
            int indeksWarstwy = 0;
            foreach (var warstwa in siec.warstwy)
            {
                int indeksNeuronu = 0;

                foreach (var neuron in warstwa)
                {
                    foreach (var listaWagNeuronu in neuron.listaWag)
                    {
                        listaWagNeuronu.waga += korektyWagCalejSieci[indeksWarstwy][indeksNeuronu];
                        Console.WriteLine(listaWagNeuronu.waga);
                        indeksNeuronu++;
                    }
                }
                indeksWarstwy++;
            }
            korektyWagCalejSieci.Reverse();
        }

        private void wyswietlKOrektyWszystkichWag(List<List<double>> korektyWagCalejSieci)
        {
            korektyWagCalejSieci.Reverse();
            foreach (var listaWag in korektyWagCalejSieci)
            {
                foreach (var waga in listaWag)
                {
                    Console.WriteLine(waga + "\t");
                }
                Console.WriteLine();
            }
            korektyWagCalejSieci.Reverse();
        }

        private double iloscNeuronow()
        {
            int n = 0;
            for (int i = 0; i < siec.warstwy.Count; i++)
            {
                for (int j = 0; j < siec.warstwy[i].Count; j++)
                    n += 1;
            }
                return n;
        }
    }
}
