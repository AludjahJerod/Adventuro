using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        //Strategy
        private IPlayerStance stance;

        //stats
        int attack;
        int defence;
        int hp;
        int exp;
        int lvl;

        public Player()
        {
            attack = 4;
            defence = 3;
            hp = 30;
            exp = 0;
            lvl = 0;
        }

        public int Attack
        {
            get { return attack; }
        }

        public int Defence
        {
            get { return defence; }
        }

        public int HP
        {
            get { return hp; }
        }
        public string Action(Enemy e)
        {
            string a=stance.Action(e, this);
            return a;
        }

        public string GainExp(int xp)
        {
            exp += xp;
            string a = "You gained " + xp.ToString() + "XP!\n";
            if (exp > 50)
            {
                lvl++;
                a += "You leveled up!\n";
                attack += 1;
                defence += 1;
                hp += 1;
                GainExp(-50);
            }
            return a;
        }

        public void SetStrategy(IPlayerStance st)
        {
            stance = st;
        }

        public int Heal(int a)
        {
            int cur = hp;
            hp += a;
            if (hp > 30 + lvl)
                hp = 30 + lvl;
            return hp - cur;
        }

        public int TakeDamage(int d)
        {
            int dmg = d - defence;
            if (dmg < 0)
                dmg = 0;
            else
                hp -= dmg;
            return dmg;
        }
    }
}
