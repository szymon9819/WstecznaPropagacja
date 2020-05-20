using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WstecznaPropagacja
{
    class Siec
    {
        public Siec(int[] neuronyWDanejWarstwie)
        {
            generujNeurony(neuronyWDanejWarstwie);
            wyswietl(warstwy);
            this.iloscWejsc = neuronyWDanejWarstwie[0];
            generujWagi(neuronyWDanejWarstwie);
        }

        public Siec(int[] neuronyWDanejWarstwie, List<List<Waga>> listaWag)
        {
            generujNeurony(neuronyWDanejWarstwie);
            wczytajWagi(listaWag, neuronyWDanejWarstwie);
            this.iloscWejsc = neuronyWDanejWarstwie[0];
            wyswietl(warstwy);
        }

        public List<List<Neuron>> warstwy = new List<List<Neuron>>();
        int iloscWejsc;

        private void wczytajWagi(List<List<Waga>> listaWag, int[] neuronyWDanejWarstwie)
        {
            int x = 0;
            for (int i = 0; i < warstwy.Count; i++)
            {
                for (int j = 0; j < warstwy[i].Count; j++)
                {
                    warstwy[i][j].listaWag = listaWag[x];
                    x++;
                }
            }
        }


        private void generujNeurony(int[] neuronyWDanejWarstwie)
        {
            for (int i = 1; i < neuronyWDanejWarstwie.Length; i++)
            {
                List<Neuron> listaNeuronow = new List<Neuron>();
                for (int j = 0; j < neuronyWDanejWarstwie[i]; j++)
                {
                    listaNeuronow.Add(new Neuron());
                }
                warstwy.Add(listaNeuronow);
            }
        }

        private void generujWagi(int[] neuronyWDanejWarstwie)
        {
            Random random = new Random();
            for (int i = 0; i < warstwy.Count; i++)
            {
                for (int j = 0; j < warstwy[i].Count; j++)
                {
                    if (i == 0)
                    {
                        for (int k = 0; k < neuronyWDanejWarstwie[0]; k++)
                            warstwy[i][j].listaWag.Add(new Waga(Math.Round(random.NextDouble()*2-1, 1)));
                    }
                    else
                    {
                        for (int k = 0; k < warstwy[i - 1].Count; k++)
                            warstwy[i][j].listaWag.Add(new Waga(Math.Round(random.NextDouble()*2-1, 1)));
                    }
                }
            }
        }

        public void wyliczWartoscWyjsciowaSieci(List<List<Neuron>> warstwy, double[] wejscia)
        {
            wejscia = wejscia.Take(iloscWejsc).ToArray();
            foreach (var tmp in warstwy.First())
            {
                tmp.suma += (tmp.listaWag[0].waga * tmp.dodatkoweWejscie);
                for (int i = 0; i < wejscia.Length; i++)
                {
                    //od i+1 bo wejscie dodatkwoe wejscie jest rozpatrywane przed forem
                    tmp.suma += (tmp.listaWag[i+1].waga * wejscia[i]);                    
                }
                tmp.wyjscie_ = AktywacjaNeuronu.funkcjaAktywacjiNeuronu(tmp.suma);
            }

            for(int k=1;k<warstwy.Count;k++)
            {
                for(int j=0;j< warstwy[k].Count;j++)
                {
                    warstwy[k][j].suma += (warstwy[k][j].listaWag[0].waga * warstwy[k][j].dodatkoweWejscie);
                    for (int i = 0; i < warstwy[k-1].Count; i++)
                    {
                        //od i+1 bo wejscie dodatkwoe wejscie jest rozpatrywane przed forem
                        warstwy[k][j].suma += (warstwy[k][j].listaWag[i + 1].waga * AktywacjaNeuronu.funkcjaAktywacjiNeuronu(warstwy[k - 1][i]));
                    }
                    warstwy[k][j].wyjscie_ = AktywacjaNeuronu.funkcjaAktywacjiNeuronu(warstwy[k][j].suma);
                }
            }
            zerujSume();
        }

        private void zerujSume()
        {
            foreach(var warstwa in warstwy)
            {
                foreach (var neuron in warstwa)
                    neuron.suma = 0;
            }
        }

        public List<double> daneWyjsciowe()
        {
            List<double> daneWyjsciowe = new List<double>();

            for(int i = 0; i < warstwy[warstwy.Count - 1].Count; i++)
            {
                daneWyjsciowe.Add(warstwy[warstwy.Count - 1][i].wyjscie_);
            }

            return daneWyjsciowe;
        }

        public void wyswietlListeNeuronowZWagami()
        {
            foreach (var x in warstwy)
            {
                {
                    foreach (var c in x)
                    {
                        c.wyswietlWagi();
                    }
                    Console.WriteLine();
                }

            }
        }

        public void wyswietl(List<List<Neuron>> lista)
        {
            foreach (var tmp in lista)
            {
                foreach (var n in tmp)
                    Console.Write(n + "\t");
                Console.WriteLine();
            }
        }
    }
}
