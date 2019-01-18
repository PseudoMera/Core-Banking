<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="Core.NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

      <style>
             .body {
                 background-color:ghostwhite;
             }

             .table {
                font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
                border-collapse: collapse;
                 width: 25%;
                 background-color:aliceblue;
               }

             h2 {
                 text-align:center;
             }                                  
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Apertura de cuenta</h2>
            <table class="table"  align="center">                          
                <tr>  
                    <td>Tipo</td>  
                    <td>  
                        <asp:TextBox ID="tipoBox" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Saldo</td>  
                     <td> <asp:TextBox ID="saldoBox" runat="server"></asp:TextBox></td>  
                </tr>   
                <tr>
                    <td>  
                        <asp:Button ID="createBtn" runat="server" Text="Crear" OnClick="createBtn_Click" />  
                    </td>  
                </tr>  

                <tr>
                    <td>cedula</td>
                    <td>
                        <asp:TextBox ID="cedulaBox" runat="server"></asp:TextBox>"
                    </td>
                </tr>
            </table>  
        </div>
    </form>
</body>
</html>
