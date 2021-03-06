﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cSharp
{
    public partial class helperMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if(quantityTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!double.TryParse(quantityTextBox.Text, out quantity)) 
                return;

            double cups = quantity * measureToCupRatio;

            resultLabel.Text = string.Format(
                                "{0:N2} {1} is equal to {2:N2} cups.",quantity, measureName, cups
                                 );

            
        }

        protected void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //calculateCups();
        }

        protected void fromCupsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(1.0, "cups");
        }

        protected void fromQuartsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(2.0, "quarts");
        }

        protected void fromPintsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(4.0, "pints");
        }

        protected void fromGallonsRadio_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups(16.0, "gallons");
        }
    }
}