using System;

namespace Samples
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.header.Title = Page.Title;
        }
    }
}