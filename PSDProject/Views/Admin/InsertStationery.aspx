<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertStationery.aspx.cs" Inherits="PSDProject.Views.InsertStationery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="stationeryNameLbl" runat="server" Text="Stationery Name"></asp:Label><br />
            <asp:TextBox ID="stationeryNameTBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="stationeryPriceLbl" runat="server" Text="Stationey Price"></asp:Label><br />
            <asp:TextBox ID="stationeryPriceTBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="insertStationeryButton" runat="server" Text="Insert Stationery" OnClick="insertStationeryButton_Click" /><br />
        </div>
    </form>
</body>
</html>
