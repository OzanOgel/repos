<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonControls.aspx.cs" Inherits="AspNetControler.ButtonControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_tikla" runat="server" BackColor="Red" Text="tıkla" OnClick ="btn_tikla_Click" />
        </div>
    </form>
</body>
</html>
