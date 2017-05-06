using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
    {
        public string name { get; set; }
        public int health { get; set; }
        public int damageMaximum { get; set; }
        public  bool attackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.damageMaximum;
            return dice.roll();
        }

        public void Defend(int damage)
        {
            this.health -= damage;
        }
    }

    public class Dice
    {
        public int Sides { get; set; }
        Random random = new Random();

        public int roll()
        {
            return random.Next(this.Sides);
        }
    }
}
