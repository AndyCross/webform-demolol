using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrownBag
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.TraceError("This is webforms. FAIL");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int i;

            if (int.TryParse(((Button)sender).Text, out i))
            {
                i++;
            }
            else
            {
                i = 0;
            }
            ((Button)sender).Text = i.ToString();
        }
    }
}