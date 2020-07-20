<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductShow.aspx.cs" Inherits="Assignment2Torrent09196576.ProductShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="grid-show">
                <img src="./food.jpg" alt="Alternate Text" width="425" height="425" />
                <div class="wrap-detail">
                     <h1><%= product.Name %></h1>
                     <h3>     <%= product.Description %> </h3>
                     <h2>$    <%= product.Price %> </h2>

                    <% if (IsLogIn())
                        { %>
                            <a href="/AddTrolley?id=<%= product.Id %>" >
                            <div class="btn btn-success">Add Trolley</div>
                      </a>
                      <%  }
                                    else
                                    {%>
                    <p>Sign in for add Product</p>
                       <a href="/Account/Login" >
                        <div class="btn btn-success">Add Trolley</div>
                        </a>
                    <% } %>
                </div>
            </div>
        </div>
    </div>

     

    <%-- <a href="/TrolleyShow?id=<%= product.Id %>" >
            <div class="btn btn-success">Add Trolley</div>
      </a>--%>

    
    
</asp:Content>
