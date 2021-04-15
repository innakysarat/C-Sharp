using CSVParser;
using Overwatch1;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;

namespace Overwatch_1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            pickHero1.Heroes = new BindingList<Hero>(ReadHeroes());
            try
            {
                // проверка на наличие незавершенной игры 
                string path = "../../LastSavedGame.xml";
                if (File.Exists(path))
                {
                    var result = MessageBox.Show("There's the unfinished game. Do you want to continue it?", "Saved game", MessageBoxButtons.YesNo);
                    // запуск незавершенной игры
                    if (result == DialogResult.Yes)
                    {
                        XDocument document = XDocument.Load(path);
                        var hero = new Hero(document, 0);

                        var enemy = new Hero(document, 1);
                        game1.Hero1 = hero;
                        game1.Hero2 = enemy;
                        pickHero1.Visible = false;
                        game1.Visible = true;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Cannot load the game");
            }

        }

        /// <summary>
        /// Метод считывает героев из excel 
        /// </summary>
        /// <returns> Массив героев из экселя </returns>
        public static Hero[] ReadHeroes()
        {

            BindingList<Hero> bl = new BindingList<Hero>();
            string[][] heroes1 = CsvReader.ReadAllLines("../../../Overwatch.csv");
            for (int i = 1; i < heroes1.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (heroes1[i][j] == "")
                        heroes1[i][j] = "0";
                    if (heroes1[i][j] == "infinity")
                        heroes1[i][j] = ((char)8734).ToString();
                }
                Hero hero = new Hero(heroes1[i][0], double.Parse(heroes1[i][1], CultureInfo.InvariantCulture), double.Parse(heroes1[i][2], CultureInfo.InvariantCulture), double.Parse(heroes1[i][3], CultureInfo.InvariantCulture), double.Parse(heroes1[i][4], CultureInfo.InvariantCulture), heroes1[i][5]);
                bl.Add(hero);

            }


            return bl.ToArray();

        }
        /// <summary>
        /// Метод запускает процесс игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickHero1_OnPick(object sender, PickEventArgs e)
        {
            game1.Hero1 = e.PickHero;
            game1.Hero2 = Users.Enemy;
            pickHero1.Visible = false;
            game1.Visible = true;

        }
        /// <summary>
        /// Метод сохраняет данные о ходе в xml-файл
        /// </summary>
        /// <param name="heroesOfGame"> Игроки </param>
        public static void SaveGame(User[] heroesOfGame)
        {
            try
            {
                string property = "";
                XDocument xSaveGame = new XDocument();
                XElement xGame = new XElement("game");
                foreach (var hero in heroesOfGame)
                {
                    XElement xhero = new XElement("hero");
                    XAttribute xheroName = new XAttribute("name", hero.Heroes);
                    xhero.Add(xheroName);
                    XElement xheroesOfGame = new XElement("Heroes");
                    for (int i = 0; i < hero.FeaturesUser().Length; i++)
                    {
                        if (i == 0) property = "DamagePerSecond";
                        if (i == 1) property = "HeadshotDPS";
                        if (i == 2) property = "SingleShot";
                        if (i == 3) property = "Life";

                        XElement xheroProperty = new XElement(property, hero.FeaturesUser()[i]);
                        xhero.Add(xheroProperty);
                    }
                    XElement xheroReload = new XElement("Reload", hero.Reload);
                    xhero.Add(xheroReload);
                    xheroesOfGame.Add(xhero);
                    xGame.Add(xheroesOfGame);
                }
                xSaveGame.Add(xGame);
                xSaveGame.Save("../../LastSavedGame.xml");

            }
            catch (Exception)
            {
                MessageBox.Show("There're problems with saving file");
            }
        }



        private void game1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

