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
        int[,] assetTracker;

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            assetTracker = new int[3, 3];
            assetTracker[0, 0] = int.Parse(assetNameTextBox.Text);
            assetTracker[0, 1] = int.Parse(electionsRiggedTextBox.Text);
            assetTracker[0, 2] = int.Parse(subterfugePerformedTextBox.Text);

            for (int i = 0; i < assetTracker.Length; i++)
            {

                resultLabel.Text = string.Format("Agent { 0} you have rigged { 1}  elections and performed " +
                   "{ 2} acts of subterfuge.",assetTracker. );
            }
            
        }
    }
}