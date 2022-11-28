<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="OrdenVenta.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.OrdenVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>OrdenVenta</title>
    <link href="../Estilos/OrdenVenta.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container-fluid text-center text-light">
            <br /> <br /> <br /> <br />
            <h1>Orden de venta</h1>
            <br />
            <div class="row border border-danger">
                <%-- GridView --%>
                <asp:GridView ID="OrdenV" runat="server"></asp:GridView>
                <br />
            </div>
            <br />
            <div class="row">
                <div class="col">
                    <asp:ImageButton ID="DescargarOrden" Class="Descargar" runat="server" ImageUrl="~/Vistas/Estilos/Recursos/download-solid.svg" />
                    <h5>Descargar</h5>
                </div>
                <div class="col">
                    <asp:ImageButton ID="EmailOrden" Class="Email" runat="server" ImageUrl="~/Vistas/Estilos/Recursos/envelope-regular.svg" />
                    <h5>Email</h5>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
