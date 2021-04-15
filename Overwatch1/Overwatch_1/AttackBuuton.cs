using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overwatch_1
{
    public partial class AttackBuuton : UserControl
    {
        public event EventHandler<AttackedEventArgs> Attacked;

        public AttackBuuton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attacked?.Invoke(this, new AttackedEventArgs(cbxAim.Checked));
        }


    }
}
