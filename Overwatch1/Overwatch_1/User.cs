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
    public partial class User : UserControl
    {
        private string heroes;
        private double headshot_DPS;
        private double damage_per_second;
        private double single_shot;
        private double life;
        private string reload;
        
        public double[] FeaturesUser()
        {
            return new double[] {Damage_per_second,
                Headshot_DPS, Single_shot, Life };
        }
        public string Heroes
        {
            get => heroes;
            set
            {
                heroes = value;
                Render();
            }
        }
        public double Damage_per_second
        {
            get => damage_per_second;
            set
            {
                damage_per_second = value;
                Render();
            }

        }
        public double Headshot_DPS
        {
            get => headshot_DPS;
            set
            {
                headshot_DPS = value;
                Render();
            }
        }
        public double Single_shot
        {
            get => single_shot;
            set
            {
                single_shot = value;
                Render();
            }
        }
        public double Life
        {
            get => life;
            set
            {
                life = value;
                Render();
            }
        }
        public string Reload
        {
            get => reload;
            set
            {
                reload = value;
                Render();
            }
        }
        public User()
        {
            InitializeComponent();
        }
        public void Render()
        {
            lblHeroes.Text = $"Name: {Heroes}";
            lblDPS.Text = $"DPS: {Damage_per_second}";
            lblHeadShot.Text = $"Headshot DPS: {Headshot_DPS}";
            lblLife.Text = $"Life: {Life}";
            lblReload.Text = $"Reload: {Reload}";
            lblSS.Text = $"Single shot: {Single_shot}";

        }
    }
}
