using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreadDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThreadStart childthreat = new ThreadStart(childthreadcall);
            Response.Write("Child Thread Started <br/>");
            Thread child = new Thread(childthreat);
            child.Start();
            Response.Write("Main sleeping for 2 seconds.......<br/>");
            Thread.Sleep(2000);
            Response.Write("<br/>Main aborting child thread<br/>");
            child.Abort();
        }

        public void childthreadcall()
        {
            Response.Write("We are in");
            try
            {
                Response.Write("<br />Child thread started <br/>");
                Response.Write("Child Thread: Counting to 10");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Response.Write("<br/> in Child thread </br>");
                }
                Response.Write("<br/> child thread finished");
            }
            catch (ThreadAbortException e)
            {
                Response.Write("<br /> child thread - exception");
            }
            finally
            {
                Response.Write("<br /> child thread - unable to catch the exception");
            }
        }
    }
}