<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrolleyShow.aspx.cs" Inherits="Assignment2Torrent09196576.TrolleyShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Trolley</h1>
    <ul>
    <% foreach (var cart in trolleys) { %>
        <% foreach (var p in cart.ProductTrolleys) { %>
                  
                <li> <%= p.Product.Name  %> - <a class="btn btn-danger" href="/TrolleyDestroy?id=<%= cart.Id %>" >Del</a>
              
                </li>
          <%  } %>
     <%   } %>
    </ul>

</asp:Content>
