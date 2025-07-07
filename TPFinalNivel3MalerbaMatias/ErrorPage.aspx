<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row ms-5 mt-5 mb-5">
        <div class="col-4">
            <h2>Mensaje de Error</h2>
            <label id="txtError" runat="server">No se ha encontrado ningun error</label>
            <div class="mt-5">
                <asp:HyperLink ID="btnErrorRedirect" CssClass="btn btn-primary" Visible="false" Text="Desabilitado" NavigateUrl="#" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
