
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductIndex.aspx.cs" Inherits="Assignment2Torrent09196576.ProductIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:LoginView id="LoginView1" runat="server">
     <AnonymousTemplate>
         Please log in for personalized information.
          <a href="/Account/Login" >
            <div class="btn btn-primary">Log In</div>
          </a>
     </AnonymousTemplate>
     <LoggedInTemplate>
         Thanks for logging in
         <div class="container">
             <div class="row">
                    <h1 class="text-center">Promotion</h1>
             
                 <div class="grid-promo">
                          <% foreach (var item in dbProducts) { %>
                                <% if (item.Discount != null)   { %>
                             <div class="wrap-promo">
                                <img src="./Promo.jpg" alt="Promo" />
                                <a href="/ProductShow?id=<%= item.Id %>">  <h4><%=  item.Name %></h4> </a>
                             </div>
                          <%  } %>
                       <%  } %>
                 </div>
   
             </div>
         </div>
          
       
  
         `<div class="container">
             <div class="row">
                  <h1 class="text-center">Products</h1>
                       
                  <% foreach (var item in dbProducts)
                    { %>
        
                    <% if (item.Category == "Meat")
                        { %>
                 <h2><%= item.Category %></h2>
                 <div class="wrap-product">
                     <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                     <p><%=  item.Name %></p>
                     <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                 </div>
                            
                     <% } if (item.Category == "Fruit")  { %>
                                 <h2><%= item.Category %></h2>
                          <div class="wrap-product">
                     <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                     <p><%=  item.Name %></p>
                     <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                 </div>
                 <%   } if (item.Category == "Drinks") { %>
                             <h2><%= item.Category %></h2>
                          <div class="wrap-product">
                     <img src="./food.jpg" alt="Alternate Text" width="170" height="170" />
                     <p><%=  item.Name %></p>
                     <a class="btn btn-success" href="/ProductShow?id=<%= item.Id %>">Show</a>
                 </div>
                      <%} %>
                <%}  %>

             </div>
          </div>
       
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
