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

        Random randomImage = new Random();
        //create an array with all eleven image names 
        string[] images = new string[] {"Strawberry", "Lemon", "Bar", "Bell", "Cherry", "Clover",
                  "Diamond", "Horseshoe", "Orange", "Seven", "Plum"};
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                setGame();
            else if
                (int.Parse(playersMoneyLabel.Text) < 0)
                return;
            
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            string[] spinImage = new string[4];
            string[] bet = new string[4];

            setUser();
            spinImage =  spinReel();
            placeBet(spinImage);
        } 

        public void placeBet(string[] spinImages)
        {
            int total = int.Parse(playersMoneyLabel.Text);
            string seven = images[9];
            string prize = images[4];
            string[] swapPic =  spinImages;
            string[] bet = new string[3];

            bet[0] = userTextBox.Text;
            bet[1] = betTextBox.Text;
            
            string[] result = Array.FindAll(swapPic, p => p == prize);
           
            if(result.Length >= 1)
            {
                if(result.Length == 1)
                    total = total + int.Parse(bet[1]);
                if (result.Length == 2)
                    total = int.Parse(bet[1]) * 2 + total;
                if (result.Length == 3)
                    total = int.Parse(bet[1]) * 4 + total;

                playersMoneyLabel.Text = total.ToString();
                resultLabel.Text = "You're a frickin winner!";               
            }
            else
            {
                total = total - int.Parse(bet[1]);
                playersMoneyLabel.Text = total.ToString();
                resultLabel.Text = "You Lost! Shall you play again...";
            }
           
        }

        private void setUser()// starts game by getting user's name and creating $100 account
        {
            string user = userTextBox.Text;

            resultLabel.Text = "Hi " + user + " welcome to the Mega Casino. We've started you out with $100.";
            userTextBox.Visible = false;
            userNameLabel.Visible = false;
        }

        public string getRandomImage()//generates a random image from the available images
        {
            int newPic = 0;
            string newPicName = "";           
            newPic = randomImage.Next(11); //pull out 1 random image name and put it in a variable
            newPicName = images[newPic];// here is the new variable

            return newPicName;
        }

        public void setGame()// sets images to "Bars"
        {
            int total = 100;
            playersMoneyLabel.Text = total.ToString();
            Image1.ImageUrl = "~/mega/Images/" + images[2] + ".png";
            Image2.ImageUrl = "~/mega/Images/" + images[2] + ".png";
            Image3.ImageUrl = "~/mega/Images/" + images[2] + ".png";
        }

        public string[] spinReel()//returns the 3 images and the prize (cherries)
        {
            string[] slotArray = new string[3];
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