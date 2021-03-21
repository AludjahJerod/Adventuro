using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class OffensiveStance : IPlayerStance
    {
        public string Action(Enemy enemy,Player p)
        {
            enemy.HP -= p.Attack;
            string response = "You attacked! The " + enemy.Name + " lost " + p.Attack.ToString() + " HP\n";
            return response;
        }
    }
}
