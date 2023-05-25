<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TabloOlusturma.aspx.cs" Inherits="AspNetControler.HTML.TabloOlusturma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border ="1" width ="700" cellpadding ="0" cellspacing ="0">
            <tr>
                <th colspan ="5"> Ogrenci Listesi</th>
            </tr>
            <tr>
                <th width="80">resim </th>
                <th>ID</th>
                <th>Isim</th>
                <th>Soyisim</th>
                <th>Ilçe</th>
            </tr>
            <tr>
                <td>
                    <img src="Images/ssad.jpeg" width="80" /></td>
                <td>1</td>
                <td>Hasan Hüseyin</td>
                <td>Badak</td>
                <td>Tepebaşı</td>
            </tr>
            <td>
                <img src="Images/ssad.jpeg" width="80" /></td>
            <td>2</td>
            <td>Anıl</td>
            <td>Çavuş</td>
            <td>Tepebaşı</td>

        </table>
        <br />
        </table>
<table border="1" width="700" cellspacing="0" cellpadding="5">
            <tr>
                <th colspan="5">Satış Listesi</th>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td>2020</td>
                <td>2021</td>
                <td>2022</td>
            </tr>
            <tr>
                <td rowspan="3">Renault</td>
                <td>Ankara</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
            <tr>
                <td>İstanbul</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
            <tr>
                <td>İzmir</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
            <tr>
                <td rowspan="3">Ford</td>
                <td>Ankara</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
            <tr>
                <td>İstanbul</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
            <tr>
                <td>İzmir</td>
                <td>50</td>
                <td>60</td>
                <td>120</td>
            </tr>
        </table>
    </form>
</body>
</html>
