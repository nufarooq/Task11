using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdditionSubstractionApp
{
    public partial class Calculation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_add(object sender, EventArgs e)
        {
            Calc cal = new Calc();
            int c = cal.add(txtNum1.Text, txtNum2.Text);
            Response.Write("Addition is " + c.ToString());
        }

        protected void button_sub(object sender, EventArgs e)
        {
            Calc cal = new Calc();
            int c = cal.sub(txtNum1.Text, txtNum2.Text);
            Response.Write("Subtraction is "+c.ToString());
        }
    }
}