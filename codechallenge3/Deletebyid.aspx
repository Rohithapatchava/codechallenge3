<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Deletebyid.aspx.cs" Inherits="codechallenge3.Deletebyid" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="enter a student id"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>

    <div>
        <asp:Label ID="Label2" runat="server" Text="enter a faculty id"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <br />
        <div>
        <asp:Label ID="Label3" runat="server" Text="enter a course id"></asp:Label>
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
            <br />
    </div>
    </div>
</asp:Content>