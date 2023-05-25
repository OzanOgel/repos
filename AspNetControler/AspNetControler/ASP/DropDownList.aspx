<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="AspNetControler.ASP.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ders Seçiniz<br />
            <asp:DropDownList ID ="ddl_dersler" runat="server">
                <asp:ListItem Text ="seçiniz..." Value="0"></asp:ListItem>
                <asp:ListItem Text ="web yazılım uzmanlığı" Value="1"></asp:ListItem>
                <asp:ListItem Text ="MCPD" Value="2"></asp:ListItem>
                <asp:ListItem Text ="Frond-End Developer" Value="3"></asp:ListItem>

            </asp:DropDownList>
            <asp:Button ID="btn_goster" runat="server" Text="seç"  OnClick="btn_goster_Click"/>
            <br /> <br />
            <asp:Label ID ="lbl_secilen" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
