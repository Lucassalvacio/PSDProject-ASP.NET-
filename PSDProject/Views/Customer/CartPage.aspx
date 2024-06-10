<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="PSDProject.Views.Customer.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart Page</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Stationery Quantity" SortExpression="Quantity" />
            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowEditButton="True" ShowDeleteButton="true" ShowHeader="True" />
        </Columns>

    </asp:GridView>
    <asp:Button ID="Checkout" runat="server" Text="Checkout" OnClick="Checkout_Click" />
</asp:Content>
