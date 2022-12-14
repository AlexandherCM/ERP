<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/Estandar.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.Menu" %>

<%-- Cabeza de pagina maestra --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Menu</title>
    <link href="../Estilos/Men.css" rel="stylesheet" />
    <%-- Cuerpo de pagina maestra --%>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /> <br /> <br />
    <%-- Cuerpo --%>
    <div class="Fondo">
        

        <div class="container-fluid contenedor">
            <br />
            <br />
            <div class="row g-3 text-center justify-content-center">

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Ventas.jpg" alt="Ventas" class="card-img-top align-self-center" 
                            style="height: 22vh; width: 100%;"/>
                        <div class="card-body">
                            <h5 class="card-title"><b>Ventas</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnVentas" runat="server" Text="Ir" class="btn btn-secondary btn-lg" OnClick="btnVentas_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Compras.jpg" alt="Ventas" class="card-img-top align-self-center" 
                            style="height: 22vh; width: 100%;"/>
                        <div class="card-body">
                            <h5 class="card-title"><b>Compras</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnCompras" runat="server" Text="Ver" class="btn btn-secondary btn-lg" />
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/LOGOS AGC - LINEA DE PRODUCTOS.png" alt="logoAGC3" 
                            class="card-img-top align-self-center"  style="height: 28vh; width: 65%;"/>
                        <div class="card-body">
                            <h5 class="card-title"><b> AGC Comercial</b></h5>
                        </div>
                    </div>
                </div>

            </div>
            <br />



            <div class="row g-3 text-center justify-content-center">

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Catalogo.jpg" alt="Catálogo" class="card-img-top align-self-center" 
                            style="height: 22vh; width: 100%;" />
                        <div class="card-body">
                            <h5 class="card-title"><b>Catálogos</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnCatalogos" runat="server" Text="Ver" class="btn btn-secondary btn-lg" OnClick="btnCatalogos_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Finanzas.jpg" alt="Finanzas" class="card-img-top align-self-center" 
                            style="height: 22vh; width: 100%;"/>
                        <div class="card-body">
                            <h5 class="card-title"><b>Finanzas</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnFinanzas" runat="server" Text="Ver" class="btn btn-secondary btn-lg" OnClick="btnFinanzas_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center" style="width: 45vh;">
                    <div class="card">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Users.jpg" alt="Finanzas" class="card-img-top align-self-center" 
                            style="height: 22vh; width: 100%;" />
                        <div class="card-body">
                            <h5 class="card-title"><b>Usuarios</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="BtnUsuarios" runat="server" Text="Editar" class="btn btn-secondary btn-lg" />
                        </div>
                    </div>
                </div>

            </div>

            <br />
        </div>


    </div>
</asp:Content>
