<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/BarraNavegacion.Master" AutoEventWireup="true" CodeBehind="NuevoProveedor.aspx.cs" Inherits="ProyectoAGC.Vistas.Paginas.NuevoProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>NuevoProveedor</title>
    <link href="../Estilos/NuevoProveedor.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container justify-content-center text-center">
            <br />
            <br />
            <br />
            <br />
            <div class="From ">
                <br />
                <h1><b>Nuevo Proveedor</b></h1>
                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>RFC</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtRFC" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Empresa</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtEmpresa" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Razón Social</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtRSocial" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Contacto</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtContacto" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Categoria</h3>
                    </div>

                    <div class="col-6 align-self-center text-center">
                       <asp:TextBox ID="textCategoria" runat="server" Class="TextBox"></asp:TextBox>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Giro</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtgiro" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Teléfono</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtTel" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Correo</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtEmail" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />


                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Dirección</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtDirec" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

                <br />

                <div class="row g-3 text-center">

                    <div class="col-6 align-self-center">
                        <h3>Zona</h3>
                    </div>

                    <div class="col-6 align-self-center align-items-center">

                        <div class="global">
                            <div class="mensajes">
                                <div class="texto justify-content-center align-self-center">
                                    <asp:TextBox ID="txtZona" runat="server" Class="TextBox"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>

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
            <br />
        </div>
    </div>
</asp:Content>

