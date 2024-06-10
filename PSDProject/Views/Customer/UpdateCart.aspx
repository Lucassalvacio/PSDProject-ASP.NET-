<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="PSDProject.Views.Customer.UpdateCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
            <asp:TemplateField HeaderText="Quantity">
    <ItemTemplate>
        <asp:TextBox ID="QuantityTextBox" runat="server" Text="" Width="50px"></asp:TextBox>
    </ItemTemplate>
</asp:TemplateField> 
<asp:TemplateField>
    <ItemTemplate>
        <asp:Button ID="AddToCartButton" runat="server" Text="Update" CommandName="AddToCart" OnClientClick="return confirm('Add to cart?');" />
    </ItemTemplate>
</asp:TemplateField>
        </Columns>

    </asp:GridView>  
</asp:Content>
