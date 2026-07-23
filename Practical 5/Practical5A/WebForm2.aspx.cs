using System;

namespace Practical_5C
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] != null)
            {
                Label1.Text = "Welcome " + Request.Cookies["name"].Value;
            }
            else
            {
                Label1.Text = "Cookie Not Found";
            }
        }
    }
}
