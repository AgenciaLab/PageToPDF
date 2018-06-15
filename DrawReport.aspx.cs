using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Web.UI.HtmlControls;


public partial class DrawReport : System.Web.UI.Page
{

    public string ApplicationBaseUrl = string.Empty;
    public string ReportType = "PDF";
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationBaseUrl = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "/";
        FillGrid();
    }

    private void FillGrid()
    {

    }
}