<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductAdminIndex.aspx.cs" Inherits="Assignment2Torrent09196576.ProductAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    

    <div class="container">
             <div class="row">
                 <a href="/TrolleyShow.aspx" class="btn btn-primary">Checkout</a>
             </div>
         </div>

         <div class="container">
             <div class="row">
                 <%--<a href="/ProductOrder.aspx" class="btn btn-primary">Order</a>--%>
                <%-- <asp:Button ID="Button2" runat="server" Text="Order" CssClass="btn btn-primary" OnClick="Button2_Click" />--%>
             </div>
         </div>

          <div class="container">
             <div class="row">
                 <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                    <form action="/ProductAdminIndex" >
                     
                      <input type="text" id="QData" name="fname"><br>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
                         <select name="Pcategory" id="cat">
                           <option value="null">No Category Search</option>
                          <option value="Fruit & Veg">Fruit & Veg</option>
                          <option value="Meat & Seafood">Meat & Seafood</option>
                          <option value="Fridge & Deli">Fridge & Deli</option>
                          <option value="Bakery">Bakery</option>
                            <option value="Frozen">Frozen</option>
                            <option value="Pantry">Pantry</option>
                            <option value="Beer & Wine">Beer & Wine</option>
                            <option value="Drinks">Drinks</option>
                            <option value="Health & Beauty">Health & Beauty</option>
                            <option value="Baby & Child">Baby & Child</option>
                            <option value="Pet">Pet</option>
                        </select><br>
                         <%--<asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                    </form>
             </div>
         <% if (resultList != null)  { %>
            <div class="row">
                 <ul>
                     <% foreach (var item in resultList)  { %>
                             <li><%= item.Name %></li>
                       <%  } %>
                     
                 </ul>
             </div>
            <% } %>
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

                 <h2>Add a New Product</h2>

                  <form action="/ProductCreate" id="CreateProduct" >
                      <label for="Pname">Product name:</label><br>
                      <input type="text" name="Pname"><br>
                      <label for="Pdes">Product description:</label><br>
                      <textarea name="Pdes" form="CreateProduct"></textarea><br>
                      <label for="Pprice">Product price:</label><br>
                      <input type="text" name="Pprice"><br>
                      <label for="Pdiscount">Product dicount</label><br>
                      <input type="text"  name="Pdiscount"><br>
                      <label for="cat">Choose a Category:</label>

                        <select name="Pcategory" id="cat">
                          <option value="Fruit & Veg">Fruit & Veg</option>
                          <option value="Meat & Seafood">Meat & Seafood</option>
                          <option value="Fridge & Deli">Fridge & Deli</option>
                          <option value="Bakery">Bakery</option>
                            <option value="Frozen">Frozen</option>
                            <option value="Pantry">Pantry</option>
                            <option value="Beer & Wine">Beer & Wine</option>
                            <option value="Drinks">Drinks</option>
                            <option value="Health & Beauty">Health & Beauty</option>
                            <option value="Baby & Child">Baby & Child</option>
                            <option value="Pet">Pet</option>
                        </select>
                       <input type="submit" value="Submit">
                         <%--<asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                    </form>
             </div>

             <div class="row">
                 <a href="/AdminCustomerIndex" class="btn btn-primary">Customer Panel</a>
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
                             <a class="btn btn-primary" href="/Modify?id=<%= item.Id %>">Edit</a>
                              <a class="btn btn-danger" href="/ProductDestroy?id=<%= item.Id %>">Destroy</a>
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
