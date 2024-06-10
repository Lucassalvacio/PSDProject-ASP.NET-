<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/CustomerNavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="PSDProject.Views.Customer.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction History</h1>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
                <asp:BoundField DataField="MsUser.Username" HeaderText="Customer Name" SortExpression="MsUser.Username" />
                <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Detail" ShowHeader="True" Text="Transaction Detail" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
