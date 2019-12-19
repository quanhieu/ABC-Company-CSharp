<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  %>

<%@ Register Src="~/cms/display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABC company</title>
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/jquery-1.8.3.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">        
    <div id="dongke"></div>
    <!--đầu trang-->
    <div id="dautrang">
        <div class="contener">
            <div id="logo">
                <div id="logochu">
                    <asp:Literal ID="ltrLogo" runat="server"></asp:Literal>
                </div>
                <div id="logoanh">
                    <asp:Literal ID="ltrBanner" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>

    <!--menu đầu trang-->
    <div id="menudautrang">
        <div class="contener">
            <div id="menutrai">
                <ul class="menungang">
                    <asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
                </ul>
            </div>
            <div id="dangnhap">
                <asp:PlaceHolder ID="plChuaDangNhap" runat="server">
                    <ul>
                        <li class="dangnhap1">/<a href="Default.aspx?modul=ThanhVien&modulphu=DangKy">Sign up</a></li>
                        <li class="dangnhap2"><a href="Default.aspx?modul=ThanhVien&modulphu=DangNhap">Log In</a></li>
                    </ul>
                </asp:PlaceHolder>
                
                <asp:PlaceHolder ID="plDaDangNhap" runat="server" Visible="False">
                    <ul>
                        <li class="dangnhap1">/<asp:LinkButton ID="lbtDangXuat" runat="server" CausesValidation="False" OnClick="lbtDangXuat_Click">Log out</asp:LinkButton></li>
                        <li class="dangnhap2"><asp:Literal ID="ltrTenKhachHang" runat="server"></asp:Literal></li>
                    </ul>
                </asp:PlaceHolder>
            </div>
        </div>
    </div>

    <!--thanh tìm kiếm + giỏ hàng-->
    <div id="timkiem">
        <div class="contener">
            <div id="timkiem">
                <div class="timkiemtrai">
                        <div class="timkiemanh"></div>
                </div>
                <div class="timkiemphai">
                    <div class="giohang">
                        <a id="cart" style="display:inline-block" href="/Default.aspx?modul=SanPham&modulphu=GioHang"></a>
                    </div>
                    <div class="hotline">
                        <div class="label">HOTLINE</div>
                        <div class="number">096.1234.567 - 090.1234.567</div>
                    </div>

                    <div class="otimkiem">
                        <div class="search">
                           
                                <input type="text" class="key" placeholder="Search product" name="pr_name" value="<%=tukhoa %>" id="keysearch" onkeydown="CheckPostSearch(event)"/>
                                <a href="javascript://" onclick="PostSearch()" class="submit">&nbsp;</a>
                            
                            
                            <script type="text/javascript">
                                function CheckPostSearch(e) {
                                    if (e.keyCode === 13) {
                                        PostSearch();

                                        e.preventDefault();
                                    }
                                }

                                function PostSearch() {
                                    $("#keysearch").show().focus();
                                    if ($("#keysearch").val() !== "")
                                        window.location = "/Default.aspx?modul=SanPham&modulphu=TimKiem&tukhoa=" + $("#keysearch").val();
                                }
                            </script>
                       <%-- </div> --%>         
                        </div>           
                    </div>  
                </div>
            </div>
        </div>
    </div>

          <!--Sort-->
<%--   <div id="timkiem">
        <div class="contener">
            <div id="timkiem">
                <div class="timkiemphai">
              
                    <div class="octimkiem">
                        <div class="searchfind">
                            <div id="searchForm">
                                <input type="text" class="key" placeholder="Range of price product" name="pr_name" value="<%=money%>" id="keyfind" onkeydown="CheckPointSearch(event)"/>
                                <a href="javascript://" onclick="PointSearch()" class="submit">&nbsp;</a>
                            </div>
                            
                            <script type="text/javascript">
                                function CheckPointSearch(e) {
                                    if (e.keyCode === 13) {
                                        PointSearch();

                                        e.preventDefault();
                                    }
                                }

                                function PointSearch() {
                                    $("#keyfind").show().focus();
                                    if ($("#keyfind").val() !== "")
                                        window.location = "/Default.aspx?modul=SanPham&modulphu=AboutMoney&money=" + $("#keyfind").val();
                                }
                            </script>
                           
                        </div>           
                    </div>  
                </div>
            </div>
        </div>
    </div>--%>

    <!--thân trang-->
    <div id="thantrang">
        <div class="contener">
            <div id="trangtrai">
                <asp:PlaceHolder ID="plDanhMucSanPham" runat="server">
                    <div id="danhmuc">
                        <div class="daumuc"><a>Product category</a></div>
                        <div class="ditmuc">
                            <ul>
                                <asp:Literal ID="ltrDanhMucSanPham" runat="server"></asp:Literal>
                            </ul>
                        </div>   
                    </div>
                </asp:PlaceHolder>
                <asp:PlaceHolder ID="plDanhMucTinTuc" runat="server" Visible="False">
                    <div id="danhmuc">
                        <div class="daumuc"><a>News category</a></div>
                        <div class="ditmuc">
                            <ul>
                                <asp:Literal ID="ltrDanhMucTinTuc" runat="server"></asp:Literal>
                            </ul>
                        </div>   
                    </div>
                </asp:PlaceHolder>
                   <div class="contener">
                        <div class="octimkiem">
                            <div class="searchfind">
                               <div id="searchForm">
                                <input type="text" class="key" placeholder="Search range of price" name="pr_name" value="<%=money%>" id="keyfind" onkeydown="CheckPointSearch(event)"/>
                                <a href="javascript://" onclick="PointSearch()" class="submit">&nbsp;</a>
                              </div>
                            
                            <script type="text/javascript">
                                function CheckPointSearch(e) {
                                    if (e.keyCode === 13) {
                                        PointSearch();

                                        e.preventDefault();
                                    }
                                }

                                function PointSearch() {
                                    $("#keyfind").show().focus();
                                    if ($("#keyfind").val() !== "")
                                        window.location = "/Default.aspx?modul=SanPham&modulphu=AboutMoney&money=" + $("#keyfind").val();
                                }
                            </script>
                           </div>
                   
                           
                        </div>           
                    </div>  

                <div id="hotro">
                   <div id="pichotro">
                        <div class="logohotro">
                            <img src="css/images/akmasa.png" title="pichtro" />
                        </div>
                        <h3>Online support</h3>
                    </div>
                    <div class="support">
                        <div class="text-center">
                            <p>
                                <span class="supp-name">Thảo Ly</span>
                                <br />                    
                                <span class="phone">090.1234.567</span>
                            </p>                    
                        </div>
                        <div class="text-center">
                            <p>
                                <span class="supp-name">Huệ Anh</span>
                                <br />
                                <span class="phone">096.1234.567</span>
                            </p>                            
                        </div>
                        <div class="text-center">
                            <p>
                                <span class="supp-name">Working time</span>
                                <br />
                                <span class="phone">24/24</span>
                            </p>
                        </div>
                    </div>              
                </div>
                <div id="thanhtoan">
                    <div class="title-thanhtoan">
                        <a>Transaction information</a>
                    </div>
                    <div class="thongtinnganhang">
                        <div class="nganhang">
                            <img src="../css/images/nganhang/vietcombank.png" />
                            <p>
                                <strong>Vietcombank</strong>
                                <br>
                                Số TK: 0011 0031 68537
                                <br>
                                Chủ TK: Quang Hiếu
                                <br>
                                HCM Branch
                            </p>
                        </div>
                        <div class="nganhang">
                            <img src="../css/images/nganhang/agribank.png" />
                            <p>
                                <strong>Agribank</strong>
                                <br>
                                Số TK: 0011 0031 68537
                                <br>
                                Chủ TK: Quang Hiếu
                                <br>
                                HCM Branch
                            </p>
                        </div>
                        <div class="nganhang">
                            <img src="../css/images/nganhang/vietinbank.png" />
                            <p>
                                <strong>Vietincombank</strong>
                                <br>
                                Số TK: 0011 0031 68537
                                <br>
                                Chủ TK: Quang Hiếu
                                <br>
                                HCM Branch
                            </p>
                        </div>
                    </div>                   
                </div>
            </div>
            <div id="trangphai">
                <uc1:DisplayLoadControl runat="server" ID="DisplayLoadControl" />
            </div>
        </div>
    </div>

    <!--chân trang-->
    <div id="footer">



        <div class="contener">
            <div class=" menufoter">
                <p>©2018 Copyright by ABCompany</p>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
