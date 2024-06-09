<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSDProject.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:Button ID="submitRegisterBtn" runat="server" Text="Register" OnClick="submitRegisterBtn_Click"/><br />
            <asp:Button ID="alrHaveAcc" runat="server" Text="Already Have an Account?" OnClick="alrHaveAcc_Click" /><br />
            <asp:Button ID="dontWantToBeHere" runat="server" Text="Back" OnClick="dontWantToBeHere_Click"/>
        </div>
    </form>
</body>
</html>
