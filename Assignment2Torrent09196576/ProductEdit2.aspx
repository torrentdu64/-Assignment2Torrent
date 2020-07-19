<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductEdit2.aspx.cs" Inherits="Assignment2Torrent09196576.ProductEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
             <%--<form action="/ProductUpdate" id="EditProduct" >
                       <input value="<%= product.Id %>" type="text" name="Pid"><br>
                      <label for="Pname">Product name:</label><br>
                      <input value="<%= product.Name %>" type="text"  name="Pname"><br>
                      <label for="Pdes">Product description:</label><br>
                      <textarea name="Pdes"><%= product.Description %></textarea><br>
                      <label for="Pprice">Product price:</label><br>
                      <input value="<% =product.Price %>" type="text" name="Pprice"><br> 
                      <label for="Pdiscount">Product dicount</label><br>
                      <input  value="<%= product.Discount %>" type="text" name="Pdiscount"><br>
                      <label for="cat">Choose a Category:</label>

                        <select name="Pcategory" id="cat">
                          <option value="<%= product.Category %>"><%= product.Category %></option>  
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
           <%-- </form>--%>
            <form action="/ProductUpdate.aspx">
               <label for="Pname">Product name:</label><br>
                      <input  type="text"  name="Pname"><br>
                  <input type="submit" value="Submit">
             </form>





        </div>
    </div>
</asp:Content>
