<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSDProject.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="usernameTBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="loginErrorLbl" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/><br />
            <asp:Button ID="NoAcc" runat="server" Text="Dont Have an Account?" OnClick="NoAcc_Click"/><br />
            <asp:Button ID="dontWantToBeHere" runat="server" Text="Back" OnClick="dontWantToBeHere_Click"/>
        </div>
    </form>
</body>
</html>
