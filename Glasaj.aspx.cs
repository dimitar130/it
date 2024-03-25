using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String[] prof = { "Интернет Технологии", "Проф. др Гоце Арменски", "Интернет", "Проф. др Влатко Стојановиќ", "Технологии", "Проф. др Димитар Чучанов" };
                String[] kred = { "6", "Интернет Технологии", "5.5", "Интернет", "5", "Технологии" };
                for (int i = 0; i < prof.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        list_prof.Items.Add(new ListItem(prof[i], prof[i + 1]));
                        list_kred.Items.Add(new ListItem(kred[i], kred[i + 1]));
                    }
                    
                }

             }
            
        }

        protected void list_prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_prof.Text = list_prof.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (list_kred.SelectedIndex != -1 && list_prof.SelectedIndex != -1)
            {

                Response.Redirect("UspeshnoGlasanje.aspx?email="+Request.QueryString[0]+"&ime="+Request.QueryString[1]);
            }
            else
            {
                lbl_errmsg.Text = "Селектирај и во двете листи!";
            }
        }

        protected void btn_dodaj_Click(object sender, EventArgs e)
        {
            list_prof.Items.Add(new ListItem(txtbox_prof.Text));
            list_kred.Items.Add(new ListItem(txtbox_kred.Text, txtbox_prof.Text));
            txtbox_prof.Text = "";
            txtbox_kred.Text = "";
        }

        protected void btn_izbrisi_Click(object sender, EventArgs e)
        {
            list_kred.Items.Remove(list_kred.Items.FindByValue(list_prof.SelectedItem.Text));
            list_prof.Items.Remove(list_prof.SelectedItem);
        }
    }
}