using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public interface IPlayerStance
    {
        string Action(Enemy enemy,Player p);
    }
}
