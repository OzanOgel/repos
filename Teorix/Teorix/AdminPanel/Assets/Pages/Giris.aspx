<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Teorix.AdminPanel.Assets.Pages.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/YoneticiCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div ıd="deneme">
            
        </div>
        <div class="contanier">
             <div style="margin-top:25px;">
                    <h3 style="color:#002333">Yonetici Paneli Giriş</h3>
                </div>
            <div style="margin-top:1px">
           <asp:TextBox ID="grs_tb" runat="server" CssClass="textbox" placeholder="Mail Adresiniz"></asp:TextBox>
                </div>
            <br />
            <div style="margin-top:1px">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" placeholder="Şifreniz" TextMode="Password"></asp:TextBox>
                </div>
            <br />
            <div style="margin-top:1px">
            <asp:LinkButton ID="grs_lb" runat="server" CssClass="lb" OnClick="grs_lb_Click" Width="286px">
                Giriş 
            </asp:LinkButton>
                </div>

        </div>
    </form>
</body>
</html>
