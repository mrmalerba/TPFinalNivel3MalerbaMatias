<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-8 ms-5">
        <div class="mt-3 mb-5">
            <h1>Login</h1>
        </div>
        <div class="row">
            <div class="col-4 mb-5">
                <div class="mb-3">
                    <label class="form-label">E-Mail</label>
                    <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtEMail" Enabled="true" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Contraseña</label>
                    <asp:TextBox CssClass="form-control" TextMode="Password" ID="txtPass" Enabled="true" runat="server" />
                </div>
            </div>
        </div>
        <div class="mb-3">
            <asp:Button CssClass="btn btn-primary" ID="btnLogin" Text="Ingresar" OnClick="btnLogin_Click" runat="server" />
        </div>
    </div>
</asp:Content>
