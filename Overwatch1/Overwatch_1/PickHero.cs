using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSVParser;
using Overwatch1;
using System.Globalization;
using System.Windows.Forms;

namespace Overwatch_1
{

    public partial class PickHero : UserControl
    {
        static Random rnd = new Random();
        public static DataGridView dataGridView;

        public BindingList<Hero> Heroes
        {
            get => dataGridView1.DataSource as BindingList<Hero>;
            set => dataGridView1.DataSource = value;
        }

        public PickHero()
        {
            InitializeComponent();
            dataGridView = dataGridView1;
        }
        public event EventHandler<PickEventArgs> OnPick;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show(e.Exception.Message, "Error");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sender is DataGridView data)
            {
                var name = (string)(data.Rows[e.RowIndex].Cells["Heroes"].Value);
                var pickHero = Heroes.First(hero => hero.Heroes == name);
               
                int random;
                do
                {
                    random = rnd.Next(0, data.Rows.Count);
                } while (random == e.RowIndex);

               
                var nameComputer = (string)(data.Rows[random].Cells["Heroes"].Value);
                var computerHero = Heroes.First(hero => hero.Heroes == nameComputer);

                Users.Enemy = computerHero;
                OnPick?.Invoke(this, new PickEventArgs(pickHero));
                string text = $"Выбранный юнит: {pickHero.Heroes}";
                string text2 = $"Юнит компьютера: {computerHero.Heroes}";
                MessageBox.Show(text);
                MessageBox.Show(text2);

            }
        }

        
    }
}
