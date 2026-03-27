<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqDemo.aspx.cs" Inherits="WebLinqProgramOne.LinqDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>LINQ Basics Demo</h2>

            <asp:Label ID="lblCourse" runat="server" Text="Enter Course:" />
            <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>

            <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />

            <h3>Query Syntax Result</h3>
            <asp:GridView ID="gvQuerySyntax" runat="server" AutoGenerateColumns="true"></asp:GridView>

            <h3>Method Syntax Result</h3>
            <asp:GridView ID="gvMethodSyntax" runat="server" AutoGenerateColumns="true"></asp:GridView>

        </div>
    </form>
</body>
</html>
