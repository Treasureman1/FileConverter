<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileConverter._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>Convert Files</h1>
            </hgroup>
            <p>
                To Convert you files, simply choose file type below and convert.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol class="round">
        <li class="one">
            <h5>CSV Converion Options</h5>
            *Read CSV files to DataTable<br />
            *Read CSV Files to Excel<br />
            *Read CSV Files to Gridview
        </li>
        <li class="two">
            <h5>Excel Export Options</h5>
            Export and Import Excel Files to you application.<br />
            *Modify Excel Sheets
        </li>
        <li class="three">
            <h5>DataSet and DataTable Export Options</h5>
            *Convert DataTable to CSV<br />
            *Convert DataTable to Excel<br />
            *Read DataTable</li>
    </ol>
    <p>
        Send Sample Email
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Send Email" OnClick="Button1_Click" />
        &nbsp;
        <br />

    </p>
</asp:Content>
