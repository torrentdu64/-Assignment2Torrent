﻿
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductIndex.aspx.cs" Inherits="Assignment2Torrent09196576.ProductIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Products</h1>
  
    <% foreach (var item in dbProducts) { %>
    <h1><%= item.Name %></h1>
     <%   } %>

</asp:Content>
