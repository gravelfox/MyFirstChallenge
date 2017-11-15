using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string dollar = dollarTextBox.Text;
            //removes dollar sign if user inputs
            if (dollar.Contains('$'))
            {
                dollar = dollar.Remove(dollar.IndexOf('$'), 1);
            }
            string message = "At the ripe age of " + age + ", you should really have more than $" + dollar + " in your pocket.";
            fortuneLabel.Text = message;
        }
    }
}