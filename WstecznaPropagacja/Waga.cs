using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    class Waga
    {
        public Waga()
        {}

        public Waga(double waga)
        {     
            this.waga = waga;
        }
        public double waga;

        public override string ToString() {
            return waga.ToString();
        }
    }
}
