<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSDProject.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="welcomeText" runat="server" Text="Welcome, "></asp:Label>
    </div>

    <div>
        <h1>RAiso's Stationary</h1>
        <asp:GridView ID="stationeryGV" runat="server" AutoGenerateColumns="False" OnRowEditing="stationeryGV_RowEditing" OnRowDeleting="stationeryGV_RowDeleting" OnRowCommand="stationeryGV_RowCommand"       >
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="insertStationeryButton" runat="server" Text="Insert Stationery" OnClick="insertStationeryButton_Click"/>
    </div>


</asp:Content>
