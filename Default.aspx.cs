using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<String> ddlSourceCollection = new List<String> { "Item1", "Item2", "Item3" };
        ListItem defaultListItem = new ListItem("-- Select item --");
        ddlTest.DataSource = ddlSourceCollection;
        ddlTest.DataBind();
        ddlTest.Items.Insert(0, defaultListItem);
    }



    protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblName.Text = "Name here";
        lblName.Text = ddlNames.SelectedItem.Text;
    }
}