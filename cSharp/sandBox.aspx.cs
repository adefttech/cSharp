using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class sandBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";
            string block = "X";
            string nl = "<br />";
            int u = 10;

            for(int c = 0; c < u; c++)
            {// out loop (creates columns for the rows to build upon - give it a number of columns to build)
                for (int r = 0; r < u ; r++)
                {// inner loop (creates rows of building blocks -just give it a number of blocks to lay)
                    result += block;
                }

                result += nl;
            }
            resultLabel.Text = result;
        }   
    }
}