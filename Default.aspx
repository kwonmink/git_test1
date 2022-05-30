<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>無題のページ</title>
    <style type="text/css">
    
        #form1
        {
            width: 396px;
            height: 325px;
        }
        
    </style>
    </head>


<body>
    <form id="form1" runat="server">   
      
        <asp:Button ID="Button1" runat="server" Text="検索" />&nbsp;<br />
        <asp:TextBox ID="TextBox1" runat="server"/><br />
        <asp:Label ID="Label1" runat="server" Text=""/><br /><br />
        
        
        <asp:Table ID="Table1" runat="server" BorderColor="#3333CC" BorderWidth="1px" GridLines="Both">
        </asp:Table>
        
        <br />
        <asp:Button ID="Button2" runat="server" Text="追加" />&nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="employeeid"/>&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"/><br />
        <asp:Label ID="Label3" runat="server" Text="departcode"/>&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"/><br />
        <asp:Label ID="Label4" runat="server" Text="employname"/>&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"/><br />
        <asp:Label ID="Label5" runat="server" Text="loginid"/>&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"/><br />
        <asp:Label ID="Label6" runat="server" Text="loginpass"/>&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"/><br />
        
        
        <asp:Label ID="Label7" runat="server" Text=""/>&nbsp;
        

        
    </form>
    
 
</body>

</html>
