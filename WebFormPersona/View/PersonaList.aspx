<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonaList.aspx.cs" Inherits="WebFormPersona.View.PersonaList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PERSONAS</div>
        <asp:GridView ID="GridView1" runat="server" >
            <Columns>
                <asp:ButtonField CommandName="Editar" Text="Editar" />
                <asp:ButtonField  CommandName="Eliminar" Text="Eliminar"/>
            </Columns>
        </asp:GridView>
    <asp:Button ID="Create" runat="server" OnClick="Create_Click" Text="Crear Persona" />
    </form>    
</body>
</html>
