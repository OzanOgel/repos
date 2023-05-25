<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seciciTurleri.aspx.cs" Inherits="AspNetControler.CSS.seciciTurleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body
        {
            font-family:Calibri;

        }
        label
        {
            font-size:20pt;
        }
        h1,h2,h3,h4,h5,h6
        {
            color:green;

        }
        .maviyazi
        {
            color:blue;
            font-size:30pt;
        }
        #LBT_İSİM
        {
            color:blueviolet
        }
          
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <label>Etiket Seçici</label>
            <h1>Deneme</h1>
            <hr />
            <span class ="maviyazi">sınıf seçici</span>
            <span id ="LBT_İSİM">ID secici</span>
            

        </div>
    </form>
</body>
</html>
