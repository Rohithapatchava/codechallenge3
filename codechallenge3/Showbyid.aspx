<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Showbyid.aspx.cs" Inherits="codechallenge3.Showbyid" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="enter a student id"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
<br />
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
  </div>

    <div>
         <asp:Label ID="Label2" runat="server" Text="enter faculty id"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <br />

    
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>

    <div>
        <asp:Label ID="Label3" runat="server" Text="enter course id"></asp:Label>
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

<br />
       <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        <br />
        <asp:GridView ID="GridView3" runat="server"></asp:GridView>
    </div>
</asp:Content>