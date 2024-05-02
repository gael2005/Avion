using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionLibrary
{
    public class Section
    {
        private Siège[] _sièges;

        public Section(Siège[] sièges)
        {
            Sièges = sièges;
        }

        public Siège[] Sièges 
        { 
            get => _sièges; 
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value) + "ne peut être null");
                _sièges = value;
            }
        }
    }
}
