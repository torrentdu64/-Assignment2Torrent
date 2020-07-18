<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrolleyShow.aspx.cs" Inherits="Assignment2Torrent09196576.TrolleyShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Trolley</h1>

    <% foreach (var cart in trolleys) { %>


    <% foreach (var p in cart.ProductTrolleys) { %>

           <%= p.Product.Name %>

      <%  } %>

     <%   } %>

</asp:Content>
