<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defauld.aspx.cs" Inherits="YatanBilgisayar.Defauld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yatan Computer</title>
    <link href="Assets/Css/MainStyle.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@200&display=swap"
        rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="HeadImage">
            <div class="BoxContanier">
                <img src="Assets/PageImages/stokheader-web.png" />
            </div>
            
        </div>
        <div class ="BoxContanier">
            <ul class ="BoxContanier">
                <ul class ="TopMenu">
                    <a href=""><li>Web'e Özel</li></a>
                     <a href=""><li>Yeni</li></a>
                     <a href=""><li>Hazır Sistem</li></a>
                     <a href=""><li>Pc Toplama</li></a>
                     <a href=""><li>Outlet</li></a>
                     <a href=""><li>Sipariş Takibi</li></a>
                     <a href=""><li>İade</li></a>
                     <a href=""><li>Mağazalar</li></a>
                     <a href=""><li>Bize Ulaşın</li></a>
                     <a href=""><li>Gaming</li></a>
                </ul>


        </div>
        <div style="clear:both"></div>
        <div class="BoxContanier">
            <img src="Assets/PageImages/logo2.jpg" class ="Logo" />
            <asp:TextBox ID ="tb_search" runat ="server" CssClass="searchBox" placeholder="Aramak İstediğiniz ürün adını giriniz"></asp:TextBox>
            <asp:LinkButton ID ="lbtn_search" runat="server" CssClass ="SearchButton">
<img src="Assets/PageImages/search.png" />
            </asp:LinkButton>
            <a href="" class="LoginButton" style ="margin-left:20px;"><img src="Assets/PageImages/icons8-shopping-cart-30.png" />Sepetim </a>
            
            <a href=""class="LoginButton"> <img src="Assets/PageImages/icons8-user-30.png" />Giriş Yap</a>
            

        </div>
        <div style ="clear:both"></div>
        <div class="mainMenu">
            <div class ="BoxContanier">
                <ul>
                    <a href ="">
                        <li >Telefon</li>
                    </a>
                    <a href ="">
                        <li >Bilgisayar</li>
                    </a>
                    <a href ="">
                        <li >Tv,Ev elektroniği</li>
                    </a>
                    <a href ="">
                        <li >Bilgisayar Parçaları</li>
                    </a>
                    <a href ="">
                        <li >Foto,Kamera</li>
                    </a>
                    <a href ="">
                        <li >ofis,kırtasiye</li>
                    </a>
                    <a href ="">
                        <li >Aksesuar</li>
                    </a>
                    <a href ="">
                        <li >oyun,hobi</li>
                    </a>
                    <a href ="">
                        <li >ev,mutfak</li>
                    </a>
                    <a href ="">
                        <li >Kişisel bakim</li>
                    </a>
                    <a href ="">
                        <li >Soğutma,Isıtma</li>
                    </a>
                </ul>

            </div>

        </div>
        <div class ="BoxContanier">
            <img src="Assets/PageImages/slider1.png" />
        </div>
        <div class="AVO">
            <div class="BoxContanier">
            <img src="Assets/PageImages/evo.png" />
                </div>
        </div>
    </form>
</body>
</html>
