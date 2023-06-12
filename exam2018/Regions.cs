using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exam2018
{
    internal class Regions
    {
        private string nom;
        private List<Circonscription> circonscriptions;
        private string circonscriptionPrincipal;
        public string Nom //1- a
        {
            get { return nom; }
            set
            {
                if (Regex.IsMatch(value, "[^0-9]{4,}"))//said    sa3id   sad
                {
                    nom = value;
                }
                else
                {
                    throw new Exception("le nom ne respecte pas les règle de nomage");
                }
            }
        }
        public int NombreCirconscriptions()//3 
        { 
            return circonscriptions.Count;
        }
        public int Recherche(String nomCisconscription)//4
        {
            int i = -1,l=i;
            
            foreach(Circonscription c in circonscriptions)//c=circonscriptions[0]   i=0
            {

                i++;
                if(c.Nom == nomCisconscription)
                {
                    l = i;
                    break;
                        
                }
            }
            return l;
        }
        public void Ajouter(Circonscription circonscription)//5
        {
            if(Recherche(circonscription.Nom)==-1)//utiliser la reponse de la question 4
            {
                circonscriptions.Add(circonscription);
            }
        }
        public string CirconscriptionPrincipal//1-b
        {
            get
            {
                return circonscriptionPrincipal;
            }
            set
            {
                circonscriptionPrincipal = value;
                Ajouter(new Circonscription(value, 0));//utiliser la reponse de la question 5
                
            }
        }
        public Regions(string nom)//2-a
        {
            Nom = nom;
        }
        public Regions(string nom,string circonscriptionPrincipal):this(nom)//2-b utiliser la reponse de 2-a
        {
            CirconscriptionPrincipal = circonscriptionPrincipal;
        }
        public void SupprimerCirconscription(string nomCirconscription) //6
        {
            if(Recherche(nomCirconscription)!=-1)
            {
                circonscriptions.RemoveAt(Recherche(nomCirconscription));
                if(nomCirconscription==CirconscriptionPrincipal)
                {
                    CirconscriptionPrincipal = null;
                }
            }

        }
        public void TrierParPopulation()
        {
            circonscriptions.Sort(new Cmp());
        }
        public double PopulationTotal()
        {
            double i = 0;
            foreach(Circonscription c in circonscriptions)
            {
                i += c.Population;
            }
            return i;
        }

    }
}
