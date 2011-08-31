<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachBai.aspx.cs" Inherits="SPKOnlineOLPContest.DanhSachBai" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="drDoKho" runat="server">
        </asp:DropDownList>
     <asp:Button ID="btnDoKho" runat="server" Text="Lay theo do kho" 
            onclick="btnDoKho_Click" />
        <br />
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
