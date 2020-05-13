using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstecznaPropagacja
{
    static class WyznaczListeDoStworzeniaWarstwSieciZPliku
    {
        public static int[] lista(List<List<Waga>> listaWagZPliku)
        {
            List<int> neuronyWDanejWarstwie = new List<int>();
            Console.WriteLine("count listawagf: "+listaWagZPliku.Count);

            if(listaWagZPliku.Count!= 0)
                neuronyWDanejWarstwie.Add(listaWagZPliku[0].Count - 1);

            foreach(var x in listaWagZPliku)
            {
                Console.WriteLine("lllllllllllllllll: " + (x.Count-1));
                neuronyWDanejWarstwie.Add(x.Count - 1);
            }

            foreach (var x in neuronyWDanejWarstwie)
                Console.WriteLine("klkl: " + x);

            return neuronyWDanejWarstwie.ToArray();
        }
    }
}
