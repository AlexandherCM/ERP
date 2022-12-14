<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="Catalogos.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.Catalogos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Catalogos</title>
    <link href="../Estilos/Catalogos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
                <div class="container text-center mt-5">
                    <h1>
                        <br />
                        <b>Catálogos</b>

                    </h1>
                    <br />
                    <div class="row g-3 justify-content-center text-light mt-5">

                        <div class="col-12 col-md-4 col-lg-4 align-self-center justify-content-center text-light" style="width: 40vh;">
                                <div class="card c">
                                    <img src="../Estilos/Recursos/chair.jpg" alt="Ventas" class="card-img-top align-self-center" style="height: 22vh; width: 100%;" />
                                    <div class="card-body">
                                        <h5 class="card-title"><b>Productos</b></h5>
                                        <asp:Button ID="btnProductos" runat="server" Text="Aceptar" Class="boton p-2" OnClick="btnProductos_Click" />
                                    </div>
                                </div>
                        </div>

                        <div class="col-12 col-md-4 col-lg-4 align-self-center justify-content-center" style="width: 40vh;">
                                <div class="card c">
                                    <img src="../Estilos/Recursos/Cliente.jpg" alt="Ventas" class="card-img-top align-self-center" style="height: 22vh; width: 100%;" />
                                    <div class="card-body">
                                        <h5 class="card-title"><b>Clientes</b></h5>
                                        <asp:Button ID="btnClientes" runat="server" Text="Aceptar" Class="boton p-2" OnClick="btnClientes_Click" />
                                    </div>
                                </div>
                        </div>

                        <div class="col-12 col-md-4 col-lg-4 align-self-center justify-content-center" style="width: 40vh;">
                                <div class="card c">
                                    <img src="../Estilos/Recursos/Proveedoor.jpg" alt="Ventas" class="card-img-top align-self-center" style="height: 22vh; width: 100%;" />
                                    <div class="card-body">
                                        <h5 class="card-title"><b>Proveedores</b></h5>
                                        <asp:Button ID="btnProveedores" runat="server" Text="Aceptar" Class="boton p-2" OnClick="btnProveedores_Click" />
                                    </div>
                                </div>
                        </div>

                    </div>

                    <br />
                    <br />
                    <br />

                </div>


            </div>
</asp:Content>
