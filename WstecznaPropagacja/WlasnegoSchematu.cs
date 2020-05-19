using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WstecznaPropagacja
{
    public partial class WlasnegoSchematu : UserControl
    {
        public WlasnegoSchematu()
        {
            InitializeComponent();
        }

        private void WlasnegoSchematu_Load(object sender, EventArgs e)
        {
        }
        List<int> strukturaSieci = new List<int>();
        List<double> testWejscia = new List<double>();
        Siec siec;

        private void utworzSiecBtn_Click(object sender, EventArgs e)
        {
            if (strukturaSieci.Count < 2)
            {
                MessageBox.Show("schemat sieci jest nieprawidłowy!!");
                return;
            }
            Siec siec = new Siec(strukturaSieci.ToArray());
            siec.wyswietlListeNeuronowZWagami();
            this.siec = siec;
            zapiszDoPlikuBtn.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wprowadzonaLiczba = e.KeyChar;
            if (!Char.IsDigit(wprowadzonaLiczba) && wprowadzonaLiczba != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strukturaSieci.Add(int.Parse(textBox1.Text));
            aktualnaStrukturaSieci();
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            strukturaSieci.Clear();
            aktualnaStrukturaSieci();
        }

        private void aktualnaStrukturaSieci()
        {
            string pom = "aktualna struktura: ";
            for (int i = 0; i < strukturaSieci.Count; i++)
            {
                if (i < strukturaSieci.Count - 1)
                    pom += (strukturaSieci[i] + ", ");
                else
                    pom += strukturaSieci[i];
            }
            strukturaSieciLbl.Text = pom;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, new EventArgs());
        }

        private void zapiszDoPlikuBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "zapisz plik z wagami";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OdczytZapis.zapiszWagi(siec.warstwy, @saveFileDialog.FileName);
            }
        }
    }
}
