using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overwatch1;

namespace Overwatch_1
{
    public class PickEventArgs : EventArgs
    {
        public Hero PickHero { get; }
        public PickEventArgs(Hero pickHero)
        {
            PickHero = pickHero;
        }
    }

}
