<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="NuevoProducto.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.NuevoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>NuevoProducto</title>
    <link href="../Estilos/nuevoProducto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">

        <div class="container justify-content-center text-center mb-5">
            <br /> <br /> <br />
            <div class="From border border-primary mb-5 mt-5">
                <br />
                <h1>Nuevo Producto</h1>
                <br />
                <br />

                <div class="row g-3 text-center mb-3 ">
                    <div class="col-6 align-self-center">
                        <h3>ID del producto</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">
                        <asp:TextBox ID="txtIdP" Class="txt text-center" runat="server"></asp:TextBox>
                    </div>

                </div>

                <div class="row g-3 text-center mb-3 ">
                    <div class="col-6 align-self-center">
                        <h3>Nombre del producto</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">
                        <asp:TextBox ID="txtNombreP" Class="txt text-center" runat="server"></asp:TextBox>
                    </div>

                </div>

                <div class="row g-3 text-center mb-3">

                    <div class="col-6 align-self-center">
                        <h3>Descripción</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">
                        <asp:TextBox ID="txtDescripcion" Class="txt text-center" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>

                </div>

                <div class="row g-3 text-center mb-2">
                    <div class="col-6 align-self-center">
                        <h3>Precio</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">
                        <asp:TextBox ID="textPrecio" Class="txt text-center" runat="server"></asp:TextBox>
                    </div>

                </div>
                <br />
                <div class="row g-3 text-center">
                    <div class="col-6 align-self-center">
                        <h3>Imagen</h3>
                    </div>
                    <div class="col-6 align-self-center">
                        <asp:FileUpload ID="FileNC" runat="server" />
                    </div>
                </div>
                <br />
                <div class="row g-3 text-center">
                    <div class="col-6 align-self-center">
                        <h3>Categoria</h3>
                    </div>
                    <div class="col-6  align-self-center align-items-center">
                       <asp:TextBox ID="txtCategoria" Class="txt text-center" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <br />
                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Guardar</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn border border-white btn-lg" />
                    </div>
                </div>

                <br />

            </div>
        </div>

    </div>
</asp:Content>
