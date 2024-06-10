<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="PSDProject.Views.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Home Page</h2>
<div>
    <h1>Stationery List</h1>
    <asp:GridView ID="StationeryGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="StationeryGridView_RowDeleting" OnRowEditing="StationeryGridView_RowEditing">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="No" SortExpression="StationeryID" />
            <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"/>
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>

    </asp:GridView>
    <br />
    <asp:Button ID="insertBtn" runat="server" Text="Insert New" OnClick="insertBtn_Click" />
</div>
</asp:Content>
