using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class challenge23 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // start by creating AND initializing all three arrays needed to store form data
            string[] agent = new string[0];
            int[] elections = new int[0];
            int[] acts = new int[0];

            // now add those empty arrays to the viewState in order to have access after each postback
            ViewState.Add("Agent", agent);
            ViewState.Add("Elections", elections);
            ViewState.Add("Acts", acts);
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            // retrieve the arrays from the viewState in order to use them in this method
            string[] agent = (string[])ViewState["Agent"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            // determine the length of the new array we are about to create
            int newLength = agent.Length + 1;

            // takes each array and resizes it to new length determined by 
            // counting the current length and adding 1
            Array.Resize(ref agent, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref acts, newLength);

            // now we need to store the new values in the new empty key we just created with the resize method
            int newIndex = agent.GetUpperBound(0);

            // assign the contents of each text box to each corresponding array
            // using the int.Parse() method to read in int's from a textbox
            agent[newIndex] += assetNameTextBox.Text;
            elections[newIndex] += int.Parse(electionsRiggedTextBox.Text);
            acts[newIndex] += int.Parse(subterfugePerformedTextBox.Text);

            // now adding the updated arrays back to viewState
            ViewState["Agent"] = agent;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            resultLabel.Text = string.Format("Total elections rigged: {0} <br /> Average acts of subterfuge: {1:N2}" +
                "<br />(Last agent added: {2})", elections.Sum(), acts.Average(), agent[newIndex]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            subterfugePerformedTextBox.Text = "";






            
        }
    }
}