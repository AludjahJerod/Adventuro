using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public abstract class Enemy : ICloneable
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int HP { get; set; }
        public int Xp { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
