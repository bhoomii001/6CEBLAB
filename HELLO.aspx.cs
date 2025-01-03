using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6CEBLAB
{
    public partial class HELLO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Write("hello");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            int a = Convert.ToInt32(num1.Text);
            int b = int.Parse(num2.Text);
            int sum = a + b;
            Response.Write("the sum is:" + (sum));
            
        }
    }
}