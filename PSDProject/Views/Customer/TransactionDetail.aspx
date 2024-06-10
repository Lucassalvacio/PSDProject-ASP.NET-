<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="PSDProject.Views.Customer.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationary Name" SortExpression="MsStationery.StationeryName" />
                <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
