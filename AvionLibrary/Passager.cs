using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionLibrary
{
    public class Passager
    {
        private string _nom;
        private string _coordonnée;

        public Passager(string nom, string coordonnée)
        {
            Nom = nom;
            Coordonnée = coordonnée;
        }

        public string Nom 
        { 
            get => _nom; 
            set
            {
                if(value is null) throw new ArgumentNullException("le nom est null");
                if (value.Length == 0) throw new ArgumentException("le nom est vide");

                _nom = value;
            }
        }
        public string Coordonnée 
        { 
            get => _coordonnée; 
            set
            {
                if (value is null) throw new ArgumentNullException("le nom est null");
                if (value.Length == 0) throw new ArgumentException("le nom est vide");
                _coordonnée = value;
            }
        }
    }
}
