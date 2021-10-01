using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double c, d_value;
            d_value = 3.982;
            c = d_value * d_value;
            Response.Write("d_value=" + d_value + "*" + d_value + "=" + c);
        }
    }
}