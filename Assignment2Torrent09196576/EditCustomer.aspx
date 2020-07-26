<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="Assignment2Torrent09196576.EditCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
                      <label for="Cname">Customer name:</label><br>
                      <input value="<%= customer.Name %>" type="text" name="Cname"><br>
                       <label for="Cpassword" >Customer password:</label><br>
                      <input value="<%= customer.Password %>" type="text" name="Ppassword" id="Cpassword"><br>
                      <label for="Crole">Customer role:</label><br>
                     

                        <select name="Crole" id="cat">
                           <option value="<%= customer.Role %>"><%= customer.Role %></option>  
                          <option value="Customer">Customer</option>
                          <option value="Admin">Admin</option>
                        </select><br>


    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>
