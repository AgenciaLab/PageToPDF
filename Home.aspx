<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
 
<form id="form1" runat="server">



        <table class="style1">
            <tr>
                <td>
                    Olá, esse é um exemplo de conversão HTML para PDF</td>
            </tr>
            <tr>
                <td>
                    <h6>Url requerida:</h6>
                    <asp:TextBox ID="btnValue" runat="server" Text="http://www.google.com.br" />
        <asp:Button ID="btnReport" runat="server" Text="Download PDF" onclick="btnReport_Click" />  


                </td>
            </tr>
            
        </table>


</form>
</body>
</html>