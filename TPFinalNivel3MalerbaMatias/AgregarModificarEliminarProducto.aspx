<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarModificarEliminarProducto.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.AgregarModificarEliminarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mt-3 mb-4">
        <h1>Detalles</h1>
    </div>
    <div class="row">
        <div class="col-4">
            <div class="mb-3">
                <label class="form-label">Id del Producto</label>
                <asp:TextBox CssClass="form-control" ID="txtId" Enabled="false" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Código </label>
                <asp:TextBox CssClass="form-control" ID="txtCodigo" Enabled="false" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox CssClass="form-control" ID="txtNombre" Enabled="false" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Descripción</label>
                <asp:TextBox CssClass="form-control" ID="txtDescripcion" TextMode="MultiLine" Enabled="false" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMarca" Enabled="false" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label class="form-label">Categoría</label>
                <asp:DropDownList ID="ddlCategoria" Enabled="false" runat="server"></asp:DropDownList>
            </div>
            <div>
                <label class="form-label">Precio</label>
                <asp:TextBox CssClass="form-control" ID="txtPrecio" Enabled="false" runat="server" />
            </div>
        </div>
        <div class="col-4">
            <label class="form-label">Imagen</label>
            <asp:Image ID="ProductImage" ImageUrl="https://i.imgur.com/EJLFNOwg.jpg" CssClass="img-fluid" DescriptionUrl="ImagenProducto" runat="server" />
        </div>
    </div>
</asp:Content>
