<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CSVtoXML.aspx.cs" Inherits="FileConverter.ReadCVS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

     <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        &nbsp;<br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" /><br />
        &nbsp;<br />
        <asp:Label ID="Label1" runat="server" Text="Has Header?"></asp:Label>
        <asp:RadioButtonList ID="rbHDR" runat="server">
            <asp:ListItem Text="Yes" Value="Yes" Selected="True"></asp:ListItem>
            <asp:ListItem Text="No" Value="No"></asp:ListItem>
        </asp:RadioButtonList><br />
        &nbsp;<br />

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

      <asp:HiddenField ID="FilePathHiddenField" runat="server" />
                 <asp:HiddenField ID="ExtensionHiddenField" runat="server" />
                 <asp:HiddenField ID="IsHDRHiddenField" runat="server" />
    
</asp:Content>
