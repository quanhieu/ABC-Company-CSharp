<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page to administrator site</title>
    <link href="cms/admin/css/cssDangNhap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="FormDangNhap">
        <div class="head">Sign in</div>
        <div class="controls">
            <div class="row">
            <div class="left">User name</div>
            <div class="right">
                <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" 
                    ControlToValidate="tbTenDangNhap" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>            
        </div>
        <div class="row">
            <div class="left">Password</div>
            <div class="right">
                <asp:TextBox ID="tbMatKhau" runat="server" TextMode="password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" 
                    ControlToValidate="tbMatKhau" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>            
        </div>
        <div class="row">
            <div class="left">&nbsp;</div>
            <div class="right">
                <asp:LinkButton ID="lbtDangNhap" runat="server" CssClass="btDangNhap" OnClick="lbtDangNhap_Click" >Sign in</asp:LinkButton>
            </div>            
        </div>
        <div>
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
