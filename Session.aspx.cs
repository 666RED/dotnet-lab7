using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreadDemo
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["BackgroundColor"] != null)
            {
               Response.Write("Session color: " + Session["BackgroundColor"] + "<br>");
               ColorSelector.SelectedValue = Session["BackgroundColor"].ToString();
               BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            }
        }

        protected void ColorSelector_IndexChanged(object sender, EventArgs e)
        {
            Response.Write("SelectedValue: " + ColorSelector.SelectedValue + "<br>");
            BodyTag.Style["background-color"] = ColorSelector.SelectedValue;
            Session["BackgroundColor"] = ColorSelector.SelectedValue;
        }
    }
}