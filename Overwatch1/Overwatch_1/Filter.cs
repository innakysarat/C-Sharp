using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Overwatch1;

namespace Overwatch_1
{
    public partial class Filter : UserControl
    {
        //    //public BindingList<Hero> Heroes
        //    //{
        //    //    get => dataGridView1.DataSource as BindingList<Hero>;
        //    //    set => dataGridView1.DataSource = value;
        //    //}
        DataGridView dataGridView1 = null;

        public Filter()
        {
            InitializeComponent();
        }

        private void pickHero1_Load(object sender, EventArgs e)
        {

        }

        private void ValueFilter(double from, double to)
        {
            var heroesForFilter = Form1.ReadHeroes();
            int index = comboFilter.SelectedIndex - 1;
            var filterHeroes = heroesForFilter.Where(hero => hero.Features()[index] >= from)
                .Where(hero => hero.Features()[index] <= to).OrderBy(hero => hero.Features()[index]).ToList();
            dataGridView1.DataSource = new BindingList<Hero>(filterHeroes);
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilter.SelectedItem.ToString() == "Heroes")
            {
                comboFrom.DataSource = new BindingList<string>() { "A" };
                comboFrom.SelectedIndex = 0;
                comboTo.DataSource = new BindingList<string>() { "Z" };
                comboTo.SelectedIndex = 0;
            }
            else
            {
                comboFrom.DataSource = new BindingList<string>() { "0" };
                comboFrom.SelectedIndex = 0;
                comboTo.DataSource = new BindingList<string>() { ((char)8734).ToString() };
                comboTo.SelectedIndex = 0;
            }
        }

        private void comboFrom_TextUpdate(object sender, EventArgs e)
        {
            if (comboFilter.SelectedValue.ToString() != "Heroes")
            {
                if (((sender as ComboBox)?.Text != ((char)8734).ToString())
                    && (!double.TryParse((sender as ComboBox)?.Text + "0", out _)))
                {
                    comboFrom.DataSource = new BindingList<string>() { "0" };
                    comboFrom.SelectedIndex = 0;
                    comboTo.DataSource = new BindingList<string>() { ((char)8734).ToString() };
                    comboTo.SelectedIndex = 0;

                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var heroesForFilter = Form1.ReadHeroes();
            var from = comboFrom.Text ?? "";
            var to = comboTo.Text ?? "";

            double valueFrom;
            double valueTo;
            if (comboFilter.SelectedValue.ToString() == "Heroes")
            {
                var newHeroes = heroesForFilter.Where(h => string.CompareOrdinal(h.Heroes.ToLower(), from.ToLower()) >= 0)
                    .Where(h => string.CompareOrdinal(h.Heroes.ToLower(), to.ToLower()) <= 0).ToList();
                dataGridView1.DataSource = new BindingList<Hero>(newHeroes);
            }
            else
            {
                if (((double.TryParse(from, out valueFrom)) || (from == ((char)8734).ToString()))
                    && ((double.TryParse(to, out valueTo)) || (to == ((char)8734).ToString())))
                {
                    if (from == ((char)8734).ToString()) valueFrom = double.PositiveInfinity;
                    if (to == ((char)8734).ToString()) valueTo = double.PositiveInfinity;
                    ValueFilter(valueFrom, valueTo);
                }
                else if (((double.TryParse(from + "0", out valueFrom)) || (from == ((char)8734).ToString()))
                  && ((double.TryParse(to + "0", out valueTo)) || (to == ((char)8734).ToString())))
                {
                    if (from == ((char)8734).ToString()) valueFrom = double.PositiveInfinity;
                    if (to == ((char)8734).ToString()) valueTo = double.PositiveInfinity;
                    ValueFilter(valueFrom, valueTo);
                }
                else
                {
                    MessageBox.Show($"Границы должны быть вещественными числами или \"{((char)8734).ToString()}\"");
                }
            }
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            comboFilter.DataSource = new string[] { "Heroes", "Damage per second", "Headshot DPS", "Single shot", "Life", "Reload" };
            dataGridView1 = PickHero.dataGridView;
        }
    }
}
