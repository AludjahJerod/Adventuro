using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class InteractionFacade
    {
        private readonly Player player;
        private readonly Board board;

        private Enemy1 goblin;
        private Enemy2 orc;
        private Enemy enemy;
        private bool fight;
        private bool end;

        public InteractionFacade()
        {
            player = new Player();
            board = new Board();
            goblin = new Enemy1();
            orc = new Enemy2();
            fight = false;
        }

        public void SetStrategy(IPlayerStance stance)
        {
            player.SetStrategy(stance);
        }

        public string Move(int x, int y)
        {
            string txt=null;
            Tile tile =board.Move(x, y);
            txt = "You entered the room.\n";
            if (tile.Visited == false)
            {
                switch (tile.Type)
                {
                    case "enemy1":
                        fight = true;
                        enemy = goblin.Clone() as Enemy;
                        txt += "You encourntered a " + enemy.Name + ": HP=" + enemy.HP.ToString() + "/Atk=" + enemy.Attack.ToString()+"\n";
                        txt += Action(false);
                        break;
                    case "enemy2":
                        fight = true;
                        enemy = orc.Clone() as Enemy;
                        txt += "You encourntered a " + enemy.Name + ": HP=" + enemy.HP.ToString() + "/Atk=" + enemy.Attack.ToString()+"\n";
                        txt += Action(false);
                        break;
                    case "potion1":
                        int a = player.Heal(5);
                        txt += "A potion! You healed " + a.ToString() + "HP\n";
                        break;
                    case "potion2":
                        int b = player.Heal(10);
                        txt += "A potion! You healed " + b.ToString() + "HP\n";
                        break;
                    case "end":
                        txt = "You found the exit, you win!";
                        end = true;
                        break;
                }
            }
            return txt;
        }
        public string Action(bool i)
        {
            string txt;
            txt = player.Action(enemy);
            if (enemy.HP <= 0)
            {
                txt += "The " + enemy.Name + " died\n";
                txt += player.GainExp(enemy.Xp);
                fight = false;
            }
            else if(i==true)
            {
                int a = player.TakeDamage(enemy.Attack);
                txt+="The " + enemy.Name + " attacked and dealt "+a.ToString()+" damage\n";
                if (player.HP <= 0)
                {
                    txt += "You Died :( Game Over";
                    end = true;
                }
            }

            return txt;
        }
        public Board Board
        {
            get { return board; }
        }
        public Player Player
        {
            get { return player; }
        }
        public bool Fight
        {
            get { return fight; }
        }
        public bool End
        {
            get { return end; }
        }
    }
}
