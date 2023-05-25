<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListeGorunumleri.aspx.cs" Inherits="AspNetControler.HTML.ListeGorunumleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <h3>Sıralı Liste</h3>
        <ol>
            <li>Ankara</li>
            <li>İstabul</li>
            <li>İzmir</li>
            <li>Eskişehir</li>
        </ol>
        <h3>Farklı Madde İşaretl Sıralı Liste</h3>
        <ol type ="A">
            <li>Ankara</li>
            <li>İstabul</li>
            <li>İzmir</li>
            <li>Eskişehir</li>
            <h3>İç İçe Listeler</h3>
            <ol>
                <li>Ankara</li>
            <li>İstabul</li>
            <li>İzmir</li>
            <li>Eskişehir</li>
                <ol type ="A">
                    <li>Tebebaşı</li>
                    <li>Odunpazarı</li>

                </ol>
            </ol>
        </ol>
    </form>
</body>
</html>
