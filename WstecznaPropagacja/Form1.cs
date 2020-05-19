using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            zPliku1.Hide();
            wlasnegoSchematu1.Hide();          
        }

        private void menuBtn1_Click(object sender, EventArgs e)
        {
            wlasnegoSchematu1.Hide();
            zPliku1.Show();
            zPliku1.BringToFront();
        }

        private void menuBtn2_Click(object sender, EventArgs e)
        {            
            zPliku1.Hide();
            wlasnegoSchematu1.Show();
            wlasnegoSchematu1.BringToFront();
        }
    }
}
