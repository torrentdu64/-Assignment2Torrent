<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment2Torrent09196576.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-8">    
                <h1>Login</h1>
                <asp:Label ID="Label1" runat="server"></asp:Label>
                  <div class="form-group">
                    <label for="exampleInputEmail1">email</label>
                   
                     <%--<asp:TextBox ID="email" runat="server"></asp:TextBox>--%>

                    <input name="email" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
                    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                  </div>
               
                  <div class="form-group">
                    <label for="exampleInputPassword1">Password</label>
                    <input  name="password" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
                  </div>

               

                  <div class="form-group form-check">
                    <input name="remember" type="checkbox" class="form-check-input" id="exampleCheck1">
                    <label class="form-check-label" for="exampleCheck1">Check me out</label>
                  </div>

                <div class="mt-4">
					<div class="d-flex justify-content-center links">
						Don't have an account? <a href="/Register" class="ml-2">Sign Up</a>
					</div>
					<div class="d-flex justify-content-center links">
						<a href="#">Forgot your password?</a>
					</div>
				</div>
                  
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
</asp:Content>
