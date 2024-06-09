<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Profilepage.aspx.cs" Inherits="PSDProject.Views.Profilepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Profile</h1>
    <div>
        <asp:Label ID="usernameRegisterLbl" runat="server" Text="Username"></asp:Label><br />
        <asp:TextBox ID="usernameRegisterTBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="DOBRegisterLbl" runat="server" Text="Date Of Birth"></asp:Label><br />
        <asp:Calendar ID="DOBRegisterCal" runat="server"></asp:Calendar><br />
        <asp:Label ID="genderRegisterLbl" runat="server" Text="Select Gender"></asp:Label><br />
        <asp:RadioButtonList ID="genderRadioButtonList" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:Label ID="addressRegisterLbl" runat="server" Text="Address"></asp:Label><br />
        <asp:TextBox ID="addressRegisterTBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="passwordRegisterLbl" runat="server" Text="Password"></asp:Label><br />
        <asp:TextBox ID="passwordRegisterTBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="phoneRegisterLbl" runat="server" Text="Phone"></asp:Label><br />
        <asp:TextBox ID="phoneRegisterTBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="registerErrorLbl" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="submitRegisterBtn_Click"/><br />
       
    </div>
</asp:Content>
