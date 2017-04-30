using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class heroMonsterGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hero vs Monster game. Each round make each stike the other
            Random random = new Random();// create a random number
            // Start with 30 health points each
            int heroHealth = 100;
            int monsterHealth = 100;
            //empty string to hold results
            string result = "";

            monsterHealth -= random.Next(1, 100);
            // setup fight initiation, hero attacks first -- gets a free lick
            int round = 0;
            result += "<br /> Round: " + round;
            result += string.Format("<br />Hero attacks first, leaving the monster with {0} health.", monsterHealth);

            do // this can be a WHILE loop by reversing the "Do" and "While"
            {
                int heroDamage = random.Next(1, 10);
                int monsterDamage = random.Next(1, 20);

                monsterHealth -= heroDamage;
                heroHealth -= monsterDamage;

                result += "<br />Round: " + ++round;
                result += string.Format(
                    "<br />Hero causes {0} damage leaving the monster with {1} health."
                    , heroDamage, monsterHealth
                    );
                result += string.Format(
                    "<br />Monster causes {0} damage leaving the hero with {1}"
                    , monsterDamage, heroHealth);
            }
            while (heroHealth > 0 && monsterHealth > 0);


            if(heroHealth > 0 )
            {
                result += string.Format("<br />Hero wins");
            }
            else
            {
                result += string.Format("<br />Monster wins");
            }

            resultLabel.Text = result;

        }

        private void displayBattleHeader()
        {
            resultLabel.Text += "<h3>Battle betwee the Hero (you) and the Monster (bad guy)</h3>";
        }

        private void displayRoundHeader()
        {
            resultLabel.Text += "</hr><p>Round begins.....</p>";
        }
        private void discribeRound(string attackerName, string defenderName, int defenderHealth)
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