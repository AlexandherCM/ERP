<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoAGC.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Estilos/Login.css" rel="stylesheet" />
    <link href="Estilos/Recursos/LOGO CUBO.png" rel="icon" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <nav class="navbar justify-content-center">
                <div class="container-fluid justify-content-center ">
                    <a class="navbar-brand justify-content-center" href="Login.aspx">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Vistas/Estilos/Recursos/LOGO CUBO.png" 
                            alt="Logo" width="58" height="48" class="d-inline-block align-text-center"/>
                        <font>AGC COMERCIAL</font>
                    </a>
                </div>
            </nav>

            <div class="Fondo">

                <div class="container">
                    <div class="Login">
                        <section class="vh-100 gradient-custom">
                            <div class="container py-5 h-100">
                                <div class="row d-flex justify-content-center align-items-center h-100">
                                    <div class="col-12 col-md-8 col-lg-6 col-xl-5">
                                        <div class="card text-white" style="border-radius: 1rem;">
                                            <div class="card-body text-center">

                                                <div class="mb-md-5 mt-md-4 pb-5">

                                                    <h2 class="fw-bold mb-2 text-uppercase">Login</h2>
                                                    <p class="text-white-50 mb-5">Por favor ingrese usuario y contraseña!</p>

                                                    <div class="form-outline form-white mb-4">
                                                        <asp:TextBox ID="txtEmail" runat="server" class="form-control form-control-lg textBox"></asp:TextBox>
                                                        <label class="form-label" for="typeEmailX" style="padding-top: 0.5em;">Correo</label>
                                                    </div>

                                                    <div class="form-outline form-white mb-4">
                                                        <asp:TextBox ID="txtContraseña" runat="server" class="form-control form-control-lg textBox" TextMode="Password"></asp:TextBox>
                                                        <label class="form-label" for="typePasswordX" style="padding-top: 0.5em;">Contraseña</label>
                                                    </div>

                                                    <p class="small mb-5 pb-lg-2"><a class="text-white-50" href="#!">Olvidaste tu contraseña?</a></p>
                                                    <asp:Button ID="BtnIniciar" runat="server" Text="Iniciar sesión" class="btn btn-outline-light btn-lg px-5" OnClick="BtnIniciar_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>

                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
