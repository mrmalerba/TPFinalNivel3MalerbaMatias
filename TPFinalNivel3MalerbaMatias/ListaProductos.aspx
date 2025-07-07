<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.ListaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ms-3 me-3">
        <div class="row mt-5 mb-5 ms-5">
            <h3 class="ms-5">Listado de Productos</h3>
        </div>
        <div class="row row-cols-1 row-cols-md-3 g-4 ps-5 pe-5 ms-5 me-5">
            <asp:Repeater runat="server" ID="ProductCatalog">
                <ItemTemplate>
                        <div class="col">
                            <div class="card">
                                <div class="text-center" height="400px">
                                    <img src="<%#Eval("ImagenUrl") %>" class="img-fluid" alt="<%#Eval("Codigo") + "_Imagen" %>">
                                </div>
                                <div class="card-body">
                                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                    <p class="card-text"><%#Eval("Descripcion") %></p>
                                    <a href="DetalleProducto.aspx?Id=<%#Eval("Id")%>" class="btn btn-primary">Ver detalles</a>
                                    <asp:Button ID="BtnAgregar" CssClass="btn btn-primary" Text="Agregar a favoritos" runat="server" OnClick="BtnAgregar_Click" CommandArgument='<%#Eval("Id")%>' CommandName="AgregarArticulo" />
                                </div>
                            </div>
                        </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>


</asp:Content>
