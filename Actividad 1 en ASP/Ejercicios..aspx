<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicios..aspx.cs" Inherits="Actividad_1_en_ASP.Ejercicios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicios ASP.NET - Contadores</title>
    <style>
    body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 20px; background-color: #e9ecef; color: #343a40; }
    .container {
        border: 5px solid rgba(0,0,0,0.08);
        background-color: #d1d1d1;
        padding: 30px;
        border-radius: 8px;
        max-width: 500px;
        margin: 40px auto;
        text-align: center;
        box-shadow: 0 5px 15px rgba(0,0,0,0.08);
    }
    h1 {
        color: #074f12;
        margin-bottom: 20px;
        font-size: 2.5em;
        border-bottom: 2px solid #074f12;
        padding-bottom: 10px;
        display: inline-block; /* Para que el borde se ajuste al texto */
    }
    .mensaje {
        font-size: 1em;
        color: #0b9620; /* Verde para mensaje de éxito/primera carga */
        font-weight: bold;
    }
    .mensaje.recarga {
        color: #a50a0a; /* Rojo para mensaje de recarga */
    }
    .contador {
        font-size: 1.1em;
        color: #6c757d;
        line-height: 4.5;
        background-color: #f8f9fa;
        border: 1px solid #000000;
        padding: 15px;
        border-radius: 5px;
   
    }
    .btn {
        padding: 12px 28px;
        background-color: #343a40; /* Morado */
        color: white;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        font-size: 1.1em;
        margin-top: 30px;
        transition: background-color 0.3s ease, transform 0.2s ease;
    }
    .btn:hover {
        background-color: #074f12;
        transform: translateY(-5px);
    }
    .btn:active {
        transform: translateY(0);
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Contador Web</h1>
             <br />
            <asp:Label ID="lblMensajeCarga" runat="server" CssClass="mensaje"></asp:Label>
            <br />
            <asp:Label ID="lblContadorApp" runat="server" CssClass="contador" Text="Usuarios en la aplicación: 0"></asp:Label>
            <br />
            <asp:Label ID="lblContadorPagina" runat="server" CssClass="contador" Text="Esta página ha sido recargada: 0 veces"></asp:Label>
            <br />
            <asp:Button ID="btnRecargar" runat="server" Text="Recargar Página" CssClass="btn" />
        </div>
    </form>
</body>
</html>