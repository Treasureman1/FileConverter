<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendSmtpEmailObject.aspx.cs" Inherits="FileConverter.SendSmtpEmailObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       To  <asp:TextBox ID="txtTo" runat="server"></asp:TextBox><br />
     From  <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox><br />
   Subject <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
Email Body <asp:TextBox ID="txtBody" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnSendEmail" runat="server" Text="Button" OnClick="btnSendEmail_Click" />
    </div>
    </form>
</body>
</html>
