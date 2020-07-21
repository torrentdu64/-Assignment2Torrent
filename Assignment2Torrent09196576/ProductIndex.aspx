
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductIndex.aspx.cs" Inherits="Assignment2Torrent09196576.ProductIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
         <div class="container">
             <div class="jumbotron">
                     <div class="row">
                <div class="col-lg-12">
                    <div class="input-group" id="search">
                        <span class="input-group-btn">
                        <%--<button class="btn btn-default" type="button">
                            <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                        </button>--%>
                        </span>
                        <form action="/ProductIndex" >
                     
                      <input type="text" id="QData" name="fname" class="form-control" placeholder="Search for...">
                       <%--  <asp:Button ID="Button1" runat="server" Text="Search a product" />--%>

                            <asp:LinkButton runat="server" ID="uxSearch" CssClass="btn btn-default"  OnClick="Button1_Click" >
                                <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                                Search
                            </asp:LinkButton>
                    </form>
                        <%--<input type="text" class="form-control" placeholder="Search for...">--%>
                    </div><!-- /input-group -->
                    <a href="/TrolleyShow.aspx" class="btn btn-primary" id="btn-position"><span class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span>   Checkout</a>
                </div><!-- /.col-lg-6 -->
              
             </div>
            </div>
          
                 <% if (resultList != null)  { %>
                    <div class="row">
                        <div class="grid-product">
                             <% foreach (var item in resultList)  { %>
                                        <div class="wrap-product">
                                             <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                                             <div class="product-des">
                                                 <p><%=  item.Name %></p>
                                                 <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                                             </div>
                                         </div>
                               <%  } %>
                     
                         </div>
                     </div>
                  <% } %>
             
         </div>

         <div class="container">
             
         </div>

          <div class="container">
             <div class="row">
                 <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                    
             </div>
        
         </div>



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
                 <%--<a href="/ProductOrder.aspx" class="btn btn-primary">Order</a>--%>
                 <asp:Button ID="Button2" runat="server" Text="Order by Price" CssClass="btn btn-primary" OnClick="Button2_Click" />
             </div>
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


        <asp:LoginView id="LoginView1" runat="server">
     <AnonymousTemplate>
         Please log in for personalized information.
          <a href="/Account/Login" >
            <div class="btn btn-primary">Log In</div>
          </a>
     </AnonymousTemplate>
     <LoggedInTemplate>

         <asp:LoginName id="LoginName1" runat="Server"></asp:LoginName>.
     </LoggedInTemplate>
     <RoleGroups>
         <asp:RoleGroup Roles="Admin">
             <ContentTemplate>
                 <asp:LoginName id="LoginName2" runat="Server" />, you are logged in as an administrator.
             </ContentTemplate>
         </asp:RoleGroup>
     </RoleGroups>
 </asp:LoginView>
    
    
       
     

</asp:Content>
