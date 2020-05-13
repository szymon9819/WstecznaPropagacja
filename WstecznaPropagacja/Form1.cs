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


        List<List<Waga>> listaWagZPliku = new List<List<Waga>>();
        List<List<double>> korektyWagCalejSieci;
        static int[] pom = { 2, 2 , 2, 1 };
        private void Form1_Load(object sender, EventArgs e)
        {
            (listaWagZPliku, pom) = OdczytZapis.wczytajWagi(@"wagiTestowe.txt");

            foreach (int i in pom)
                Console.WriteLine(i);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siec siec = new Siec(pom, listaWagZPliku);
            //Siec siec = new Siec(pom);
            Console.WriteLine("Lista wag: ");
            foreach (var c in listaWagZPliku)
            {
                foreach (var n in c)
                    Console.Write(n + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------");

            //OdczytZapis.zapiszWagi(siec.warstwy, @"wagi.txt");
            OdczytZapis.zapiszWagi(siec.warstwy, @"wagi_Prezentacja.txt");
            siec.wyswietlListeNeuronowZWagami();

            Console.WriteLine("-----------------------------------------------");
            siec.wyliczWartoscWyjsciowaSieci(siec.warstwy, wejscia);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Wyjscie sieci");
            foreach(var wyjscie in siec.daneWyjsciowe())            
                Console.WriteLine(wyjscie);           
            Console.WriteLine("-----------------------------------------------");
            Propagacja propagacja = new Propagacja(siec, wejscia);
            propagacja.wyliczBlad(oczekiwaneWyjscie);
            Console.WriteLine();
            korektyWagCalejSieci=propagacja.wyliczKoretke();
            propagacja.nadpiszWagi(siec, korektyWagCalejSieci);

           
        }

    }
}
