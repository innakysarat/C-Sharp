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
    public partial class Arrow : UserControl
    {
        private static bool left;
        public static bool LeftDirection
        {
            get => left;
            set
            {
                left = value;
                Render();
            }

        }
        public Arrow()
        {
            InitializeComponent();
        }
        private static void Render()
        {
            lblArrow.Text = left ? "🠔" : " 🠖";
        }
    }
}
