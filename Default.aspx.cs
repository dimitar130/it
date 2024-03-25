using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_najava_Click(object sender, EventArgs e)
        {
            String email = txtbox_email.Text; 
            Response.Redirect("Glasaj.aspx?email="+txtbox_email.Text+"&ime="+txtbox_ime.Text);
        }
    }
}