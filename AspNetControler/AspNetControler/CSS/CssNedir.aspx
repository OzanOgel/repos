<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CssNedir.aspx.cs" Inherits="AspNetControler.CSS.CssNedir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Normal Yazı <br />
            <label>Label iLE nORMAL yAZI</label> <br />
            <span>Span ile Normal yAZI</span><br />
            <hr />
            <label style="color:red">Css İle Renklendirildi(renk adı)</label> <br />
            <label style="color:#FF46F1">Renk Kodu ile Renk Değiştirildi</label><br />
            <label style ="color:darkred; font-size:20pt">Yazı Boyutu Değiştirildi</label><br />
            <label style ="color:darkred; font-family:'Comic Sans MS'; font-size:30pt">Yazı Fontu Değiştirildi</label><br />
        </div>
    </form>
</body>
</html>
