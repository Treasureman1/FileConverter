<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FTPManagerForm1.aspx.cs" Inherits="FileConverter.FTPManagerForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Username : <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>   Password : <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
       <br /> <br />
        Address : <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />
        Download Path : <asp:TextBox ID="txtDownloadPath" runat="server"></asp:TextBox><br /><br />
        File To Download : <asp:TextBox ID="txtFileToDownload" runat="server"></asp:TextBox><br /><br />
        
        <br /><asp:Button ID="btnDownload" runat="server" Text="Download FTP File" OnClick="btnDownload_Click" />
    </div>
    </form>
</body>
</html>
