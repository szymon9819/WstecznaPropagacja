using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    static class OdczytZapis
    {
        static public (List<List<Waga>>, int[]) wczytajWagi(string sciazkaPliku)
        {
            string[] file = File.ReadAllLines(@sciazkaPliku);
            List<List<Waga>> listaWag = new List<List<Waga>>();
            string[] tmp;

            List<int> neuronyWDanejWarstwie = new List<int>();

            //ilosc danych wejsciowych
            if (file.Length != 0)
                neuronyWDanejWarstwie.Add(file[0].Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries).Length - 1);

            int x = 0;

            string test = "1,1";
            double wynikTestu;
            bool przecinek = double.TryParse(test, out wynikTestu);
            //petla po wierszach
            foreach (string row in file)
            {

                if (row == "")
                {
                    neuronyWDanejWarstwie.Add(x);
                    x = 0;
                    continue;
                }
                else if (row == file[file.Length - 1])
                {
                    x++;
                    neuronyWDanejWarstwie.Add(x);
                    x = 0;
                }
                else
                    x++;             

                tmp = row.Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                List<Waga> tmp1 = new List<Waga>();
                for (int i = 0; i < tmp.Length; i++)
                {
                    //zmiana . na ,
                    if (przecinek)
                        tmp[i] = tmp[i].Replace(".", ",");
                    else
                        tmp[i] = tmp[i].Replace(",", ".");
                    tmp1.Add(new Waga(double.Parse(tmp[i])));
                }
                listaWag.Add(tmp1);
            }
            return (listaWag, neuronyWDanejWarstwie.ToArray());
        }

        static public List<double[]> wczytajProbki(string sciazkaPliku)
        {
            List<double[]> wczytaneProbki = new List<double[]>();
            string[] file = File.ReadAllLines(@sciazkaPliku);
           
            foreach (var row in file)
            {
                var tmp= row.Trim().Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                List<double> pom = new List<double>();
                foreach(var element in tmp)
                {                   
                    pom.Add(double.Parse(element));
                }
                wczytaneProbki.Add(pom.ToArray());
            }
            return wczytaneProbki;
        }

        static public void zapiszWagi(List<List<Neuron>> lista, @String nazwaPliku)
        {
            FileStream plik = File.Open(nazwaPliku, FileMode.Create);
            using (StreamWriter streamW = new StreamWriter(plik))
            {
                foreach (var row in lista)
                {
                    foreach (var neuron in row)
                    {
                        for (int i = 0; i < neuron.listaWag.Count; i++)
                        {
                            if (i < neuron.listaWag.Count - 1)
                                streamW.Write(neuron.listaWag[i].ToString() + "\t");
                            else
                                streamW.Write(neuron.listaWag[i].ToString() + "\n");
                        }
                    }
                    //brak nowej lini po zapisaniu ostatniego wiersza
                    if (row != lista[lista.Count - 1])
                        streamW.Write("\n");
                }
            }
        }
    }
}
