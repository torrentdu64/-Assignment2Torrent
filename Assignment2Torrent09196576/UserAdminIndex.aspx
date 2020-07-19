<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAdminIndex.aspx.cs" Inherits="Assignment2Torrent09196576.UserAdminIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Administrate customer</h1>

    <a class="btn btn-success" href="/UserAdminCreate">Create a New Customer</a>
    <ul>
        
    
    <% foreach (var item in users) { %>

       
        <li><%= item.Email %><a class="btn btn-primary" href="#">Edit</a> </li>
       

    <%    } %>
    </ul>

</asp:Content>
