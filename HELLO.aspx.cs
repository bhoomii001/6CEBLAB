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
            //PRESENT NUMBER:20/12/2024
            //6ceb: 1,4,5,11,19,23,24,25,29
            //6ITA:3,4,6,13,14,15,16,18,22,24,25,26,28
        }
    }
}