<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullanıcıGiriş.aspx.cs" Inherits="AspNetControler.ASP.KullanıcıGiriş" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/css/KullaniciGiriş.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="panel">
            <div class="row">
                Kullanıcı Adı<br />
                <asp:TextBox ID="tb_kullaniciAdi" runat="server" CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="row">
                Şifre<br />
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" TextMode="Password"></asp:TextBox>
            </div>
             <div class="row">
                <a href="#" style="float:right">Şifremi Unuttum</a>
            </div>
            <div style="clear:both"></div>
            <div class="row">
                <asp:LinkButton ID="btn_giris" runat="server"  CssClass="buton" OnClick="btn_giris_Click">Kullanıcı Giriş</asp:LinkButton>
            </div>

            <div class="row">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
