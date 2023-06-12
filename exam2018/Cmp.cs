using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2018
{
    internal class Cmp:IComparer<Circonscription>
    {
        public int Compare(Circonscription a,Circonscription b)
        {
            if(a.Population<b.Population)
            
                return -1;
            
            else if(a.Population>b.Population)
            
                return 1;
            
            else

                return 0;
           
        }
    }
}
