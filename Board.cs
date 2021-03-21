using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Board
    {
        public Tile[,] brd=new Tile[5,5];
        private int px;
        private int py;

        public Board()
        {
            px = 2;
            py = 0;
            var rnd = RandomGenerator.Instance;
            int x = rnd.GetRandom(0, 5);
            int y = rnd.GetRandom(3, 5);
            //0=start, 1=enemy1/potion1, 2=enemy2/potion2, 3=end
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 0)
                        brd[i, j] = new Tile(0);
                    else if (i == x && j == y)
                        brd[i, j] = new Tile(3);
                    else if (j < 3)
                        brd[i, j] = new Tile(1);
                    else
                        brd[i, j] = new Tile(2);
                }
            }
        }

        public Tile Move(int x,int y)
        {
            brd[px, py].Clr = Color.LightYellow;
            brd[px, py].Visited = true;
            px += x;
            py += y;
            brd[px, py].Clr = Color.Red;
            Tile t = brd[px, py];
            return t;
        }

        public int Px
        {
            get { return px; }
        }

        public int Py
        {
            get { return py; }
        }
    }
}
