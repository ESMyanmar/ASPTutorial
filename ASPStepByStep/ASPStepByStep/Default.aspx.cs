using System;
using System.Web;
using System.Web.UI;

namespace ASPStepByStep
{

    public partial class Default : System.Web.UI.Page
    {
        /*public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked" + Request.Form["Feature"];
        }*/
        public void ShowLineage()
        {
            Response.Write("Check out the family tree: <br/> <br/>");
            Response.Write(this.GetType().ToString());
            Response.Write(" which derives from: <br/> ");
            Response.Write(this.GetType().BaseType.ToString());
            Response.Write(" which derives from: <br/> ");
            Response.Write(this.GetType().BaseType.BaseType.ToString());
            Response.Write(" which derives from: <br/> ");
            Response.Write(this.GetType().BaseType.BaseType.BaseType.ToString());
            Response.Write(" which derives from: <br/> ");
            Response.Write(this.GetType().BaseType.BaseType.BaseType.BaseType.ToString());
        }
    }
}
