<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="SecondWebAppWithBoolstrap.AdminPanel.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card mt-3">
        <div class="card-header">
            <h4 class="card-title" style="text-align:center">Ürün Ekle</h4>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">İsim</label>
                        <asp:TextBox ID="lbl_name" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Kategori</label>
                        <asp:DropDownList ID="ddl_Categories" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Tedarikçi</label>
                        <asp:DropDownList ID="ddl_Suppliers" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Barkod Numarası</label>
                        <asp:TextBox ID="tb_barkod" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Stok Miktarı</label>
                        <asp:TextBox ID="tb_Stok" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-4">
                     <div class="mb-3 mt-3">
                        <label class="form-label">Güvenlik Stoğu</label>
                        <asp:TextBox ID="tb_guvenlik" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Fiyat</label>
                        <asp:TextBox ID="tb_fiyat" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                <div class="col-md-8">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Resim Seçiniz</label>
                        <asp:FileUpload ID="fu_image" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <d
                
                   
        </div>
            <div class="row">
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Satış Durum</label>
                        <asp:CheckBox ID="cb_discontiuned" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="ContentPlaceHolder1_cb_discontiuned">Satıştan Kaldır</label>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Hızlı Ürün</label>
                        <asp:CheckBox ID="cb_FastProduct" runat="server" CssClass="form-check-input" />
                        <label class="form-check-label" for="ContentPlaceHolder1_cb_FastProduct">Hızlı Satışa Ekle</label>
                    </div>
                </div>
            </div>

        <div class="card-footer">
           
            <asp:LinkButton ID="lbtn_create" runat="server" CssClass="btn btn-success float-end" OnClick="lbtn_create_Click">Ürün Ekle</asp:LinkButton>
             <a href="#" class="link-info float-end m-lg-2">Ürünler Listesine Git</a>
        </div>

    </div>
</asp:Content>
