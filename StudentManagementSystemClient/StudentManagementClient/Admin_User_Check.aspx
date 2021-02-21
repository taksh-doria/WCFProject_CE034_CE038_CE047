<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_User_Check.aspx.cs" Inherits="MovieRatingSystemClient.Admin_User_Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;margin:15px;">
            <span style="margin-right:10px"> 
            <asp:Button ID="Movie_" runat="server" 
                Text="Student" Width="198px" OnClick="Movie__Click" /></span> 
           <span style="margin-right:10px">  
            <asp:Button ID="User_" runat="server" 
                Text="User" Width="204px" OnClick="User__Click" /></span> 
            <span style="margin-right:10px">  
            <asp:Button ID="Logout" runat="server" 
                Text="Logout"  Width="234px" OnClick="Logout_Click" /></span> 
        </div>
        <div style="text-align:center">
            <asp:Label runat="server" ID="Admin_User_Label"></asp:Label>
        </div>

         <div style="margin-top:20px;margin-bottom:20px;">
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:TextBox placeholder="user name" ID="TextBox2" runat="server" 
                            Width="270px" Height="30px" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox placeholder="user password" ID="TextBox1" runat="server" 
                            Width="270px" Height="30px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox placeholder="user designation" ID="TextBox3" runat="server" Width="270px" Height="30px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>

        <div style="text-align:center;margin-top:40px;align-items:center">

            <asp:GridView ID="GridView1" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" 
                GridLines="None"
                 OnRowDeleting="GridView1_RowDeleting"
                OnRowUpdating="GridView1_RowUpdating"
               >
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />

                <Columns>
                    <asp:ButtonField ControlStyle-BackColor="Maroon" ControlStyle-ForeColor="White" 
                        ButtonType="Button" CommandName="Delete" Text="Delete" >
<ControlStyle BackColor="Maroon" ForeColor="White"></ControlStyle>
                    </asp:ButtonField>
                    <asp:ButtonField ControlStyle-BackColor="Blue" ControlStyle-ForeColor="White" ButtonType="Button" CommandName="Update" Text="Update" />
                </Columns> 
            </asp:GridView>

        </div>
    </form>
</body>
</html>
