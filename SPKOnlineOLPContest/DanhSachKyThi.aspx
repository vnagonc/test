<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachKyThi.aspx.cs" Inherits="SPKOnlineOLPContest.DanhSachKyThi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="grvKyThi" runat="server">
    </asp:GridView>
    <asp:DropDownList ID="drID" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btnLayTheoMa" runat="server" onclick="btnLayTheoMa_Click" 
        Text="Lấy theo mã kỳ thi" />
    </form>
</body>
</html>
