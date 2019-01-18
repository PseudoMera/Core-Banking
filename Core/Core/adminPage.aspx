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
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton id="NewCliente" runat="server" CssClass ="lbClass" OnClick="NewCliente_Click"
                OnClientClick="window.open('NewClient.aspx','NewClient');">
                Crear nuevo cliente
            </asp:LinkButton>

          

          <asp:Table runat="server" ID="table1">
               <asp:tablerow>
                   <asp:tablecell>Buscar cliente</asp:tablecell>
                   <asp:tablecell><asp:TextBox ID="SearchBox" runat="server" placeholder="Cedula de identidad"></asp:TextBox></asp:tablecell>
                   <asp:tablecell><asp:Button ID="SearchBtn" Text="Search" runat="server" OnClick="SearchBtn_Click"/></asp:tablecell>
               </asp:tablerow>
          </asp:Table>

            <asp:DataGrid ID="gridClientes" runat="server"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
