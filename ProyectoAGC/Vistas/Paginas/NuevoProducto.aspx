<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="NuevoProducto.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.NuevoProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>NuevoProducto</title>
    <link href="../Estilos/NuevoProducto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">

        <div class="container justify-content-center text-center">
            <br />
            <br />
            <br />
            <br />
            <div class="From border border-primary mb-5 mt-5">
                <br />
                <h1>Nuevo Producto</h1>
                <br />
                <br />


                <div class="row g-3 text-center ">

                    <div class="col-6 align-self-center">
                        <h3>Producto</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">

                        <div id="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="TxtProducto" runat="server"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Descripción</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">

                        <div id="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtPDesc" runat="server"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Precio</h3>
                    </div>
                    <div class="col-6 align-self-center align-items-center">

                        <div id="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtPPrecio" runat="server"></asp:TextBox>
                                </div>

                            </div>
                        </div>
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
                        <h3>Área</h3>
                    </div>
                    <div class="col-6 align-self-center">
                        <select class="form-select" aria-label="Default select example" style="width: 85%;">
                            <option selected>Área</option>
                            <option value="1">One</option>
                            <option value="2">Two</option>
                            <option value="3">Three</option>
                        </select>
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
