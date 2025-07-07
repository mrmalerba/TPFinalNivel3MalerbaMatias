<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarModificarEliminarProducto.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.AgregarModificarEliminarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class=" row mt-3 mb-4">
            <div class="col">
                <h1 id="txtheadertitulo" runat="server">Detalles</h1>
            </div>
            <div class="col d-md-flex justify-content-md-end">
                <asp:Button ID="btnRegresar" CssClass="btn btn-secondary" Text="Volver" OnClick="btnRegresar_Click" runat="server" />
            </div>
        </div>
        <div class="row">
            <div class="col-4">
                <div class="mb-3">
                    <label class="form-label">Id del Producto</label>
                    <asp:TextBox CssClass="form-control" ID="txtId" Enabled="false" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Código </label>
                    <asp:TextBox CssClass="form-control" ID="txtCodigo" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Nombre</label>
                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Descripción</label>
                    <asp:TextBox CssClass="form-control" ID="txtDescripcion" TextMode="MultiLine" runat="server" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Marca</label>
                    <asp:DropDownList ID="ddlMarca" AutoPostBack="true" runat="server"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label class="form-label">Categoría</label>
                    <asp:DropDownList ID="ddlCategoria" AutoPostBack="true" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <label class="form-label">Precio</label>
                    <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server" />
                </div>
            </div>
            <div class="col-4 mb-5">
                <div>
                    <asp:Image ID="ProductImage" ImageUrl="https://i.imgur.com/EJLFNOwg.jpg" CssClass="img-fluid" DescriptionUrl="ImagenProducto" runat="server" />
                </div>
                <div class="input-group">
                    <label class="form-label">Elegir imagen del Producto</label>
                </div>
                <div>
                    <input type="file" class="form-control" id="uploadedUserProfileImage" runat="server">
                </div>
            </div>
            <div class="col">
                <div class="mb-5">
                <asp:Button ID="btnAgregarProducto" CssClass="btn btn-primary" Text="Agregar" OnClick="btnAgregarProducto_Click" runat="server" />
                <asp:Button ID="btnModificarProducto" CssClass="btn btn-primary" Text="Modificar" OnClick="btnModificarProducto_Click" runat="server" />
                <asp:Button ID="btnEliminarProducto" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnEliminarProducto_Click" runat="server" />
                </div>
                <asp:Panel ID="panelConfirmacion" Visible="false" runat="server">
                    <div class="mb-3">
                        <label id="lblCheck" class="form-check-label" runat="server">Por favor confirme que quiere eliminar este producto</label>
                        <asp:CheckBox CssClass="form-check-input" ID="checkConfirmarEliminar" runat="server" />
                    </div>
                    <div>
                        <asp:Button ID="btnConfirmarEliminarProducto" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnConfirmarEliminarProducto_Click" runat="server" />
                        <asp:Button ID="btnCancelarEliminacion" CssClass="btn btn-secondary" Text="Cancelar" OnClick="btnCancelarEliminacion_Click" runat="server" />
                    </div>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
