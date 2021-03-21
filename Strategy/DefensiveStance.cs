using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class DefensiveStance:IPlayerStance
    {
        public string Action(Enemy enemy, Player p)
        {
            int at = enemy.Attack;
            enemy.Attack -= p.Defence;
            if (enemy.Attack < 0)
                enemy.Attack = 0;
            string response = "You parried with your shield! The " + enemy.Name + " attack was reduced by " + (at-enemy.Attack).ToString()+"\n";
            return response;
        }
    }
}
