using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class megaCasino : System.Web.UI.Page
    {
        // setUser() gives user $100 to start betting with
        // isGameSet() checks that the images are all bars and the user has money.
        //  placeBet() accepts users bet
        // spinReel()  changes all 3 bar images to 3 new random images
        // finsihBet()  evaluates new images and determines how much if any 
        // the user has won. Displays users new balance
        Random randomImage = new Random();
        //create an array with all eleven image names 
        string[] images = new string[] {"Strawberry", "Lemon", "Bar", "Bell", "Cherry", "Clover",
                  "Diamond", "Horseshoe", "Orange", "Seven", "Plum"};

        protected void Page_Load(object sender, EventArgs e)
        {
            setGame();                                            
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            
            setUser();            
            spinReel();           
        } 

        public string placeBet(string pic1, string pic2, string pic3)
        {
            //1 Cherry = 1x your bet.
            //2 Cherries = 2x's your bet. 
            //3 Cherries = 4x's your bet.
            //3 - 7's = JACKPOT (100 x's your bet.)
            string prize = images[4]; 
            string[] gamble = new string[3] { pic1, pic2, pic3 };
            if(gamble[0] == prize || gamble[1] == prize ||  gamble[2] == prize)
            {
                return  "won";
            }
            else
            {
                return "Keep playing...";
            }
        }
        public void setUser()
        {
            int bet = 100;
            playersMoneyLabel.Text = bet.ToString();
            string user = userTextBox.Text;

            resultLabel.Text = "Hi " + user + " welcome to the Mega Casino. We've started you out with $100.";
            userTextBox.Visible = false;
            userNameLabel.Visible = false;
        }

        public string getRandomImage()
        {
            int newPic = 0;
            string newPicName = "";
            //pull out 1 random image name and put it in a variable
            newPic = randomImage.Next(11);
            // here is the new variable
            newPicName = images[newPic];
            return newPicName;
        }

        public void setGame()
        {
            Image1.ImageUrl = "~/mega/Images/" + images[2] + ".png";
            Image2.ImageUrl = "~/mega/Images/" + images[2] + ".png";
            Image3.ImageUrl = "~/mega/Images/" + images[2] + ".png";
        }

        public string[] spinReel()
        {
            string prize = "";

            string[] slotArray = new string[4];
            slotArray[0] = getRandomImage();
            slotArray[1] = getRandomImage();
            slotArray[2] = getRandomImage();



            Image1.ImageUrl = "~/mega/Images/" + slotArray[0] + ".png";
            Image2.ImageUrl = "~/mega/Images/" + slotArray[1] + ".png";
            Image3.ImageUrl = "~/mega/Images/" + slotArray[2] + ".png";
            
            return slotArray;
        }


    }
}