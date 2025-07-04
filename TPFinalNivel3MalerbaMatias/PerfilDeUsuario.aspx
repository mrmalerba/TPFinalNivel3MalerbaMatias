<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PerfilDeUsuario.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.PerfilDeUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-8 ms-5">
        <div class="mt-3 mb-5">
            <h1>Perfil de </h1>
            <h1 id="HeaderNombreDeUsuario"></h1>
        </div>
        <div class="row">
            <div class="col-4">
                <div class="mb-3">
                    <label class="form-label">Nombre</label>
                    <asp:TextBox CssClass="form-control" ID="txtNombre" Enabled="true" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Apellido</label>
                    <asp:TextBox CssClass="form-control" ID="txtApellido" Enabled="true" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">E-Mail</label>
                    <asp:TextBox CssClass="form-control" ID="txtEMail" Enabled="false" runat="server" />
                </div>
                <div class="mb-5">
                    <label class="form-label">Tipo De Usuario: </label>
                    <label id="lblTipoDeUsuario" class="form-label">Consumidor Final</label>
                </div>

            </div>
            <div class="col-4">
                <div class="text-start mb-3" height="100px">
                    <asp:Image ID="ProductImage" ImageUrl="https://i.imgur.com/V4RclNb.png" CssClass="img-thumbnail img-fluid" DescriptionUrl="ImagenProducto" runat="server" />
                </div>
                <div class="input-group">
                    <label class="form-label">Cambiar imagen de Perfil</label>
                </div>
                <div>
                    <input type="file" class="form-control" id="uploadedUserProfileImage">
                </div>
            </div>
        </div>
        <div class="mb-3">
            <asp:Button CssClass="btn btn-primary" ID="btnGuardarPerfil" Text="Guardar" OnClick="btnGuardarPerfil_Click" runat="server" />
        </div>
    </div>
</asp:Content>
