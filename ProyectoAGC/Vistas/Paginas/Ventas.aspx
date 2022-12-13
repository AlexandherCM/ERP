<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Ventas</title>
    <link href="../Estilos/Venta.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo p-3">
        <div class="Container mb-5 mt-5 p-3">
            <div class="row g-3 text-center justify-content-center mt-5 mb-5">
                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center mt-5 mb-5" style="width: 45vh;">
                    <div class="card mt-5 mb-5">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Ventas.jpg" alt="Ventas" class="card-img-top align-self-center"
                            Style="height: 22vh; width: 100%;" />
                        <div class="card-body">
                            <h5 class="card-title"><b>Cotizaciones</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="btnCotizaciones" runat="server" Text="Ir" class="btn btn-lg border border-dark bg-light text-dark" />
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-6 align-self-center justify-content-center mt-5 mb-5" style="width: 45vh;">
                    <div class="card mt-5 mb-5">
                        <asp:Image runat="server" ImageUrl="~/Vistas/Estilos/Recursos/Ventas.jpg" alt="Ventas" class="card-img-top align-self-center"
                            Style="height: 22vh; width: 100%;" />
                        <div class="card-body">
                            <h5 class="card-title"><b>Cotizaciones</b></h5>
                            <p class="card-text"></p>
                            <asp:Button ID="Button1" runat="server" Text="Ir" class="btn btn-lg border border-dark bg-light text-dark" />
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
