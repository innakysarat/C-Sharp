using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Overwatch1
{
    public class Hero
    {
       // public const string infinityS = "infinity";
        public double[] Features()
        {
            return new double[] {DamagePerSecond,
                HeadshotDPS, SingleShot, Life };
        }

        public string Heroes { get; set; }
        public double DamagePerSecond { get; set; }
        public double HeadshotDPS { get; set; }
        public double SingleShot { get; set; }
        public double Life { get; set; }
        public string Reload { get; set; }
        public Hero(string Heroes, double Damage_per_second, double Headshot_DPS, double Single_shot, double Life, string Reload)
        {
            this.Heroes = Heroes;
            this.DamagePerSecond = Damage_per_second;
            this.HeadshotDPS = Headshot_DPS;
            this.SingleShot = Single_shot;
            this.Life = Life;
            this.Reload = Reload;
        }
        public Hero(XDocument doc, int playerNumber)
        {
            Heroes = GetElement(doc, "hero", playerNumber).Attribute("name").Value;
            DamagePerSecond = double.Parse(GetElement(doc, "DamagePerSecond", playerNumber).Value);
            HeadshotDPS = double.Parse(GetElement(doc, "HeadshotDPS", playerNumber).Value);
            SingleShot = double.Parse(GetElement(doc, "SingleShot", playerNumber).Value);
            Life = double.Parse(GetElement(doc, "Life", playerNumber).Value.Replace(".", ","));
            Reload = GetElement(doc, "Reload", playerNumber).Value;

        }

        private XElement GetElement(XDocument doc, string elementName, int cnt)
        {
            int i = 0;
            foreach (XNode node in doc.DescendantNodes())
            {
                if (node is XElement)
                {
                    XElement element = (XElement)node;
                    if (element.Name.LocalName.Equals(elementName))
                        if (cnt == i)
                        {
                            return element;
                        }
                        else
                        {
                            i++;

                        }
                }
            }
            return null;
        }

    }

}

