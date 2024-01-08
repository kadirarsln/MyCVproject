<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSertifikalar.aspx.cs" Inherits="MyCVproject.AdminSertifikalar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <form id="Form1" runat="server">

    <table class="table table-bordered">

        <tr>
            <th>ID</th>
            <th>BASLIK</th>  
            <th>SERTİFİKALARIM</th>          
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <th><%# Eval("ID") %></th>
                        <th><%# Eval("BASLIK") %></th>
                        <td><%# Eval("SERTIFIKALARIM") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminSertifikaDelete.Aspx?ID=" + Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>

                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminSertifikaUpdate.Aspx?ID=" + Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink NavigateUrl="~/AdminSertifikalarEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Yeni Sertifika Ekle</asp:HyperLink>
</form>
</asp:Content>
