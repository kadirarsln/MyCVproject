<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiUpdate.aspx.cs" Inherits="MyCVproject.AdminHobiUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
    <div class="form-group">
        <div>
            <asp:Label ID="Label6" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hobi"></asp:Label>
            <asp:TextBox ID="TxtHobi" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />

    </div>

</form>
</asp:Content>
