<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdministracionProducto.aspx.cs" Inherits="TPFinalNivel3MalerbaMatias.AdministracionProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ms-3 me-3">
        <div class="mt-5 mb-5 offset-md-2">
            <h3>Administrar Productos</h3>
        </div>
        <div>
            <div class="row">
                <div class="col-md-8 offset-md-2 mb-3">
                    <asp:GridView ID="gridAdministrarProductos" CssClass="table" DataKeyNames="Id" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gridAdministrarProductos_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="Código" DataField="Codigo" />
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                            <asp:BoundField HeaderText="Categoría" DataField="Categoria.Descripcion" />
                            <asp:BoundField HeaderText="Precio" DataField="Precio" />
                            <asp:CommandField ShowSelectButton="true" SelectText="📝" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="offset-md-2">
                    <asp:Button ID="btnAgregarProducto" Text="Agregar Producto" CssClass="btn btn-primary" OnClick="btnAgregarProducto_Click" runat="server" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
