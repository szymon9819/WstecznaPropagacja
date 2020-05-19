using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    class Neuron
    {
        public Neuron()
        {
            dodatkoweWejscie = 1;
            listaWag.Add(wagaDodatkowegoWejscia);
        }
     
        public List<Waga> listaWag = new List<Waga>();
        public double suma;
        public double dodatkoweWejscie;
        public double wyjscie_;
        static Random random = new Random();

        Waga wagaDodatkowegoWejscia = new Waga((Math.Round(random.NextDouble(), 1)));        


        public void wyswietlWagi()
        {
            foreach (var c in listaWag)
                Console.Write(c + "\t");
            
            Console.Write("\tsuma neuronu: "+ suma+"\n");
        }
    }
}
