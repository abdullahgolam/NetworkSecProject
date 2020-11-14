<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container" style="margin-top: 50px">
        <div class="d-flex justify-content-center">
            <div class="row form-group" style="width: 30rem;">
                <div class="col">
                    <div id="divAlert" class="alert alert-warning" runat="server" visible="false">
                        <span>Incorrect Password</span>
                    </div>
                </div>
            </div>
        </div>
        <div class="d-flex justify-content-center">
            <div class="card" style="width: 30rem;">
                <div class="card-header text-center">
                    <h3>Login</h3>
                </div>
                <div class="card-body">
                    <div class="row form-group">
                        <div class="col">
                            <span>Email</span>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row form-group">
                        <div class="col">
                            <span>Password</span>
                            <asp:TextBox ID="txtPass" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row form-group text-center">
                        <div class="col">
                            <asp:Button ID="btnLogin" CssClass="btn btn-success" runat="server" Text="Log in" />
                        </div>
                    </div>
                </div>
                <div class="card-footer text-center">
                    <div class="row form-group">
                        <div class="col">
                            <asp:LinkButton ID="lbtnSignup" runat="server">Don't have account? Click here</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

