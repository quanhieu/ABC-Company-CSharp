<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Order_ThemMoi.ascx.cs" Inherits="cms_admin_Order_Order_ThemMoi" %>

<div class="head"> 
    Add, edit Order
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrNotify" runat="server"></asp:Literal>

        <div class="thongTin">
        <div class="tenTruong">OrderID</div>
        <div class="oNhap">
            <asp:TextBox ID="tbOrderID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="tbOrderID"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

      <div class="thongTin">
        <div class="tenTruong">Date Create (Month/Day/Year Hour/Minute/seconds AM/PM)</div>
        <div class="oNhap">
            <asp:TextBox ID="tbDateCreate" runat="server"></asp:TextBox>
        </div>
    </div>

       <div class="thongTin">
        <div class="tenTruong">Total money ($)</div>
        <div class="oNhap">
            <asp:TextBox ID="tbOrderMoney" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Order pay</div>
        <div class="oNhap">
            <asp:HiddenField ID="hdOldOrderpay" runat="server" />
            <asp:TextBox ID="tbOrderpay" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbOrderpay"
                Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">CustomerID</div>
        <div class="oNhap">
            <asp:TextBox ID="tbCustomerID" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Customer name</div>
        <div class="oNhap">
            <asp:TextBox ID="tbCustomerName" runat="server"></asp:TextBox>
        </div>
    </div>
      
     <div class="thongTin">
        <div class="tenTruong">Call number</div>
        <div class="oNhap">
            <asp:TextBox ID="tbCallNum" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="thongTin">
        <div class="tenTruong">Email</div>
        <div class="oNhap">
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        </div>
    </div>
                  
    <div class="thongTin">
        <div class="tenTruong">Order detail</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddlOrderDetail" runat="server">
                <asp:ListItem Text="Working" Value="Working"></asp:ListItem>
                <asp:ListItem Text="Done" Value="Done"></asp:ListItem>
                <asp:ListItem Text="Canceled" Value="Canceled"></asp:ListItem>
            </asp:DropDownList>
               
        </div>
    </div>


     <div class="thongTin">
        <div class="tenTruong"> &nbsp</div>
        <div class="oNhap"> <asp:CheckBox ID="cbAddMore" runat="server" Text="Continue creating another order after complete"/></div>
    </div>

    <div class="thongTin">
        <div class="tenTruong"> &nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btAddNew" runat="server" Text="Add neww" CssClass="btThemMoi" OnClick="btAddNew_Click"/>
            <asp:Button ID="btHuy" runat="server" Text="Cancel" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false"/>
        </div>
        
    </div>
</div>
