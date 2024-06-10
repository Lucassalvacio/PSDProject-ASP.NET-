<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="InsertStationeryAdmin.aspx.cs" Inherits="PSDProject.Views.Admin.InsertStaioneryAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="stationeryNameLbl" runat="server" Text="Stationery Name"></asp:Label><br />
    <asp:TextBox ID="stationeryNameTBox" runat="server"></asp:TextBox><br />
    <asp:Label ID="stationeryPriceLbl" runat="server" Text="Stationey Price"></asp:Label><br />
    <asp:TextBox ID="stationeryPriceTBox" runat="server"></asp:TextBox><br />
    <asp:Button ID="insertStationeryButton" runat="server" Text="Insert Stationery" OnClick="insertStationeryButton_Click" /><br />
</asp:Content>
