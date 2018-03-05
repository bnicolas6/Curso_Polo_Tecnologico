<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Curso.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #div2 {
            width: 477px;
            margin-left: 150px;
        }
        #div1 {
            height: 14px;
            width: 476px;
            margin-left: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Boton" runat="server" Text="Login" OnClick="Boton_Click" />
        <asp:TextBox ID="TextUser" runat="server" style="margin-left: 100px" Width="237px"></asp:TextBox>
        <asp:TextBox ID="TextPassword" runat="server" Width="232px"></asp:TextBox>
    </div>
    <div id="div1" runat="server"></div>
    <div id="div2" runat="server"></div>
    </form>
</body>
</html>
