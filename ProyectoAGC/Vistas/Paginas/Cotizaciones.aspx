<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="Cotizaciones.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.Cotizaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cotizaciones</title>
    <link href="../Estilos/cotizaciones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container text-center text-light">
            <br />
            <h1>Cotizaciones</h1>
            <p>Para hacer la búsqueda de una cotización puede ser mediante el nombre del cliente o por el folio</p>

            <br />
            <div class="row g-3 text-center ">
                <div class="col-4 align-self-center">
                    <h4>Nombre del cliente</h4>
                </div>
                <div class="col-7 align-self-center">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-9">
                                <asp:TextBox ID="textClinete" placeholder="Cliente" Class="form-control textClient" runat="server" TextMode="Search"></asp:TextBox>
                            </div>
                            <div class="col-3 justify-content-start">
                                <asp:ImageButton ID="btnBuscarCliente" Class="Search" runat="server" ImageUrl="~/Vistas/Estilos/Recursos/magnifying-glass-solid.svg"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row g-3 text-center ">
                <div class="col-4 align-self-center">
                    <h4>Folio</h4>
                </div>
                <div class="col-7 align-self-center">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-9">
                                <asp:TextBox ID="textFolio" placeholder="Folio" Class="form-control textClient" runat="server" TextMode="Search"></asp:TextBox>
                            </div>
                            <div class="col-3 justify-content-start">
                                <asp:ImageButton ID="ImageButton1" Class="Search" runat="server" ImageUrl="~/Vistas/Estilos/Recursos/magnifying-glass-solid.svg"  />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <%-- GridView --%>
            <div class="row g-3 text-center border border-primary">
                <asp:GridView ID="GridCotizaciones" runat="server"></asp:GridView>
            </div>
            <br />
            <div class="row g-3 justify-content-center text-center">
                <a href="NuevaCotizacion.aspx"><i class="fa-solid fa-circle-plus"></i></a>
                <h5>Nueva Cotización</h5>
            </div>
        </div>

    </div>
</asp:Content>
