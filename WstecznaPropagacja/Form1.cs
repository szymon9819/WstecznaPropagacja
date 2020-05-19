using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WstecznaPropagacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] wejscia = { 1, 0 };
        double[] oczekiwaneWyjscie = { 1 };
        private static Random random = new Random();

        List<double[]> listaProbek = new List<double[]>();

        List<List<Waga>> listaWagZPliku = new List<List<Waga>>();
        List<List<double>> korektyWagCalejSieci;
        static int[] pom = { 2, 2, 2, 1 };
        private void Form1_Load(object sender, EventArgs e)
        {
           // (listaWagZPliku, pom) = OdczytZapis.wczytajWagi(@"wagi_Prezentacja.txt");
            (listaWagZPliku, pom) = OdczytZapis.wczytajWagi(@"wagiTestowe.txt");
            foreach (int i in pom)
                Console.WriteLine(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaProbek.Count == 0)
            {
                listaProbek.Add(new double[] { 1, 0, 1 });
                listaProbek.Add(new double[] { 1, 1, 0 });
                listaProbek.Add(new double[] { 1, 1, 0 });
                listaProbek.Add(new double[] { 0, 0, 0 });
            }
            Siec siec = new Siec(pom, listaWagZPliku);
            Propagacja propagacja = new Propagacja(siec, wejscia, 2);
            //Siec siec = new Siec(pom);
            Console.WriteLine("Lista wag: ");
            foreach (var c in listaWagZPliku)
            {
                foreach (var n in c)
                    Console.Write(n + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------");

            //przeuczSiec(listaProbek, siec, propagacja);


            // OdczytZapis.zapiszWagi(siec.warstwy, @"wagi.txt");
            //OdczytZapis.zapiszWagi(siec.warstwy, @"wagi_Prezentacja.txt");

            siec.wyswietlListeNeuronowZWagami();

            Console.WriteLine("-----------------------------------------------");
            siec.wyliczWartoscWyjsciowaSieci(siec.warstwy, listaProbek[0]);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Wyjscie sieci");
            foreach (var wyjscie in siec.daneWyjsciowe())
                Console.WriteLine(wyjscie);
            Console.WriteLine("-----------------------------------------------");
            propagacja.wyliczBlad(listaProbek[0].Skip(2).ToArray());
            Console.WriteLine();
            propagacja.wyliczKoretke();
            propagacja.nadpiszWagi(siec, propagacja.korektyWagCalejSieci);
            OdczytZapis.zapiszWagi(siec.warstwy, @"sssssss.txt");


        }

        private void przeuczSiec(List<double[]> listaProbek, Siec siec, Propagacja propagacja)
        {
            for (int j = 0; j < 20000; j++)
            {
                Console.WriteLine("EPOKA: " + (j + 1));
                for (int i = 0; i < listaProbek.Count; i++)
                {
                    Console.WriteLine("Proba w epoce: " + (i + 1));
                    siec.wyswietlListeNeuronowZWagami();

                    Console.WriteLine("-----------------------------------------------");
                    siec.wyliczWartoscWyjsciowaSieci(siec.warstwy, listaProbek[i]);

                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Wyjscie sieci");
                    foreach (var wyjscie in siec.daneWyjsciowe())
                        Console.WriteLine(wyjscie);
                    Console.WriteLine("-----------------------------------------------");
                    propagacja.wyliczBlad(listaProbek[i].Skip(2).ToArray());
                    Console.WriteLine();
                    propagacja.wyliczKoretke();
                }
            }
            propagacja.nadpiszWagi(siec, propagacja.korektyWagCalejSieci);
            propagacja.korektyWagCalejSieci.Clear();
        }

        private static void randomizujListe(List<double[]> lista)
        {
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
