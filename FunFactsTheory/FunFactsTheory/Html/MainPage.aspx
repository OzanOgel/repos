<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="FunFactsTheory.Html.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Mukta:wght@200&family=Poppins:wght@200&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css"
        integrity="sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div id ="social"> 
            <font>funfacts&theory</font>
            <img src="../images/search.png" style="float:left; width:20px; margin-top:5px;"  />
            
            <img  src="../images/books-icon.png" style=" width:35px; float:right; margin-right:5px"  />
            <asp:TextBox ID="tb_search" runat="server"  CssClass="metinKutu">Dizi , Film Veya Kitap Ara</asp:TextBox>
            
        </div>
        <div id ="container">

            <header>
                <img id ="HeaderResim" src="../images/header.jpg" /></header>
           
            <section>

                <nav>
                    <ul>
                        <li>
                            <a href="">Diziler</a>
                            
                        </li>
                         <li>
                            <a href="">Filmler</a>
                            
                        </li>
                         <li>
                            <a href="">Kitaplar</a>
                            
                        </li>

                     </ul>

                </nav>
                <main>İçerikler Gelcek</main>

            </section>
            <footer>tüm hakları saklıdır &copy | 2023</footer>
        </div>
       
    </form>
</body>
</html>
