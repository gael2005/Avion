﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionLibrary
{
    public class Ranger
    {
        private Section[] _sections;

        public Ranger(Section[] sections)
        {
            Sections = sections;
        }

        public Section[] Sections 
        { 
            get => _sections; 
            set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value) + "ne peut être null");
                _sections = value;
            }
        }
    }
}