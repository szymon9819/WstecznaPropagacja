using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    static class AktywacjaNeuronu
    {
        private static double parametrBeta=1;
        public static double funkcjaAktywacjiNeuronu(Neuron neuron)
        {
            return 1 / (1 + Math.Exp(-parametrBeta*neuron.suma));
        }
        public static double funkcjaAktywacjiNeuronu(double suma)
        {
            return 1 / (1 + Math.Exp(-parametrBeta * suma));
        }
    }
}
