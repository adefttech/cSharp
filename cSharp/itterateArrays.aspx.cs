using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class itterateArrays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] {"Company","Manager","Employees","Products","Marketing", "Pricing" };

            for (int i = 0; i < names.Length; i++) 
            {
                string lastName = names[i];
                resultLabel.Text += lastName +" -- " + names[i];
            }
        }
    }
}