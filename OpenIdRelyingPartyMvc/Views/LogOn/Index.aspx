<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Sample.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content3" ContentPlaceHolderID="Statics" runat="server">
	<link href="../../Content/CSS/LogOnIndex.css" rel="stylesheet" type="text/css"/> 
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="logonForm">
        <h2>Please Log In:</h2>
        <textarea class="user" rows="1" cols="20">User</textarea><br/>
        <textarea class="password" rows="1" cols="20">Password</textarea><br/><br/>
        <button class="loginButton" type="button">Send</button>
    </div>

</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="Scripts" runat="server">
    <script type="text/javascript" src="../../Content/scripts/LogOnIndex.js"></script>
</asp:Content>
