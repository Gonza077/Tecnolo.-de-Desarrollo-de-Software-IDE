<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Castillo.Web.UsuarioWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario:
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Button ID="btnRecuperar" runat="server" OnClick="btnRecuperar_Click" Text="Recuperar" />
            <br />
            <br />
            <asp:Label ID="lblDatos" runat="server" Text="Label"></asp:Label>
            <br />
            
        </div>
    </form>
</body>
</html>
