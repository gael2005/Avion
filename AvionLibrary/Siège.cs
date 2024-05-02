using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionLibrary
{
    public class Siège
    {
        private Passager[] passagers;

        public Passager[] Passagers 
        { 
            get => passagers; 
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value) + "ne peut être null");
                passagers = value;
            }
        }
    }
}
