<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site1.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Tekrar2.pages.AnaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style ="clear:both;"></div>
    <div><div class="contanier">
       <asp:ListView ID="lv_anasayfa" runat="server" >
           <LayoutTemplate>
               <table border="1">
                   <tr>
                       <th>No</th>
                       <th>Adı</th>
                       <th>Seçenekler</th>
                   </tr>
                   <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
               </table>
           </LayoutTemplate>
           <ItemTemplate>
               <tr>
                   <td><%# Eval("ID") %></td>
                   <td><%# Eval("Isim") %></td>
                   <td>
                       <a href="#">Detay</a>
                       <asp:LinkButton ID="lbtn_sil" runat="server" OnClick="lbtn_sil_Click">SİL</asp:LinkButton>

                   </td>
               </tr>
           </ItemTemplate>
       </asp:ListView>
        </div>
    </div>

</asp:Content>
