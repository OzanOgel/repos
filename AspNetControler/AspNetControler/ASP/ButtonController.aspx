<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonController.aspx.cs" Inherits="AspNetControler.ASP.ButtonController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID ="btn_tikla" Text="tıkla" runat="server" OnClick="btn_tikla_Click" />
            <asp:Button ID ="Button_gonder" Text="gönder" runat="server" OnClick="Button_gonder_Click" />
            <asp:LinkButton ID ="lbtn_tikla" runat="server" OnClick ="lbtn_tikla_Click">git</asp:LinkButton>
            <asp:LinkButton ID ="lbtn_gidiyom_click" runat ="server" OnClick="lbtn_gidiyom_click_Click">Ben gidiyom</asp:LinkButton>
        </div>
    </form>
</body>
</html>
