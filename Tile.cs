using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Tile
    {
        private bool visited;
        private readonly string type;
        private Color clr;

        //0=start, 1=enemy1/potion1, 2=enemy2/potion2, 3=end
        public Tile(int a)
        {
            var rnd = RandomGenerator.Instance;
            if (a == 0)
            {
                visited = true;
                type = "start";
                clr = Color.Red;
            }
            else if (a < 3 && a>0)
            {
                clr = Color.Brown;
                visited = false;
                int x = rnd.GetRandom(1, 6);
                if (x < 4)
                    type = "enemy" + a.ToString();
                else if (x == 5 || x == 4)
                    type = "potion" + a.ToString();
            }
            else if (a == 3)
            {
                clr = Color.Brown;
                visited = false;
                type = "end";
            }
        }

        public string Type
        {
            get { return type; }
        }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        public Color Clr
        {
            get { return clr; }
            set { clr = value; }
        }
    }
}
