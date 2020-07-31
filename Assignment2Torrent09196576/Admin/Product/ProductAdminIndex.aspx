﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductAdminIndex.aspx.cs" Inherits="Assignment2Torrent09196576.ProductAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
         <div class="jumbotron">
        <div class="row">
            <div class="input-group" id="search">
                <span class="input-group-btn"></span>
                <form action="/Admin/Product/ProductAdminIndex">
                    <input type="text" id="QData" name="fname" class="form-control" placeholder="Search for..."><br>

                   
                    <asp:LinkButton runat="server" ID="Button2" CssClass="btn btn-default" OnClick="Button1_Click2">
                                <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                                Search
                            </asp:LinkButton>

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
                </form>
            </div>
        </div>
        <% if (resultList != null)
            { %>
        <div class="row">
            <ul>
                <% foreach (var item in resultList)
                    { %>
                <li><%= item.Name %></li>
                <%  } %>
            </ul>
        </div>
        <% } %>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <h1 class="text-center">Promotion</h1>
            <div class="grid-promo">
                <% foreach (var item in discounts)
                    { %>
                <div class="wrap-promo">
                    <img src="../../img/Promo.jpg" alt="Promo" />
                    <a href="/Product/ProductShow?id=<%= item.Id %>">
                        <h4><%=  item.Name %></h4>
                    </a>
                </div>
                <%  } %>
            </div>
        </div>
    </div>

    `<div class="container">
        <h1 class="text-center">Products</h1>
        <div class="row">
            <h2>Add a New Product</h2>
            <form action="/Admin/Product/ProductCreate" id="CreateProduct" method="POST">
                <label for="Pname">Product name:</label><br>
                <input type="text" name="Pname"><br>
                <label for="Pdes">Product description:</label><br>
                <textarea name="Pdes" form="CreateProduct"></textarea><br>
                <label for="Pprice">Product price:</label><br>
                <input type="text" name="Pprice"><br>
                Select image to upload:
                      <input type="file" name="fileToUpload" id="fileToUpload">
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
            </form>
        </div>
        <div class="row">
            <a href="/Admin/Customer/AdminCustomerIndex" class="btn btn-primary">Customer Panel</a>
        </div>
        <div class="row">
            <h2>Meats</h2>
            <div class="grid-product">
                <% foreach (var item in meats)
                    { %>
                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>
                <% } %>
            </div>
        </div>
        <div class="row">
            <h2>Drinks</h2>
            <div class="grid-product">
                <% foreach (var item in drinks)
                    { %>
                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>
                <% } %>
            </div>
        </div>
        <div class="row">
            <h2>Fruits</h2>
            <div class="grid-product">
                <% foreach (var item in fruits)
                    { %>
                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>
                <% } %>
            </div>
        </div>



        <div class="row">
            <h2>Fridge</h2>
            <div class="grid-product">
                <% foreach (var item in fridge)
                    { %>
                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>
                <% } %>
            </div>
        </div>

        <div class="row">
            <h2>Bakery</h2>
            <div class="grid-product">

                <% foreach (var item in bakery)
                    { %>

                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>

                <% } %>
            </div>
        </div>

        <div class="row">
            <h2>Frozen</h2>
            <div class="grid-product">

                <% foreach (var item in Frozen)
                    { %>

                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>

                <% } %>
            </div>
        </div>


        <div class="row">
            <h2>Pantry</h2>
            <div class="grid-product">

                <% foreach (var item in pantry)
                    { %>

                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>

                <% } %>
            </div>
        </div>

        <div class="row">
            <h2>Beer</h2>
            <div class="grid-product">

                <% foreach (var item in beer)
                    { %>

                <div class="wrap-product">
                    <img src="../../img/food.jpg" alt="Alternate Text" width="170" height="170" />
                    <div class="product-des">
                        <p><%=  item.Name %></p>
                        <a class="btn btn-success" href="/Product/ProductShow?id=<%= item.Id %>">Show</a>
                        <a class="btn btn-primary" href="/Admin/Product/Modify?id=<%= item.Id %>">Add Discount</a>
                        <a class="btn btn-danger" href="/Admin/Product/ProductDestroy?id=<%= item.Id %>">Destroy</a>
                    </div>
                </div>

                <% } %>
            </div>
        </div>
    </div>
</asp:Content>
