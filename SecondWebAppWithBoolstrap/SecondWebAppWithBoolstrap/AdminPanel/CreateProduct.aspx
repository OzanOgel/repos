<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="SecondWebAppWithBoolstrap.AdminPanel.CreateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card mt-3">
        <div class="card-header">
            <h4 class="card-title">Ürün Ekle</h4>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">İsim</label>
                        <asp:TextBox ID="lbl_name" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Kategori</label>
                        <asp:DropDownList ID="ddl_Categories" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Tedarikçi</label>
                        <asp:DropDownList ID="ddl_Suppliers" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Barkod Numarası</label>
                        <asp:TextBox ID="tb_barcode" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Stok Miktarı</label>
                        <asp:TextBox ID="tb_stock" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Güvenlik Stoğu</label>
                        <asp:TextBox ID="tb_ReorderLevel" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Fiyat</label>
                        <asp:TextBox ID="tb_price" runat="server" CssClass="form-control" Text="0,0"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Paketleme Miktarı</label>
                        <asp:TextBox ID="tb_quantityPerUnit" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-xl-4">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Sipariş Stok</label>
                        <asp:TextBox ID="tb_UnitsOnOrder" runat="server" CssClass="form-control" Text="0"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-xl-2">
                    <div class="mb-3 mt-3">
                        <label class="form-label">Resim Seçiniz</label>
                        <img src="https://placehold.co/600x400" class="img-thumbnail" id="img_image" />
                    </div>
                </div>
                <div class="col-xl-6">
                    <div class="row">
                        <div class="mb-3 mt-3">
                            <label class="form-label">Resim Seçiniz</label>
                            <asp:FileUpload ID="fu_image" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <div class="mb-3 mt-3">
                                <asp:CheckBox ID="cb_discontinued" runat="server" CssClass="form-check-input" />
                                <label class="form-check-label" for="ContentPlaceHolder1_cb_discontinued">Satıştan Kaldır</label>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="mb-3 mt-3">
                                <asp:CheckBox ID="cb_fastProduct" runat="server" CssClass="form-check-input" />
                                <label class="form-check-label" for="ContentPlaceHolder1_cb_fastProduct">Hızlı Satışa Ekle</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="card-footer">
            <asp:LinkButton ID="lbtn_create" runat="server" CssClass="btn btn-success float-end" OnClick="lbtn_create_Click">Ürün Ekle</asp:LinkButton>
            <a href="#" class="link-info float-end m-xl-2">Ürünler Listesine Git</a>
        </div>
    </div>
    
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.4.min.js" integrity="sha256-oP6HI9z1XaZNBrJURtCoUT5SUnxFr8s3BzRl+cbzUq8=" crossorigin="anonymous"></script>
    <script>
        function readUrl(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#img_image').attr('src', e.target.result);
                }
                reader.readAsDataURL(input.files[0]);

            }
        }
        $("#ContentPlaceHolder1_fu_image").change(function () {
            readUrl(this);
        })
    </script>

</asp:Content>
