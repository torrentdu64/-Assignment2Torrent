<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Assignment2Torrent09196576.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-8">    
                <h1>Register</h1>
                
                  <div class="form-group">
                    <label for="exampleInputEmail1">Name</label>

                     <%--<asp:TextBox ID="email" runat="server"></asp:TextBox>--%>

                    <input name="email" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="nameHelp" placeholder="Enter email">
                    <small id="nameHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                  </div>
               
                  <div class="form-group">
                    <label for="exampleInputPassword1">Password</label>
                    <asp:TextBox ID="exampleInputPassword1" placeholder="Password"  type="password" class="form-control" Font-Names="password" runat="server"></asp:TextBox>
                    <%--<input  name="password" type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                  </div>

                  <div class="form-group">
                    <label for="exampleInputPasswordConfirm">Confirm Password</label>
                      <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ClientIDMode="Inherit" ValueToCompare="exampleInputPassword1" ControlToValidate="exampleInputPasswordConfirm" ControlToCompare="exampleInputPassword1"></asp:CompareValidator>
                      <asp:TextBox ID="exampleInputPasswordConfirm" placeholder="Password"  type="password"  runat="server" CssClass="form-control"></asp:TextBox>
                   <%-- <input type="password" class="form-control" id="exampleInputPasswordConfirm" placeholder="Password">--%>
                  </div>

                  <div class="form-group form-check">
                    <input name="remember" type="checkbox" class="form-check-input" id="exampleCheck1">
                    <label class="form-check-label" for="exampleCheck1">Check me out</label>
                  </div>
                  
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="Button1_Click" />
            </div>
        </div>
    </div>
    
</asp:Content>
