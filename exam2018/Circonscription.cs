using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2018
{
    internal class Circonscription
    {
        public string Nom;
        public int Population;
        public Circonscription(string nom, int population)
        {
            Nom = nom;
            Population = population;
        }
        public override string ToString()
        {
            return Nom+" ("+Population.ToString()+"habitants)";
        }
    }
}
