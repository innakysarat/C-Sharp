using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch_1
{
   public class AttackedEventArgs: EventArgs
    {
        public bool Aim { get; }
        public AttackedEventArgs(bool aim)
        {
            Aim = aim;
        }


    }
}
