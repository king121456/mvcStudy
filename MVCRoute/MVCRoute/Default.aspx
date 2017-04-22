<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVCRoute.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>员工查看列表</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" 
            BorderColor="#3366CC" AutoGenerateColumns="false" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            Width="100%">
            <Columns>
                <asp:HyperLinkField HeaderText="姓名" DataTextField="Name" DataNavigateUrlFields="Name,Id" DataNavigateUrlFormatString="~/employees/{0}/{1}"/>
                <asp:BoundField HeaderText="性别" DataField="Gender"/>
                <asp:BoundField HeaderText="生日" DataFormatString="{0:dd/MM/yyyy}" DataField="Birthday"/>
                <asp:BoundField HeaderText="部门" DataField="Department"/>
            </Columns>
        </asp:GridView>
    
    </div>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="90px" Width="100%">
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="姓名" />
            <asp:BoundField DataField="Gender" HeaderText="性别" />
            <asp:BoundField DataField="Birthday" HeaderText="出生日期" 
                DataFormatString="{0:dd/MM/yyyy}" jt t/>
            <asp:BoundField DataField="Department" HeaderText="部门" />
        </Fields>
    </asp:DetailsView>
    </form>
</body>
</html>
