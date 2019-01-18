<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewClient.aspx.cs" Inherits="Core.NewClient" %>

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

<body class="body" >
    <form id="form1" runat="server">
        <div>
            <h2>Registro de cliente</h2>
            <table class="table"  align="center">  
                <tr>
                </tr>
                <tr>  
                    <td>Nombre</td>  
                    <td>  
                        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Apellido</td>  
                     <td> <asp:TextBox ID="lnameBox" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>Pais</td>  
                    <td>  
                        <asp:TextBox ID="countryBox" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Ciudad</td>  
                    <td>  
                        <asp:TextBox ID="cityBox" runat="server"></asp:TextBox> 
                    </td>  
                </tr>  
                <tr>  
                    <td>Genero</td>  
                    <td>  
                        <asp:RadioButtonList ID="genderListBox" runat="server">  
                            <asp:ListItem>Hombre</asp:ListItem>  
                            <asp:ListItem>Mujer</asp:ListItem>  
                        </asp:RadioButtonList>  
                    </td>  
               </tr>  
                <tr>  
                    <td>Direccion</td>  
                    <td>  
                        <asp:TextBox ID="dirBox" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
            
            <tr>
                <td>Telefono Residencial</td>
                <td>
                    <asp:TextBox ID="telResbox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Telefono Celular</td>
                <td>
                    <asp:TextBox ID="telCelBox" runat="server"></asp:TextBox>
                </td>
               
            </tr>

                <tr>
                    <td>Cedula de identidad</td>
                    <td><asp:TextBox ID="idBox" runat="server"></asp:TextBox></td>
                </tr>

                <tr>  
                    <td>  
                        <asp:Button ID="createBtn" runat="server" Text="Crear" OnClick="createBtn_Click"  />  
                    </td>  
                </tr>  
            </table>         

        </div>
    </form>
</body>
</html>
