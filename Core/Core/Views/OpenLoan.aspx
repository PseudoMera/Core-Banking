<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoanPayment.aspx.cs" Inherits="Core.LoanPayment" %>

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
                    <td>Monto</td>  
                     <td> <asp:TextBox ID="DeudaBox" runat="server"></asp:TextBox></td>  
                </tr>   
                
                <tr>
                    <td>Plazo</td>
                    <td><asp:TextBox ID ="plazoBox" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>cedula</td>
                    <td>
                        <asp:TextBox ID="cedulaBox" runat="server"></asp:TextBox>"
                    </td>
                </tr>

                <tr>
                    <td>  
                        <asp:Button ID="abrirBtn" runat="server" Text="Abrir" OnClick="abrirBtn_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>
    </form>
</body>
</html>
