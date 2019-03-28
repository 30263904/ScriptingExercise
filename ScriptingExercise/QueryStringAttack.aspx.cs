using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ScriptingExercise
{
    public partial class QueryStringAttack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if(id==null)
            {
                lblOutput.Text = "Yay";
            }
            else
            {
                
                lblOutput.Text = "NA";
            }
        }
    }
}