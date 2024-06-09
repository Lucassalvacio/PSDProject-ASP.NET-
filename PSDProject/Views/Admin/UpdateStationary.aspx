<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateStationary.aspx.cs" Inherits="PSDProject.Views.Admin.UpdateStationary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Stationary</h1>
    <div>
         <asp:Label ID="stationeryNameLbl" runat="server" Text="Stationery Name"></asp:Label><br />
         <asp:TextBox ID="stationeryNameTBox" runat="server"></asp:TextBox><br />
         <asp:Label ID="stationeryPriceLbl" runat="server" Text="Stationey Price"></asp:Label><br />
         <asp:TextBox ID="stationeryPriceTBox" runat="server"></asp:TextBox><br />
         <asp:Button ID="updateStationeryButton" runat="server" Text="Update Stationery" OnClick="updateStationeryButton_Click" /><br />
    </div>
</asp:Content>
