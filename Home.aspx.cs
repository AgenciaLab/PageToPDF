using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;



public partial class Home : System.Web.UI.Page
{
    string ApplicationBaseUrl = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        ApplicationBaseUrl = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "/";
    }
    protected void btnReport_Click(object sender, EventArgs e)
    {
        DownloadReportAsPDF();
    }

    private void DownloadReportAsPDF()
    {
        try
        {
            string url = this.Request.Form["btnValue"];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            String ver = response.ProtocolVersion.ToString();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string htmlContent = reader.ReadToEnd();

            NReco.PdfGenerator.HtmlToPdfConverter obj = new NReco.PdfGenerator.HtmlToPdfConverter();
            obj.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
            obj.PageWidth = 1200;
            obj.Zoom = 1;
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            obj.GeneratePdfFromFile("http://www.google.com.br", null, stream);
            string respondentName = string.Empty;

            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Report.pdf");
            Response.Buffer = true;
            stream.WriteTo(Response.OutputStream);
            Response.End();
        }
        catch (Exception ex)
        {

        }
    }

    protected string getHeader()
    {
        return "<table  width='100%' ><tr><td>&nbsp;</td><td></td></tr></table>";
    }
    protected string getFooter()
    {
        return "<table  width='100%' ><tr><td>&nbsp;</td><td></td></tr><tr border='0' bordercolor='blue' bgcolor='#E7E7FF'><td style='font-family:sans-serif;   font-size:12px;'><b>Date : " + DateTime.Now.ToShortDateString() + "</b></td><td align='right' style='font-family:sans-serif;   font-size:23px;'><div>Page <span class='page'></span></strong></span></div></td></tr></table>";
    }


    protected void btnHtmlReport_Click(object sender, EventArgs e)
    {
        Response.Redirect(string.Format(null, ""));
        Response.End();
    }
}