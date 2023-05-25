<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownDataBound.aspx.cs" Inherits="AspNetControler.ASP.DropDownDataBound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kategori Seçiniz:
            <br />
            <asp:DropDownList ID="ddl_kategoriler" runat="server" AppendDataBoundItems="true"
                OnSelectedIndexChanged="ddl_kategoriler_SelectedIndexChanged"
                AutoPostBack="true"
                
                
                >
                
                <asp:ListItem Text="Seçiniz..." Value="0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID ="lbl_secilen" runat="server"></asp:Label>
            
        </div>
    </form>
</body>
</html>
