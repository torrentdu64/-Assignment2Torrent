<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCustomerIndex.aspx.cs" Inherits="Assignment2Torrent09196576.AdminCustomerIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Panel Customer</h1>
    <a href="/ProductAdminIndex" class="btn btn-primary">Back to dashboad</a>
    <ul>
     
   <% foreach (var item in customers) {  %>
           <li> <%= item.Name %> - <a href="/EditCustomer?id=<%= item.Id %>">Edit</a> - <a href="/DeleteCustomer?id=<%= item.Id %>">Delete</a> </li> 
     <% } %>  
   
    </ul>

      <div class="row">

                 <h2>Add a New Customer</h2>
          
                  
                      <label for="Cname">Customer name:</label><br>
                      <input type="text" name="Pname" id="Cname"><br>
                      <label for="Cpassword" >Customer password:</label><br>
                      <input type="text" name="Ppassword" id="Cpassword"><br>
                      <label for="Crole">Customer role:</label><br>
                     

                        <select name="Crole" id="cat">
                           <option value="null">No Role</option>
                          <option value="Fruit & Veg">Customer</option>
                          <option value="Meat & Seafood">Role</option>
                        </select><br>


                      <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
                         <%--<asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                   
             </div>
</asp:Content>
