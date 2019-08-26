<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Core.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        a.lbClass {
            cursor:pointer;
            color:blue;
            text-decoration:underline;
        }
        a.lbClass:hover {
            text-decoration: none;
            text-shadow: 1px 1px 1px #555;           
        }

        body {
            background-color:cornsilk;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Table runat="server" ID="table1">
               <asp:tablerow>
                   <asp:tablecell>Buscar cliente</asp:tablecell>
                   <asp:tablecell><asp:TextBox ID="SearchBox" runat="server" placeholder="Cedula de identidad"></asp:TextBox></asp:tablecell>
                   <asp:tablecell><asp:Button ID="SearchBtn" Text="Search" runat="server" OnClick="SearchBtn_Click"/></asp:tablecell>
               </asp:tablerow>
          </asp:Table>

            <asp:Label ID="clientLabel" runat="server" Font-Bold="true" Font-Size="Large" Font-Underline="true">Cliente</asp:Label>
             <asp:GridView ID="gridClientes" runat="server"></asp:GridView>

            <asp:Label runat="server" ID ="cuentasLabel" Font-Size="Large" Font-Bold ="true" Font-Underline="true">Cuentas</asp:Label><br />
            <asp:GridView runat="server" ID="cuentasGV"></asp:GridView>

             <asp:Label runat="server" ID ="prestamoLabel" Font-Size="Large" Font-Bold ="true" Font-Underline="true">Prestamos</asp:Label><br />
            <asp:GridView runat="server" ID="prestamoGV"></asp:GridView>

            <asp:Label runat="server" ID="movimientosLabel" Font-Size="Large" Font-Bold="true" Font-Underline="true">Movimientos</asp:Label> <br />
            <asp:GridView runat="server" ID="movimientosGV"></asp:GridView>


            <asp:Label runat="server" ID="optionsLabel" Font-Size="Large" Font-Bold="true" Font-Underline="true">Opciones</asp:Label><br />

            <asp:LinkButton id="NewCliente" runat="server" CssClass ="lbClass" OnClick="NewCliente_Click"
                OnClientClick="window.open('NewClient.aspx','NewClient');">
                Crear nuevo cliente
            </asp:LinkButton><br />

             <asp:LinkButton id="NewCuenta" runat="server" CssClass ="lbClass"  OnClientClick="window.open('NewAccount.aspx','NewAccount');" >
                Abrir cuenta
            </asp:LinkButton><br />

            <asp:LinkButton id="AbrirPrestamo" runat="server" CssClass ="lbClass" OnClick="AbrirPrestamo_Click" >
                Solicitar prestamo
            </asp:LinkButton><br />

            <asp:LinkButton ID="RealizarPagoPrestamo" runat="server" OnClick="RealizarPagoPrestamo_Click">
                Pagar prestamo
            </asp:LinkButton>
        </div>
    </form>
</body>
</html>
