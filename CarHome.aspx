<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarHome.aspx.cs" Inherits="CarSalesApplication.CarHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Details</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
      body
      {
          margin-left:500px;
      }
       
    </style>
</head>
<body>
    <header><h1>CAR DETAILS</h1></header>
    <form id="form1" runat="server">
        <div>
            <br /><br />
            <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="CarModel"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="CarName"></asp:Label></td>
                     <td>:</td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Category"></asp:Label></td>
                     <td>:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>

                </tr>
                <tr><td><asp:Label ID="Label3" runat="server" Text="Price"></asp:Label></td>
                     <td>:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="YearOfModel"></asp:Label></td>
                     <td>:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Description"></asp:Label></td>
                     <td>:</td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                </tr>
                </table>
            <br />
            <br />
               <table>
                <tr>
                    <td><asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="INSERT" OnClick="Button1_Click" /></td>
                    <td><asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="DELETE" OnClick="Button2_Click" /></td>
                    <td><asp:Button ID="Button3" CssClass="btn btn-warning" runat="server" Text="UPDATE" OnClick="Button3_Click" /></td>
                    <td><asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="RESET" OnClick="Button4_Click" /></td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="Cartable" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
