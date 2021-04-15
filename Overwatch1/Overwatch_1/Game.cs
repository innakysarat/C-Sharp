using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Overwatch1;

namespace Overwatch_1
{

    public partial class Game : UserControl
    {

        double damage;
        int randomAttack;
        int countDamage;
        int countHeadshotDamage;
        string str;
        public static Random rnd = new Random();
        private Hero hero1;
        private Hero hero2;
        // свойство присваивает первому игроку значения из таблицы
        public Hero Hero1
        {
            get => hero1;
            set
            {
                hero1 = value;
                if (hero1 != null)
                {
                    user1.Life = hero1.Life;
                    user1.Heroes = hero1.Heroes;
                    user1.Damage_per_second = hero1.DamagePerSecond;
                    user1.Reload = hero1.Reload;
                    user1.Single_shot = hero1.SingleShot;
                    user1.Headshot_DPS = hero1.HeadshotDPS;
                }

            }
        }
        // cвойство присвает второму игроку значения из таблицы
        public Hero Hero2
        {
            get => hero2;
            set
            {
                hero2 = value;
                if (hero2 != null)
                {
                    user2.Life = hero2.Life;
                    user2.Heroes = hero2.Heroes;
                    user2.Damage_per_second = hero2.DamagePerSecond;
                    user2.Reload = hero2.Reload;
                    user2.Single_shot = hero2.SingleShot;
                    user2.Headshot_DPS = hero2.HeadshotDPS;
                }

            }
        }



        public Game()
        {
            InitializeComponent();
        }
        // реализация игры
        private void attackBuuton1_Attacked(object sender, AttackedEventArgs e)
        {
            User[] heroesOfGames = new User[2] { user1, user2 };
            bool aim = e.Aim;
            Arrow.LeftDirection = false;

            if (aim)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (rnd.NextDouble() < 0.3)
                    {
                        if (rnd.NextDouble() < 0.2)
                        {
                            damage = user1.Headshot_DPS;
                            user2.Life -= damage;
                            countHeadshotDamage++;
                        }
                        else
                        {
                            damage = 0.4 * user1.Damage_per_second;
                            user2.Life -= damage;
                            countDamage++;
                        }
                    }
                }
                damage = countDamage * 0.4 * user1.Damage_per_second + countHeadshotDamage * user1.Headshot_DPS;
                str = "by rifle attack";
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (rnd.NextDouble() < 0.7)
                    {
                        damage = 0.1 * user1.Damage_per_second;
                        user2.Life -= damage;
                        countDamage++;
                    }
                }
                damage = countDamage * 0.1 * user1.Damage_per_second;
                str = "by common attack";
            }
            // реализация повторного решения
            if (user2.Life <= 0)
            {
                File.Delete("../../LastSavedGame.xml");
                MessageBox.Show("Computer died. You won!");
                var dialogResultEnd = MessageBox.Show("Do you want to restart a game?", "restart",
                                                        MessageBoxButtons.YesNo);
                switch (dialogResultEnd)
                {
                    case DialogResult.Yes:
                        File.Delete("../../LastSavedGame.xml");
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        File.Delete("../../LastSavedGame.xml");
                        Application.Exit();
                        break;
                }
                //btnRestart.Visible = true;

            }

            else
            {
                MessageBox.Show($"User {user1.Heroes} damaged computer with {damage} " + str + Environment.NewLine +
              $"{user1.Heroes}: " +
              $"Life: {user1.Life}" + Environment.NewLine +
              $"{user2.Heroes}: " +
              $"Life: {user2.Life}");
                Form1.SaveGame(heroesOfGames);
            }

            damage = 0;
            countDamage = 0;
            countHeadshotDamage = 0;
            Arrow.LeftDirection = true;
            randomAttack = rnd.Next();
            if (randomAttack == 0)
            {
                for (int i = 0; i < 3; i++)
                {

                    if (rnd.NextDouble() < 0.3)
                    {
                        if (rnd.NextDouble() < 0.2)
                        {
                            damage = user2.Headshot_DPS;
                            user1.Life -= damage;
                            countHeadshotDamage++;
                        }
                        else
                        {
                            damage = 0.4 * user2.Damage_per_second;
                            user1.Life -= damage;
                            countDamage++;
                        }
                    }
                }
                damage = countDamage * 0.4 * user2.Damage_per_second + countHeadshotDamage * user2.Headshot_DPS;
                str = "by rifle attack";

            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (rnd.NextDouble() < 0.7)
                    {
                        damage = 0.1 * user2.Damage_per_second;
                        user1.Life -= damage;
                        countDamage++;
                    }
                }
                damage = countDamage * 0.1 * user2.Damage_per_second;
                str = "by common attack";
            }
            if (user1.Life <= 0)
            {
                File.Delete("../../LastSavedGame.xml");
                MessageBox.Show("You lose! Computer won.");
                // реализация повторного решения
                var dialogResultEnd = MessageBox.Show("Do you want to restart a game?", "restart",
                                                           MessageBoxButtons.YesNo);

                switch (dialogResultEnd)
                {
                    case DialogResult.Yes:
                        File.Delete("../../LastSavedGame.xml");
                        Application.Restart();
                        break;
                    case DialogResult.No:
                        File.Delete("../../LastSavedGame.xml");
                        Application.Exit();
                        break;
                }
                // btnRestart.Visible = true;
            }
            else
            {
                if (user2.Life > 0)
                {
                    MessageBox.Show($"Computer damaged user {user1.Heroes} with {damage} " + str + Environment.NewLine + $"{user1.Heroes}: " +
                    $"Life: {user1.Life}" + Environment.NewLine +
                    $"{user2.Heroes}: " +
                    $"Life: {user2.Life}");

                    Form1.SaveGame(heroesOfGames);
                }
                else
                {
                    Application.Exit();
                }
            }

            damage = 0;
            countHeadshotDamage = 0;
            countDamage = 0;
        }


        private void arrow1_Load(object sender, EventArgs e)
        {
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }



        private void user2_Load(object sender, EventArgs e)
        {

        }

        //    private void btnRestart_Click_1(object sender, EventArgs e)
        //    {

        //        btnRestart.Visible = false;

        //        if ((user1.Life <= 0) || (user2.Life <= 0))
        //        {
        //            btnRestart.Visible = true;
        //            var dialogResultEnd = MessageBox.Show("Do you want to restart a game?", "restart",
        //                                                        MessageBoxButtons.YesNo);
        //            switch (dialogResultEnd)
        //            {
        //                case DialogResult.Yes:
        //                    File.Delete("../../LastSavedGame.xml");
        //                    Application.Restart();
        //                    break;
        //                case DialogResult.No:
        //                    File.Delete("../../LastSavedGame.xml");
        //                    Application.Exit();
        //                    break;
        //            }
        //        }
        //    }
        //}
    }
}
