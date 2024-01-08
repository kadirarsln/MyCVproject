<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiler.aspx.cs" Inherits="MyCVproject.AdminHobiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <form id="Form1" runat="server">

    <table class="table table-bordered">

        <tr>
            <th>ID</th>
            <th>HOBİ</th>          
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th><%# Eval("ID") %></th>
                        <td><%# Eval("HOBI") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminHobiDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>

                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminHobiUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink NavigateUrl="~/AdminHobiEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Yeni Hobi Ekle</asp:HyperLink>
</form>
</asp:Content>
