<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Assignment2Torrent09196576.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Change password</h1>

     <label for="Cname">Customer name:</label><br>
    <input  type="text" name="Cname"><br>
    <label for="Cpassword" >Enter a New Password:</label><br>
    <input  type="text" name="Ppassword" id="Cpassword"><br>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


</asp:Content>
