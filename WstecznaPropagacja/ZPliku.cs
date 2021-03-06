﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WstecznaPropagacja
{
    public partial class ZPliku : UserControl
    {
        public ZPliku()
        {
            InitializeComponent();
            this.parametrBetaBox.Text = "1";
        }
        string sciezkaPlikuZWagami = "";
        string sciezkaPlikuZprobkami = "";
        List<double[]> listaProbek = new List<double[]>();
        List<double> testWejscia = new List<double>();
        List<List<Waga>> listaWagZPliku = new List<List<Waga>>();
        List<List<double>> korektyWagCalejSieci;
        List<List<Neuron>> warstwy;
        static int[] strukturaSieci;
        Siec siec;

        private void wybierzPlikBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik z wagami";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) != ".txt")
                {
                    MessageBox.Show("Plik musi być w formacie txt");
                    return;
                }
                sciezkaPlikuZWagami = openFileDialog.FileName;
                this.sciezkaDoPlikuZWagamiBox.Text = sciezkaPlikuZWagami;
            }
        }

        private void zatwierdzBtn_Click(object sender, EventArgs e)
        {
            sciezkaPlikuZWagami = this.sciezkaDoPlikuZWagamiBox.Text;
            (listaWagZPliku, strukturaSieci) = OdczytZapis.wczytajWagi(@sciezkaPlikuZWagami);
            foreach (int i in strukturaSieci)
                Console.WriteLine(i);
            this.przeuczSiecBtn.Enabled = true;

            this.testPanel.Visible = true;
            //sciec do testowania po wczytaniu wag z pliku
            this.siec = new Siec(strukturaSieci, listaWagZPliku);
        }

        private void przeuczSiecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik z próbkami";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) != ".txt")
                {
                    MessageBox.Show("Plik musi być w formacie txt");
                    return;
                }
                sciezkaPlikuZprobkami = openFileDialog.FileName;                
            }
            if (sciezkaPlikuZprobkami == "")
                return;

            listaProbek = OdczytZapis.wczytajProbki(sciezkaPlikuZprobkami);

            foreach(var c in listaProbek)
            {
                foreach (var ef in c)
                    Console.Write(ef + " ");
                Console.WriteLine();
            }

            Siec siec = new Siec(strukturaSieci, listaWagZPliku);
            this.siec = siec;
            Propagacja propagacja = new Propagacja(siec);
            propagacja.parametrBeta = double.Parse(parametrBetaBox.Text);

            PrzeuczSiec.przeuczSiec(listaProbek, siec, propagacja, strukturaSieci[0]);
            warstwy = siec.warstwy;

            zapiszWagiBtn.Enabled = true;
            testPanel.Visible = true;
        }

        private void zapiszWagiBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "zapisz plik z wagami";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OdczytZapis.zapiszWagi(warstwy, @saveFileDialog.FileName);
            }
        }

        private void parametrBetaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;

            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8 && parametrBetaBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;

            if (wprowadzonaLiczba != 49 && wprowadzonaLiczba != 48 && wprowadzonaLiczba != 8)
            {
                e.Handled = true;
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                testWejscia.Add(double.Parse(textBox1.Text));
                aktualneWejscia();
            }

            if (testWejscia.Count == strukturaSieci[0])
            {
                testujBtn.Enabled = true;
                dodajBtn.Enabled = false;
            }

            textBox1.Text = "";
            textBox1.Focus();
        }

        private void aktualneWejscia()
        {
            string pom = "Wejscia: ";
            for (int i = 0; i < testWejscia.Count; i++)
            {
                if (i < testWejscia.Count - 1)
                    pom += (testWejscia[i] + ", ");
                else
                    pom += testWejscia[i];
            }
            label5.Text = pom;
        }

        private void testujBtn_Click(object sender, EventArgs e)
        {
            siec.wyliczWartoscWyjsciowaSieci(siec.warstwy, testWejscia.ToArray());
            List<double> wyjscia = siec.daneWyjsciowe();
            string pom = "Wyjscia: ";
            for (int i = 0; i < wyjscia.Count; i++)
            {
                if (i < wyjscia.Count - 1)
                    pom += (wyjscia[i] + ", ");
                else
                    pom += wyjscia[i];
            }
            wyjscieLbl.Text = pom;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            testWejscia.Clear();
            label5.Text = "Wejscia: ";
            dodajBtn.Enabled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               dodajBtn_Click(this, new EventArgs());
        }
    }
}
