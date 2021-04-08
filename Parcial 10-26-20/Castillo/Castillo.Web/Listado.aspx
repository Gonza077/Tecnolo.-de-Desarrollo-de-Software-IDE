<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Castillo.Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvListado" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Clave" HeaderText="Clave" />
                    <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo de Usuario" />
                    <asp:BoundField DataField="UltimoIngreso" HeaderText="Ultimo Ingreso" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
