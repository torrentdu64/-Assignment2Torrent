<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductShow.aspx.cs" Inherits="Assignment2Torrent09196576.ProductShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Show</h1>

    <h1><%= product.Name %></h1>
     <h3>     <%= product.Description %> </h3>
     <h2>$    <%= product.Price %> </h2>
    
    <a href="/TrolleyShow?id=<%= product.Id %>" >
    <div class="btn btn-success">Add Trolley</div>
    </a>
</asp:Content>
