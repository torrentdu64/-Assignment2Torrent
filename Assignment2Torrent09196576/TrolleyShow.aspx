<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrolleyShow.aspx.cs" Inherits="Assignment2Torrent09196576.TrolleyShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Trolley</h1>
    <div class="grid-product">
    <% foreach (var cart in trolleys) { %>
        <% foreach (var p in cart.ProductTrolleys) { %>
                  
                
                    <div class="wrap-product">
                        <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                        <div class="product-des">
                            <p><%=  p.Product.Name %></p>
                            <a class="btn btn-danger" href="/TrolleyDestroy?id=<%= cart.Id %>" >Del</a>
                        </div>
                    </div>
              
               
          <%  } %>
     <%   } %>
        <a href="#" class="btn btn-success">
            <img src="payment.png" width="160" alt="Alternate Text" />
            Payment</a>
    </div>

</asp:Content>
