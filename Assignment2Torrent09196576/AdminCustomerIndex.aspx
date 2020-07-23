<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminCustomerIndex.aspx.cs" Inherits="Assignment2Torrent09196576.AdminCustomerIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Panel Customer</h1>

    <ul>
     
   <% foreach (var item in customers) {  %>
           <li> <%= item.Name %> - <a href="/EditCustomer?id=<%= item.Id %>">Edit</a> - <a href="/DeleteCustomer?id=<%= item.Id %>">Delete</a> </li> 
     <% } %>  
   
    </ul>

      <div class="row">

                 <h2>Add a New Customer</h2>

                  
                      <label for="Cname">Customer name:</label><br>
                      <input type="text" name="Pname"><br>
                      
                      <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
                         <%--<asp:Button ID="Button1" runat="server" Text="Search a product"  OnClick="Button1_Click" />--%>
                   
             </div>
</asp:Content>
