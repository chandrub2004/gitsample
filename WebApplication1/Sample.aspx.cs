using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            StepCollection S = c.ReadXMLdata();
        }
    }
}