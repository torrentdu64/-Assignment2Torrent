<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductOrder.aspx.cs" Inherits="Assignment2Torrent09196576.ProductOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

             <div class="container">
             <div class="row">
                    <h1 class="text-center">Promotion</h1>
             
                 <div class="grid-promo">
                          <% foreach (var item in discounts) { %>
                              
                             <div class="wrap-promo">
                                <img src="./Promo.jpg" alt="Promo" />
                                <a href="/ProductShow?id=<%= item.Id %>">  <h4><%=  item.Name %></h4> </a>
                             </div>
                        
                       <%  } %>
                 </div>
   
             </div>
         </div>

      
        
  
         `<div class="container">
             
                  <h1 class="text-center">Products</h1>
             <div class="row">
                  <h2>Meats</h2>
                 <div class="grid-product">
                     
                  <% foreach (var item in meats)  { %>
                    
                     <div class="wrap-product">
                         <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                         <div class="product-des">
                             <p><%=  item.Name %></p>
                             <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                         </div>
                     </div>       

                  <% } %>

                 </div>
            </div>
             <div class="row">
                  <h2>Drinks</h2>
                 <div class="grid-product">
                     
                  <% foreach (var item in drinks)  { %>
                    
                     <div class="wrap-product">
                         <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                         <div class="product-des">
                             <p><%=  item.Name %></p>
                             <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                         </div>
                     </div>       

                  <% } %>

                 </div>
            </div>
             <div class="row">
                  <h2>Fruits</h2>
                 <div class="grid-product">
                     
                  <% foreach (var item in fruits)  { %>
                    
                     <div class="wrap-product">
                         <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                         <div class="product-des">
                             <p><%=  item.Name %></p>
                             <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                         </div>
                     </div>       

                  <% } %>

                 </div>
            </div>

             

            
          </div>
</asp:Content>
