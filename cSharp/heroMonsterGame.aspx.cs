using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HeroMonster;

namespace cSharp
{
    public partial class heroMonsterGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 100;
            int monsterHealth = 100;
        
            displayBattleHeader();
            monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                displayRoundHeader();
                heroHealth = performAttack(heroHealth, 20, "Monster", "Hero");
                monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");
            }

            displayResults(heroHealth, monsterHealth);
        }

        private int performAttack(int defenderHealth,int attackerDamageMax,string attackerName,string defenderName)
        {
            Random random = new Random();
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);

            return defenderHealth;
        }

        private void displayBattleHeader()
        {
            resultLabel.Text += "<h3>Battle betwee the Hero (you) and the Monster (bad guy)</h3>";
        }

        private void displayRoundHeader()
        {
            resultLabel.Text += "</hr><p>Round begins.....</p>";
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if(defenderHealth >= 0)
            {
                resultLabel.Text += string.Format(
                    "</br>{0} attack {1} and vanquishes {2}", attackerName, defenderName, defenderName
                    );
            }
            else
            {
                resultLabel.Text += string.Format(
                    "</br>{0} attacks {1} leaving {2} with {3} health.", attackerName, defenderName, defenderName, defenderHealth
                    );
            }
        }

        private void displayResults(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3>Monster wins...</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>Hero wins...</h3>";
            else
                resultLabel.Text += "<h3>You're both losers</h3>";
            
        }
    }    
}