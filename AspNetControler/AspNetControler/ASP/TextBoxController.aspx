<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxController.aspx.cs" Inherits="AspNetControler.ASP.TextBoxController" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            STANDART TEXBOX =
            <asp:TextBox ID="TB_isim" runat="server"></asp:TextBox>
            <br />  <br />
            <asp:Button ID="BTN_yazdir" runat="server" OnClick="BTN_yazdir_Click" Text="yazdır" />
            <asp:Label ID="lbl_isim" runat="server"></asp:Label>
            <asp:TextBox ID ="tb_sinirli" runat="server" MaxLength="8"></asp:TextBox>
            <asp:TextBox ID="tb_şifre" runat="server" TextMode="Password"></asp:TextBox>
            <br />
         </div>
    </form>
</body>
</html>
