﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text12
{
    class Animal
    {
        private string name;
        private int age;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
