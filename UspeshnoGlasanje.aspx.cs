using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class UspeshnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_message.Text = "Г-дин " + Request.QueryString[1] + " ви благодариме за учеството во акцијата за избор на најинтересен предмет на ФИНКИ.Резултатите од гласањето ќе ги " +
                "добиете по електронска пошта, на Е-MAIL: "+Request.QueryString[0];
        }
    }
}